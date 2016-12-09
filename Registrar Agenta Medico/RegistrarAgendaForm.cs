using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class RegistrarAgendaForm : Form
    {
        /*ATRIBUTOS*/
        /*************************************************************************************/

        Agenda agenda { get; set; }

        Dictionary<string, long> especialidadesDelProfesional { get; set; }

        Usuario usuario { get; set; }

        AgendaRepository agendaDAO { get; set; }


        /*FUNCIONES*/
        /*************************************************************************************/

        public RegistrarAgendaForm(Usuario usua)
        {
            InitializeComponent();
            
            usuario = usua;
            agendaDAO = new AgendaRepository();

            agenda = agendaDAO.traerAgendaDelProfesional(usuario);
            especialidadesDelProfesional = agendaDAO.traerEspecialidadesDeProfesional(usuario);

            cargarElementosDeLaVista();
        }

        private void cargarElementosDeLaVista()
        {
            listBoxDias.Items.Clear();
            listBoxDias.Items.AddRange(new object[] { "LUNES", "MARTES", "MIÉRCOLES", "JUEVES", "VIERNES", "SÁBADO" });
            listBoxDias.SelectedIndex = 0;

            if (especialidadesDelProfesional != null)
            {
                listBoxEspecialidades.Items.Clear();
                foreach (var item in especialidadesDelProfesional)
                {
                    listBoxEspecialidades.Items.Add(item.Key);
                }
                listBoxEspecialidades.SelectedIndex = 0;
            }

            if (agenda.tipoAgenda == TipoAgenda.Actual)
            {
                timerFechaDesde.Value = agenda.fecha_inicial;
                timerFechaDesde.Enabled = false;

                timerFechaHasta.Value = agenda.fecha_final;
                timerFechaHasta.Enabled = false;

                botonGuardarCambios.Enabled = false;

            }
            else
            {
                timerFechaDesde.Format = DateTimePickerFormat.Custom;
                timerFechaDesde.CustomFormat = " ";
                timerFechaHasta.Format = DateTimePickerFormat.Custom;
                timerFechaHasta.CustomFormat = " ";
            }
            timeHoraDesde.Value = new DateTime(2016, 1, 1, 0, 0, 0);
            timeHoraHasta.Value = new DateTime(2016, 1, 1, 0, 0, 0);
            actualizarHorasTrabajadas();
            cargarGriedViewDeHorarios();
        }

        private void actualizarHorasTrabajadas()
        {
            if (agenda.listaDeDiasAgenda.Count == 0) return;

            double horas = Math.Floor(agenda.horasTrabajadasEnLaSemana());
            double minutos = agenda.horasTrabajadasEnLaSemana() - horas;

            lbHorasTotales.Text = horas.ToString() + ":";
            lbHorasTotales.Text += (minutos != 0)? "30 hs.": "00 hs.";
        }

        private void cargarGriedViewDeHorarios()
        {
            dgHorarios.Rows.Clear();

            foreach (DiaAgenda diaAgenda in agenda.diasAgendaDelDia(listBoxDias.SelectedItem.ToString()))
            {
                string nombresEsp = "";
                foreach (var esp in diaAgenda.especialidades)
                {
                    nombresEsp += esp.Key + " --- ";
                }
                dgHorarios.Rows.Add(nombresEsp, diaAgenda.horaInicial, diaAgenda.horaFinal);
            }
            dgHorarios.AutoResizeColumns();
            dgHorarios.AutoResizeRows();
        }

        /*VALIDACIONES*/
        /*************************************************************************************/

        private bool seCumplenLasValidacionesParaAgregarDiaAgenda()
        {
            if ((timeHoraDesde.Value.TimeOfDay < new TimeSpan(7, 0, 0) || timeHoraHasta.Value.TimeOfDay > new TimeSpan(20, 1, 0) )&& listBoxDias.SelectedItem.ToString() != "SÁBADO" || 
                ((timeHoraDesde.Value.TimeOfDay < new TimeSpan(10, 0, 0) || timeHoraHasta.Value.TimeOfDay > new TimeSpan(15, 1, 0)) && listBoxDias.SelectedItem.ToString() == "SÁBADO") )
            {
                MessageBox.Show("Los horarios no concuerdan con el rango de horarios de atencion del Hospital", "Error", MessageBoxButtons.OK);
                return false;
            }

            if ((timeHoraDesde.Value.Minute != 30 && timeHoraDesde.Value.Minute != 0) || (timeHoraHasta.Value.Minute != 30 && timeHoraHasta.Value.Minute != 0))
            {
                MessageBox.Show("Los horarios deben estar en bloques de 30 minutos Ejemplo: 7:00 o 16:30", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (timeHoraDesde.Value.TimeOfDay >= timeHoraHasta.Value.TimeOfDay)
            {
                MessageBox.Show("Horarios incoherentes", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (agenda.esteHorarioEstaOcupado(listBoxDias.SelectedItem.ToString(), timeHoraDesde.Value.TimeOfDay) || agenda.esteHorarioEstaOcupado(listBoxDias.SelectedItem.ToString(), timeHoraHasta.Value.TimeOfDay))
            {
                MessageBox.Show("El rango de horarios ingresado se superpone a otro ya existente", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (listBoxEspecialidades.Items.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna especialidad", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (agenda.horasTrabajadasEnLaSemana() > 48)
            {
                MessageBox.Show("El maximo de horas a trabajar es de 48 horas", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (lbEspe.Items.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna especialidad", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool seCumpleLasValidacionesParaGuardarCambios()
        {
            if (timerFechaDesde.Value.Date >= timerFechaHasta.Value.Date)
            {
                MessageBox.Show("El rango de fechas son incoherentes", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (timerFechaDesde.Value.Date < agendaDAO.fechaSistema.Date || timerFechaHasta.Value.Date < agendaDAO.fechaSistema.Date)
            {
                MessageBox.Show("Las fechas ingresadas son anteriores a las del dia de hoy", "Error", MessageBoxButtons.OK);
                return false;
            } 

            if ((agenda.tipoAgenda == TipoAgenda.Vencido || agenda.tipoAgenda == TipoAgenda.Nuevo) && timerFechaHasta.Value.Date < agendaDAO.fechaSistema.Date)
            {
                MessageBox.Show("No se han realizado cambios para guardar", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool seCumpleLasValidacionesParaAgregarEspecialidad()
        {
            List<string> lista = new List<string>();
            foreach (var item in lbEspe.Items)
            {
                lista.Add(item.ToString());
            }

            if (lista.Exists(x=> x == listBoxEspecialidades.SelectedItem.ToString()))
            {
                MessageBox.Show("La especialidad seleccionada ya fue agregada", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        /*BOTONES Y EVENTOS*/
        /*************************************************************************************/

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (!seCumplenLasValidacionesParaAgregarDiaAgenda()) return;
            
            TimeSpan horaDesde = new TimeSpan(timeHoraDesde.Value.Hour, timeHoraDesde.Value.Minute, 0);
            TimeSpan horaHasta = new TimeSpan(timeHoraHasta.Value.Hour, timeHoraHasta.Value.Minute, 0);

            string nombreDia = listBoxDias.SelectedItem.ToString();

            Dictionary<string, long> especialidades = new Dictionary<string, long>();
            foreach (string esp in lbEspe.Items)
            {
                especialidades.Add(esp, especialidadesDelProfesional[esp]);
            }

            agenda.listaDeDiasAgenda.Add(new DiaAgenda(0, nombreDia, especialidades, horaDesde, horaHasta));

            lbEspe.Items.Clear();
            cargarGriedViewDeHorarios();
            actualizarHorasTrabajadas();
        }
        
        private void botonGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!seCumpleLasValidacionesParaGuardarCambios()) return;

            try
            {
                agenda.fecha_inicial = timerFechaDesde.Value;
                agenda.fecha_final = timerFechaHasta.Value;

                agendaDAO.insertarAgenda(agenda);
                
                MessageBox.Show("Se han guardado los cambios exitosamente");

                agenda.tipoAgenda = TipoAgenda.Actual;
                cargarElementosDeLaVista();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar los cambios. Error "+ ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }
        }

        private void listBoxDias_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxDias.SelectedIndex == -1) return;

            cargarGriedViewDeHorarios();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDias.SelectedIndex == -1 || dgHorarios.SelectedRows.Count == 0) return;

                string dia = listBoxDias.SelectedItem.ToString();
                TimeSpan horaDesde = (TimeSpan)dgHorarios.SelectedRows[0].Cells["DESDE_LAS"].Value;
                TimeSpan horaHasta = (TimeSpan)dgHorarios.SelectedRows[0].Cells["HASTA_LAS"].Value;

                agenda.listaDeDiasAgenda.RemoveAll(x =>
                    x.nombreDia == dia &&
                    x.horaInicial == horaDesde &&
                    x.horaFinal == horaHasta);
                
                cargarGriedViewDeHorarios();
                actualizarHorasTrabajadas();
            }
            catch
            {
                MessageBox.Show("Elemento seleccionado no valido", "Error", MessageBoxButtons.OK);
            }
        }

        private void btAgregarEspe_Click(object sender, EventArgs e)
        {
            if (!seCumpleLasValidacionesParaAgregarEspecialidad()) return;

            lbEspe.Items.Add(listBoxEspecialidades.SelectedItem.ToString());
        }

        private void btEliminarEspe_Click(object sender, EventArgs e)
        {
            try
            {
                lbEspe.Items.Remove(lbEspe.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Elemento seleccionado no valido", "Error", MessageBoxButtons.OK);
                throw;
            }
            
        }

        private void timerFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            timerFechaDesde.CustomFormat = "dd/MM/yyyy";
        }

        private void timerFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            timerFechaHasta.CustomFormat = "dd/MM/yyyy";
        }

        private void timerFechaDesde_Enter(object sender, EventArgs e)
        {
           System.Windows.Forms.SendKeys.Send("%{DOWN}");
        }

        private void timerFechaDesde_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("%{DOWN}");
        }

        private void timerFechaHasta_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("%{DOWN}");
        }

        private void timerFechaHasta_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("%{DOWN}");
        }
    }
}
