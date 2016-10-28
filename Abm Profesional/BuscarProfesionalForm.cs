using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Profesional
{
    public partial class BuscarProfesionalForm : Form
    {
        BuscarProfesional buscarProfesional = new BuscarProfesional();

        private bool busquedaOK = false;

        public BuscarProfesionalForm()
        {
            InitializeComponent();
        }

        public BuscarProfesionalForm(bool filtroEspecialidadObligatorio)
        {
            buscarProfesional.filtroEspecialidadObligatorio = filtroEspecialidadObligatorio;
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (!buscarProfesional.busquedaExitosa())
            {
                MessageBox.Show(buscarProfesional.mensajeDeError);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal Profesional getProfesionalSeleccionado()
        {
            return buscarProfesional.profesional;
        }

        public Especialidad getEspecialidadSeleccionada()
        {
            return buscarProfesional.especialidad;
        }

        public bool seSeleccionoUnProfesional()
        {
            return busquedaOK;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            bindearProfesional();

            if (buscarProfesional.profesional != null)
            {
                busquedaOK = true;
            }

            Close();
        }

        private void bindearProfesional()
        {
            int indiceSeleccionado = 0;

            try
            {
                indiceSeleccionado = grillaProfesionales.CurrentRow.Index;
            }
            catch (Exception)
            {
                indiceSeleccionado = 0;
                //escondemos todo vieja
            }

            buscarProfesional.profesional = indiceSeleccionado < buscarProfesional.profesionales.Count ?
                                        buscarProfesional.profesionales[indiceSeleccionado] : null;
        }

        private void BuscarProfesionalForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            txtNombre.DataBindings.Add("Text", buscarProfesional, "nombre");
            txtApellido.DataBindings.Add("Text", buscarProfesional, "apellido");
            txtNumMatricula.DataBindings.Add("Text", buscarProfesional, "nroMatricula");

            grillaProfesionales.DataSource = buscarProfesional.profesionales;

            cmbEspecialidades.DisplayMember = "descripcion";
            cmbEspecialidades.DataSource = buscarProfesional.especialidadesSistema;
            cmbEspecialidades.DataBindings.Add("SelectedItem", buscarProfesional, "especialidad");
        }
    }
}
