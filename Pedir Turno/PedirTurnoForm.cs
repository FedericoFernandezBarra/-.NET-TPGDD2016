using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TostadoPersistentKit;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class PedirTurnoForm : Form
    {
        Turno turno { get; set; }
        TurnoRepository turnoRepository;

        public PedirTurnoForm(Usuario usuario, Rol rol)
        {
            InitializeComponent();
            turno = new Turno();
            turnoRepository = new TurnoRepository();

            if (rol.nombre == "AFILIADO")
            {
                turno.afiliado.usuario.id = usuario.id;
                btnBuscarProfesional.Enabled = true;
            }
            else
            {
                btnBuscarAfiliado.Visible = true;
            }
        }

        private void btnConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            Agenda agendaDelProfesional;
            //Primer filtro: el dia no es domingo
            if (obtenerFechaSeleccionada().DayOfWeek.Equals(DayOfWeek.Sunday))
            {
                MessageBox.Show("El profesional no trabaja en el día seleccionado.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Segundo filtro: el profesional tiene el dia elegido en su agenda.
                agendaDelProfesional = new AgendaRepository().obtenerAgendaDe(turno.profesional,
                    turno.especialidad, mcFechaDeTurno.SelectionRange.Start);
                if (agendaDelProfesional == null)
                {
                    MessageBox.Show("ERROR: El profesional no tiene agenda definida para su especialidad en la fecha elegida (" +
                        obtenerFechaSeleccionada().ToString("dd/MM/yyyy") + ").", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<DiaAgenda> diaSeleccionado = agendaDelProfesional.listaDeDiasAgenda.Where
                        (unDiaDeAgenda => unDiaDeAgenda.nombreDia.Equals(obtenerDiaSeleccionado())).ToList();
                    if (diaSeleccionado.Count > 0)
                    {
                        //Tercer filtro: horarios definidos en la agenda de ese dia
                        List<String> horariosPosibles = new List<String>();
                        diaSeleccionado.ForEach(unHorario => obtenerHorariosPosibles(horariosPosibles, unHorario.horaInicial, unHorario.horaFinal));

                        //Cuarto filtro: eliminar horarios que ya pasaron
                        filtrarHorariosPasados(horariosPosibles);

                        if (horariosPosibles.Count == 0)
                        {
                            MessageBox.Show("El profesional ya no atiende en el dia de hoy.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //Quinto filtro: eliminar horarios que ya poseen turno asignado
                            filtrarHorariosYaTomados(horariosPosibles);

                            //Sexto filtro: el profesional tiene todos los turnos ocupados
                            if (horariosPosibles.Count == 0)
                            {
                                MessageBox.Show("El profesional no tiene turnos disponibles en el día seleccionado.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cmbHorariosDisponibles.DataSource = horariosPosibles;
                                cmbHorariosDisponibles.Enabled = true;
                                btnConfirmarTurno.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El profesional no trabaja en la especialidad elegida en el día seleccionado.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            BuscarProfesionalForm buscarProfesionalForm = new BuscarProfesionalForm(true);

            Hide();

            buscarProfesionalForm.ShowDialog();

            Show();

            if (buscarProfesionalForm.seSeleccionoUnProfesional())
            {
                Usuario profesionalSeleccionado = buscarProfesionalForm.getProfesionalSeleccionado().usuario;

                turno.profesional = buscarProfesionalForm.getProfesionalSeleccionado();
                turno.especialidad = buscarProfesionalForm.getEspecialidadSeleccionada();
                mcFechaDeTurno.MinDate = DataBase.Instance.getDate();
                mcFechaDeTurno.SelectionRange.Start = mcFechaDeTurno.MinDate;

                txtProfesional.Text = profesionalSeleccionado.nombreCompleto
                    + " - " + turno.especialidad.descripcion;

                btnConsultarDisponibilidad.Enabled = true;
                cmbHorariosDisponibles.Enabled = false;
                btnConfirmarTurno.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarTurno_Click(object sender, EventArgs e)
        {
            turno.fechaDeTurno = obtenerFechaYHorarioDeTurno();
            String respuesta = turnoRepository.reservarTurno(turno);
            if (respuesta.Contains("exitosamente")) //D'fiesta pura
            {
                MessageBox.Show(respuesta, "Pedido de turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConsultarTurnosForm_Load(object sender, EventArgs e)
        {
            if (!btnBuscarAfiliado.Visible) //D'fiesta parte 2
            {
                txtAfiliado.Text = turno.afiliado.usuario.nombreCompleto;
            }

            mcFechaDeTurno.MinDate = DataBase.Instance.getDate();
            mcFechaDeTurno.TodayDate = DataBase.Instance.getDate();
            mcFechaDeTurno.SetDate(DataBase.Instance.getDate());

            lblFechaElegida.Text = obtenerFechaSeleccionada().ToString("dd/MM/yyyy");
        }

        private DateTime obtenerFechaSeleccionada()
        {
            return mcFechaDeTurno.SelectionRange.Start;
        }

        private DateTime obtenerFechaYHorarioDeTurno()
        {
            DateTime horarioDeTurno = Convert.ToDateTime(cmbHorariosDisponibles.SelectedItem);
            return new DateTime(obtenerFechaSeleccionada().Year, obtenerFechaSeleccionada().Month,
                obtenerFechaSeleccionada().Day, horarioDeTurno.Hour, horarioDeTurno.Minute, 0);
        }

        private String obtenerDiaSeleccionado()
        {
            switch (obtenerFechaSeleccionada().DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "LUNES";
                case DayOfWeek.Tuesday:
                    return "MARTES";
                case DayOfWeek.Wednesday:
                    return "MIÉRCOLES";
                case DayOfWeek.Thursday:
                    return "JUEVES";
                case DayOfWeek.Friday:
                    return "VIERNES";
                case DayOfWeek.Saturday:
                    return "SÁBADO";
                case DayOfWeek.Sunday:
                    return "DOMINGO";
                default: return null;
            }
        }

        private void obtenerHorariosPosibles(List<String> horariosPosibles, TimeSpan horarioDesde, TimeSpan horarioHasta)
        {
            TimeSpan horarioAcumulador = horarioDesde;
            horariosPosibles.Add(horarioAcumulador.ToString(@"hh\:mm"));
            while (horarioAcumulador.Add(TimeSpan.FromMinutes(30)).CompareTo(horarioHasta) < 0)
            {
                horarioAcumulador = horarioAcumulador.Add(TimeSpan.FromMinutes(30));
                horariosPosibles.Add(horarioAcumulador.ToString(@"hh\:mm"));
            }
        }

        private void filtrarHorariosYaTomados(List<String> horariosPosibles)
        {
            List<String> horariosASacar = horariosPosibles.Where
                (unHorarioDeTurno => turnoRepository.existeTurnoActivo(turno.profesional,
                new DateTime(obtenerFechaSeleccionada().Year, obtenerFechaSeleccionada().Month,
                obtenerFechaSeleccionada().Day, DateTime.Parse(unHorarioDeTurno).Hour, 
                DateTime.Parse(unHorarioDeTurno).Minute, 0))).ToList();
            foreach (String horarioASacar in horariosASacar)
            {
                horariosPosibles.Remove(horarioASacar);
            }
        }

        private void filtrarHorariosPasados(List<String> horariosPosibles)
        {
            DateTime fechaYHoraDelSistema = DataBase.Instance.getDate();
            List<String> horariosASacar = new List<String>();
            if (obtenerFechaSeleccionada().Date == fechaYHoraDelSistema.Date)
            {
                if(fechaYHoraDelSistema.Minute > 30)
                {
                    obtenerHorariosPosibles(horariosASacar, new TimeSpan(1, 0, 0), new TimeSpan(fechaYHoraDelSistema.Hour + 1, 0, 0));
                }
                else
                {
                    if (fechaYHoraDelSistema.Minute == 0)
                    {
                        obtenerHorariosPosibles(horariosASacar, new TimeSpan(1, 0, 0), new TimeSpan(fechaYHoraDelSistema.Hour, 0, 0));
                    }
                    else
                    {
                        obtenerHorariosPosibles(horariosASacar, new TimeSpan(1, 0, 0), new TimeSpan(fechaYHoraDelSistema.Hour, 30, 0));
                    }
                       
                }
                foreach (String horarioASacar in horariosASacar)
                {
                    horariosPosibles.Remove(horarioASacar);
                }
            }
        }
            

        private void mcFechaDeTurno_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblFechaElegida.Text = obtenerFechaSeleccionada().ToString("dd/MM/yyyy");
            cmbHorariosDisponibles.Enabled = false;
            btnConfirmarTurno.Enabled = false;
        }

        private void btnBuscarAfiliado_Click(object sender, EventArgs e)
        {
            BuscarAfiliadoForm buscarAfiliadoForm = new BuscarAfiliadoForm();

            Hide();

            buscarAfiliadoForm.ShowDialog();

            Show();

            if (buscarAfiliadoForm.seSeleccionoUnAfiliado())
            {
                turno.afiliado = buscarAfiliadoForm.getAfiliadoSeleccionado();

                txtAfiliado.Text = turno.afiliado.usuario.nombreCompleto;

                btnBuscarProfesional.Enabled = true;
            }
        }
    }
}
