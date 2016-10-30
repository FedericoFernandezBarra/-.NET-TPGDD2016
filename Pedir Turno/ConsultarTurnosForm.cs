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
    public partial class ConsultarTurnosForm : Form
    {
        Turno turno { get; set; }
        TurnoRepository turnoRepository;
        Usuario afiliado;
        List<String> horariosPosibles = new List<String>();
        Agenda agendaDelProfesional;

        public ConsultarTurnosForm(Usuario usuario)
        {
            InitializeComponent();
            afiliado = usuario;
            turno = new Turno();
            turnoRepository = new TurnoRepository();
            turno.afiliado.usuario.id = usuario.id;
        }

        private void btnConsultarDisponibilidad_Click(object sender, EventArgs e)
        {

            //Primer filtro: la fecha esta dentro de la agenda
            if(obtenerFechaSeleccionada() < agendaDelProfesional.fecha_inicial || obtenerFechaSeleccionada() > agendaDelProfesional.fecha_final)
            {
                MessageBox.Show("La fecha seleccionada está fuera de la agenda del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Segundo filtro: el dia no es domingo
                if (obtenerFechaSeleccionada().DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    MessageBox.Show("El profesional no trabaja en el día seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Tercer filtro: el profesional atiende esa especialidad en ese dia
                    List<DiaAgenda> diaSeleccionado = agendaDelProfesional.diasAgendaDelDia(obtenerDiaSeleccionado());
                    if (diaSeleccionado.Any(unDia => unDia.idEspecialidad.Equals(turno.especialidad.id)))
                    {
                        //Cuarto filtro: horarios definidos en la agenda de ese dia
                        diaSeleccionado.ForEach(unHorario => obtenerHorariosPosibles(unHorario.horaInicial, unHorario.horaFinal));
                        
                        //Quinto filtro: eliminar horarios que ya posee turno asignado
                        filtrarHorariosYaTomados();
                        cmbHorariosDisponibles.DataSource = horariosPosibles;
                        cmbHorariosDisponibles.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El profesional no trabaja en la especialidad elegida en el día seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            BuscarProfesionalForm buscarProfesionalForm = new BuscarProfesionalForm();

            Hide();

            buscarProfesionalForm.ShowDialog();

            Show();

            if (buscarProfesionalForm.seSeleccionoUnProfesional())
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                AgendaRepository agendaRepository = new AgendaRepository();
                Usuario profesionalSeleccionado = usuarioRepository.traerUsuarioPorId(buscarProfesionalForm.getProfesionalSeleccionado().usuario.id);
                try
                {
                    agendaDelProfesional = agendaRepository.traerAgendaDelProfesional(profesionalSeleccionado);

                    turno.profesional = buscarProfesionalForm.getProfesionalSeleccionado();
                    turno.especialidad = buscarProfesionalForm.getEspecialidadSeleccionada();

                    txtProfesional.Text = profesionalSeleccionado.apellido + " " + profesionalSeleccionado.nombre
                        + " - " + turno.especialidad.descripcion;

                    btnConsultarDisponibilidad.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("ERROR: El profesional seleccionado no dispone de una agenda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }        
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarTurno_Click(object sender, EventArgs e)
        {
            DateTime horarioDeTurno = Convert.ToDateTime(cmbHorariosDisponibles.SelectedItem);
            DateTime fechaYHorarioDeTurno = new DateTime(obtenerFechaSeleccionada().Year, obtenerFechaSeleccionada().Month, 
                obtenerFechaSeleccionada().Day, horarioDeTurno.Hour, horarioDeTurno.Minute, 0);

            turno.fechaDeTurno = fechaYHorarioDeTurno;

            //Inserta el turno en la tabla y devuelve la respuesta del stored
            MessageBox.Show(turnoRepository.reservarTurno(turno));
            Close();
        }

        private void ConsultarTurnosForm_Load(object sender, EventArgs e)
        {
            txtAfiliado.Text = afiliado.apellido + " " + afiliado.nombre;

            mcFechaDeTurno.MinDate = DataBase.Instance.getDate();
            mcFechaDeTurno.TodayDate = DataBase.Instance.getDate();
            mcFechaDeTurno.SetDate(DataBase.Instance.getDate());

            lblFechaElegida.Text = obtenerFechaSeleccionada().ToString("dd/MM/yyyy");
        }

        private DateTime obtenerFechaSeleccionada()
        {
            return mcFechaDeTurno.SelectionRange.Start;
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
                    return "MIERCOLES";
                case DayOfWeek.Thursday: 
                    return "JUEVES";
                case DayOfWeek.Friday: 
                    return "VIERNES";
                case DayOfWeek.Saturday: 
                    return "SABADO";
                case DayOfWeek.Sunday: 
                    return "DOMINGO";
                default: return null;
            }
        }

        private void obtenerHorariosPosibles(TimeSpan horarioDesde, TimeSpan horarioHasta)
        {
            TimeSpan horarioAcumulador = horarioDesde;
            while (horarioAcumulador.CompareTo(horarioHasta) < 0)
            {
                horarioAcumulador = horarioAcumulador.Add(TimeSpan.FromMinutes(30));
                horariosPosibles.Add(horarioAcumulador.ToString(@"hh\:mm"));
            }
        }

        private void filtrarHorariosYaTomados()
        {
            foreach (String horario in horariosPosibles)
            {
                if (turnoRepository.existeTurnoActivo(turno.profesional, DateTime.Parse(horario)))
                {
                    horariosPosibles.Remove(horario);
                }
            }
        }

        private void mcFechaDeTurno_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblFechaElegida.Text = obtenerFechaSeleccionada().ToString("dd/MM/yyyy");
        }
    }
}
