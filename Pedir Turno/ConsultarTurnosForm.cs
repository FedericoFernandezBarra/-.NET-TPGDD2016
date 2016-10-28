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
        Usuario afiliado;
        List<String> horariosPosibles = new List<String>();
        Agenda agendaDelProfesional;

        public ConsultarTurnosForm(Usuario usuario)
        {
            InitializeComponent();
            afiliado = usuario;
            turno = new Turno();
            turno.afiliado.idUsuario = usuario.id;
        }

        private void btnConsultarDisponibilidad_Click(object sender, EventArgs e)
        {

            //Primer filtro: la fecha esta dentro de la agenda
            if(obtenerFechaSeleccionada() < agendaDelProfesional.fecha_inicial || obtenerFechaSeleccionada() > agendaDelProfesional.fecha_final)
            {
                MessageBox.Show("La fecha seleccionada está fuera de la agenda del profesional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Segundo filtro: el dia no es domingo
                if (obtenerFechaSeleccionada().DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    MessageBox.Show("El profesional no trabaja en el día seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Tercer filtro: el profesional atiende esa especialidad en ese dia
                    if (agendaDelProfesional.diasAgendaDelDia(obtenerDiaSeleccionado()).Any(unDia => unDia.idEspecialidad.Equals(turno.especialidad.id)))
                    {
                        //Cuarto filtro: horariosFull con horariosDeAgenda
                        obtenerHorariosPosibles(new DateTime(1990, 1, 1, 7, 0, 0), new DateTime(1990, 1, 1, 19, 30, 0));

                        cmbHorariosDisponibles.DataSource = horariosPosibles;
                        cmbHorariosDisponibles.Enabled = true;

                        //Quinto filtro: horarios de cuarto filtro con TurnoRepository.existeTurno(Profesional profesional, DateTime fecha)

                    }
                    else
                    {
                        MessageBox.Show("El profesional no trabaja en la especialidad elegida en el día seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                turno.profesional = buscarProfesionalForm.getProfesionalSeleccionado();
                turno.especialidad = buscarProfesionalForm.getEspecialidadSeleccionada();

                UsuarioRepository usuarioRepository = new UsuarioRepository();

                Usuario profesionalSeleccionado = usuarioRepository.traerUsuarioPorId(turno.profesional.id);

                txtProfesional.Text = profesionalSeleccionado.apellido + " " + profesionalSeleccionado.nombre
                    + " - " + turno.especialidad.descripcion;

                AgendaRepository agendaRepository = new AgendaRepository();

                agendaDelProfesional = agendaRepository.traerAgendaDelProfesional(profesionalSeleccionado);

                btnConsultarDisponibilidad.Enabled = true;
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

            //TODO: Mandarlo al turnorepository o a la mierda objetos?
            SqlParameter pAfiliado = new SqlParameter("@afiliado", turno.id);
            SqlParameter pProfesional = new SqlParameter("@profesional", turno.profesional.id);
            SqlParameter pEspecialidad = new SqlParameter("@especialidad", turno.especialidad.id);
            SqlParameter pFechaTurno = new SqlParameter("@fecha_turno", fechaYHorarioDeTurno);

            //TODO: El stored tiene que verificar que el turno no esta ocupado, para evitar concurrencia
            //Inserta el turno en la tabla y devuelve el numero de turno (puede devolver un numero negativo para caso de turno ocupado)
            MessageBox.Show("TURNO GENERADO. NÚMERO DE TURNO: ");
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

        private void obtenerHorariosPosibles(DateTime horarioDesde, DateTime horarioHasta)
        {
            DateTime horarioAcumulador = horarioDesde;
            while (horarioAcumulador.CompareTo(horarioHasta) < 0)
            {
                horarioAcumulador = horarioAcumulador.AddMinutes(30);
                horariosPosibles.Add(horarioAcumulador.ToString("HH:mm"));
            }
        }

        private void mcFechaDeTurno_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblFechaElegida.Text = obtenerFechaSeleccionada().ToString("dd/MM/yyyy");
        }
    }
}
