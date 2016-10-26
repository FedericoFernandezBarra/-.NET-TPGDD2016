using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class RegistrarAgendaForm : Form
    {
        AgendaRepository agendaDao { get; set; }

        ProfesionalRepository profesionalDao { get; set; }

        Agenda agenda { get; set; }

        Usuario usuario { get; set; }

        public RegistrarAgendaForm(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
            profesionalDao = new ProfesionalRepository();
            agendaDao = new AgendaRepository();
            agenda = agendaDao.traerAgendaDelProfesional(usuario);

            cargarTodosLosListBoxs();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarAgendaForm_Load(object sender, EventArgs e)
        {

        }

        private void cargarTodosLosListBoxs()
        {
            foreach (var item in agenda.obtenerNombresDeDiasAgenda())
            {
                listBoxDias.Items.Add(item);
            }

            foreach (var item in horariosPosibles())
            {
                listBoxHoraDesde.Items.Add(item);
            }

            foreach (var item in horariosPosibles())
            {
                listBoxHoraHasta.Items.Add(item);
            }

            foreach (var item in nombresDeEspecialidadesDelProfesional())
            {
                listBoxEspecialidades.Items.Add(item);
            }
        }

        private void botonGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private List<string> nombresDeEspecialidadesDelProfesional()
        {
            return null;
        }

        private List<string> horariosPosibles()
        {
            // lo mas negro que vi, supera a las cosas de Alexis, creo

            List<string> horarios = new List<string>();
            int hora = 7;
            string cadena;

            for (int i = 0; i <26 ; i++)
            {            
                cadena = esPar(i)?  ":00" :":30";

                horarios.Add(hora.ToString() + cadena);

                if (!esPar(i)) hora++;
            }

            return horarios;
        }

        private bool esPar(int i)
        {
            return (i % 2 == 0);
        }
    }
}
