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
                MessageBox.Show(buscarProfesional.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            grillaProfesionales.Rows.Clear();

            buscarProfesional.profesionales.ForEach(p=> grillaProfesionales.Rows.Add(p.matricula, p.usuario.nombre, p.usuario.apellido));

            grillaProfesionales.Enabled = buscarProfesional.profesionales.Count > 0;
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

            //grillaProfesionales.DataSource = buscarProfesional.profesionales;

            cmbEspecialidades.DisplayMember = "descripcion";
            cmbEspecialidades.DataSource = buscarProfesional.especialidadesSistema;
            cmbEspecialidades.DataBindings.Add("SelectedItem", buscarProfesional, "especialidad");

            initDataGrid();
        }

        private void initDataGrid()
        {
            DataGridViewTextBoxColumn cMatricula = new DataGridViewTextBoxColumn();
            cMatricula.HeaderText = "Matricula";
            cMatricula.ReadOnly = true;
            grillaProfesionales.Columns.Add(cMatricula);

            DataGridViewTextBoxColumn cNombre = new DataGridViewTextBoxColumn();
            cNombre.HeaderText = "Nombre";
            cNombre.ReadOnly = true;
            grillaProfesionales.Columns.Add(cNombre);

            DataGridViewTextBoxColumn cApellido = new DataGridViewTextBoxColumn();
            cApellido.HeaderText = "Apellido";
            cApellido.ReadOnly = true;
            grillaProfesionales.Columns.Add(cApellido);

            /*DataGridViewTextBoxColumn cEspecialidad = new DataGridViewTextBoxColumn();
            cEspecialidad.HeaderText = "Especialidad";
            cEspecialidad.ReadOnly = true;
            grillaProfesionales.Columns.Add(cEspecialidad);*/
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtNumMatricula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

            if (cmbEspecialidades.Items.Count>0)
            {
                cmbEspecialidades.SelectedIndex = 0;
            }

            buscarProfesional.profesionales.Clear();

            grillaProfesionales.Rows.Clear();

            grillaProfesionales.Enabled = false;
        }
    }
}
