using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class RegistrarAgendaForm : Form
    {
        /*ATRIBUTOS*/
        /*************************************************************************************/

        Agenda agenda { get; set; }

        List<DiaAgenda> diasAgendaAAgregar { get; set; }

        Dictionary<long, string> especialidadesDelPersonal { get; set; }

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
            if (agenda == null) agenda = new Agenda(0, 0, new DateTime(), new DateTime(), new List<DiaAgenda>());

            diasAgendaAAgregar = new List<DiaAgenda>();
            especialidadesDelPersonal = agendaDAO.traerEspecialidadesDeProfesional(usuario);

            cargarElementosDeLaVista();
        }

        private void cargarElementosDeLaVista()
        {
            listBoxDias.Items.AddRange(new object[] { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO" });
            listBoxDias.SelectedIndex = 0;

            if (especialidadesDelPersonal != null)
            {
                foreach (KeyValuePair<long, string> item in especialidadesDelPersonal)
                {
                    listBoxEspecialidades.Items.Add(item.Value);
                }
                listBoxEspecialidades.SelectedIndex = 0;
            }

            if (agenda.idAgenda != 0)
            {
                timerFechaDesde.Value = agenda.fecha_inicial;
                timerFechaDesde.Enabled = false;

                timerFechaHasta.Value = agenda.fecha_final;
                timerFechaHasta.Enabled = false;
            }

            actualizarHorasTrabajadas();
        }

        private void actualizarHorasTrabajadas()
        {
            if (agenda.listaDeDiasAgenda.Count == 0) return;

            double horas = Math.Floor(agenda.horasTrabajadasEnLaSemana());
            double minutos = agenda.horasTrabajadasEnLaSemana() - horas;

            lbHorasTotales.Text = horas.ToString() + ":";

            if (minutos != 0) lbHorasTotales.Text += "30 hs.";
            else lbHorasTotales.Text += "00 hs.";
        }

        private void cargarGriedViewDeHorarios()
        {
            dgHorarios.Rows.Clear();

            foreach (DiaAgenda diaAgenda in agenda.diasAgendaDelDia(listBoxDias.SelectedItem.ToString()))
            {
                dgHorarios.Rows.Add(diaAgenda.nombreEspecialidad, diaAgenda.horaInicial, diaAgenda.horaFinal);
            }
            dgHorarios.AutoResizeColumns();
            dgHorarios.AutoResizeRows();
        }

        /*VALIDACIONES*/
        /*************************************************************************************/

        private bool seCumplenLasValidacionesParaAgregar()
        {
            if ((timeHoraDesde.Value.TimeOfDay < new TimeSpan(7, 0, 0) || timeHoraHasta.Value.TimeOfDay > new TimeSpan(20, 0, 0) )&& listBoxDias.SelectedItem.ToString() != "SABADO" || 
                ((timeHoraDesde.Value.TimeOfDay < new TimeSpan(10, 0, 0) || timeHoraHasta.Value.TimeOfDay > new TimeSpan(15, 0, 0)) && listBoxDias.SelectedItem.ToString() == "SABADO") )
            {
                MessageBox.Show("Los horarios no concuerdan con el rango de horarios de atencion del Hospital", "Error", MessageBoxButtons.OK);
                return false;
            }

            if ((timeHoraDesde.Value.Minute != 30 && timeHoraDesde.Value.Minute != 0 ) || (timeHoraHasta.Value.Minute != 30 && timeHoraHasta.Value.Minute != 0))
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

            return true;
        }

        private bool seCumpleLasValidacionesParaGuardarCambios()
        {
            if (timerFechaDesde.Value.Date >= timerFechaHasta.Value.Date)
            {
                MessageBox.Show("El rango de fechas son incoherentes", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (timerFechaDesde.Value.Date < DateTime.Now || timerFechaHasta.Value.Date < DateTime.Now)
            {
                MessageBox.Show("Las fechas ingresadas son anteriores a las del dia de hoy", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        /*BOTONES Y EVENTOS*/
        /*************************************************************************************/

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (!seCumplenLasValidacionesParaAgregar()) return;

            TimeSpan horaDesde = new TimeSpan(timeHoraDesde.Value.Hour, timeHoraDesde.Value.Minute, 0);
            TimeSpan horaHasta = new TimeSpan(timeHoraHasta.Value.Hour, timeHoraHasta.Value.Minute, 0);

            long idEspecialidad = 0;
            foreach (KeyValuePair<long, string> dic in especialidadesDelPersonal)
            {
                if (dic.Value == listBoxEspecialidades.SelectedItem.ToString()) idEspecialidad = dic.Key;
            }

            string nombreDia = listBoxDias.SelectedItem.ToString();
            string nombreEspecialidad = listBoxEspecialidades.SelectedItem.ToString();

            diasAgendaAAgregar.Add(new DiaAgenda(nombreDia, idEspecialidad, nombreEspecialidad, horaDesde, horaHasta));
            agenda.listaDeDiasAgenda.Add(new DiaAgenda(nombreDia, idEspecialidad, nombreEspecialidad, horaDesde, horaHasta));

            cargarGriedViewDeHorarios();
            actualizarHorasTrabajadas();
        }
        
        private void botonGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                //se crea la agenda por primera vez
                if (agenda.idAgenda == 0)
                    agendaDAO.insertarAgendaNueva(usuario.id, timerFechaDesde.Value.Date, timerFechaHasta.Value.Date, diasAgendaAAgregar);
                //la agenda ya existe y le esta agregando mas horas
                else
                    agendaDAO.insertarNuevosDiasAgenda(agenda, diasAgendaAAgregar);

                MessageBox.Show("Se han guardado los cambios exitosamente");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar los cambios", "Error", MessageBoxButtons.OK);
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

    }
}
