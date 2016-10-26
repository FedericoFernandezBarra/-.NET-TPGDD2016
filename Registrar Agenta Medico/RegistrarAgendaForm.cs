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
        Agenda agenda { get; set; }

        Usuario usuario { get; set; }

        AgendaRepository agendaDAO { get; set; }

        EspecialidadRepository especialidadDAO { get; set; }


        public RegistrarAgendaForm(Usuario usua)
        {
            InitializeComponent();

            //objetos
            usuario = new Usuario(); usuario.id = 5579;//usua;
            agendaDAO = new AgendaRepository();
            agenda = agendaDAO.traerAgendaDelProfesional(usuario);

            //carga de listbox
            listBoxDias.Items.AddRange(new object[] { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO" });
            listBoxDias.SelectedIndex = 0;

            foreach (KeyValuePair<long, string> item in agendaDAO.traerEspecialidadesDeProfesional(usuario))
            {
                listBoxEspecialidades.Items.Add(item.Value);
            }
            listBoxEspecialidades.SelectedIndex = 0;
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

        private void botonGuardarCambios_Click(object sender, EventArgs e)
        {

        }
    }
}
