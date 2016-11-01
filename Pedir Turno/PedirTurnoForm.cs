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
        Agenda agendaDelProfesional;

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
                        List<String> horariosPosibles = new List<String>();
                        diaSeleccionado.ForEach(unHorario => obtenerHorariosPosibles(horariosPosibles, unHorario.horaInicial, unHorario.horaFinal));
                        
                        //Quinto filtro: eliminar horarios que ya poseen turno asignado
                        filtrarHorariosYaTomados(horariosPosibles);
                        cmbHorariosDisponibles.DataSource = horariosPosibles;
                        cmbHorariosDisponibles.Enabled = true;
                        btnConfirmarTurno.Enabled = true;
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
                AgendaRepository agendaRepository = new AgendaRepository();
                Usuario profesionalSeleccionado = buscarProfesionalForm.getProfesionalSeleccionado().usuario;

                agendaDelProfesional = agendaRepository.traerAgendaDelProfesional(profesionalSeleccionado);
                if (agendaDelProfesional == null)
                {
                    MessageBox.Show("ERROR: El profesional seleccionado no dispone de una agenda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    turno.profesional = buscarProfesionalForm.getProfesionalSeleccionado();
                    turno.especialidad = buscarProfesionalForm.getEspecialidadSeleccionada();

                    txtProfesional.Text = profesionalSeleccionado.nombreCompleto
                        + " - " + turno.especialidad.descripcion;

                    btnConsultarDisponibilidad.Enabled = true;
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

            MessageBox.Show(turnoRepository.reservarTurno(turno));
            Close();
        }

        private void ConsultarTurnosForm_Load(object sender, EventArgs e)
        {
            txtAfiliado.Text = turno.afiliado.usuario.nombreCompleto;

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

        private void obtenerHorariosPosibles(List<String> horariosPosibles, TimeSpan horarioDesde, TimeSpan horarioHasta)
        {
            TimeSpan horarioAcumulador = horarioDesde;
            while (horarioAcumulador.Add(TimeSpan.FromMinutes(30)).CompareTo(horarioHasta) < 0)
            {
                horarioAcumulador = horarioAcumulador.Add(TimeSpan.FromMinutes(30));
                horariosPosibles.Add(horarioAcumulador.ToString(@"hh\:mm"));
            }
        }

        private void filtrarHorariosYaTomados(List<String> horariosPosibles)
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
