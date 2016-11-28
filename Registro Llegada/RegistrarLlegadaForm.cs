using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.Clases.Otros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class RegistrarLlegadaForm : Form
    {
        private RegistrarLlegada registrarLlegada = new RegistrarLlegada();

        public RegistrarLlegadaForm()
        {
            InitializeComponent();
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            BuscarProfesionalForm buscarProfesional = new BuscarProfesionalForm(true);

            Hide();

            buscarProfesional.ShowDialog();

            Show();

            registrarLlegada.profesional = buscarProfesional.getProfesionalSeleccionado();
            registrarLlegada.especialidad = buscarProfesional.getEspecialidadSeleccionada();

            registrarLlegada.cargarTurnosDeProfesional();
            registrarLlegada.cargarTurnosFiltrados();
            cargarDataGrid();
        }

        private void txtNroAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void RegistrarLlegadaForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            txtNroAfiliado.DataBindings.Add("Text", registrarLlegada, "numeroAfiliado");
            txtBono.DataBindings.Add("Text", registrarLlegada, "numeroBono");

            dtpHoraLlegada.Value = registrarLlegada.fechaLlegada;

            dtpHoraLlegada.MaxDate = registrarLlegada.fechaLlegada;

            //initDataGrid();

            //registrarLlegada.cargarTurnosFiltrados();//Inicializo turnos filtrados

            //cargarDataGrid();

            //grillaTurnos.DataSource = registrarLlegada.turnosFiltrados;
        }

        private void initDataGrid()
        {
            DataGridViewTextBoxColumn cNroAfiliado = new DataGridViewTextBoxColumn();
            cNroAfiliado.HeaderText = "Nro de Afiliado";
            cNroAfiliado.ReadOnly = true;
            grillaTurnos.Columns.Add(cNroAfiliado);

            DataGridViewTextBoxColumn cAfiliado = new DataGridViewTextBoxColumn();
            cAfiliado.HeaderText = "Afiliado";
            cAfiliado.ReadOnly = true;
            grillaTurnos.Columns.Add(cAfiliado);

            DataGridViewTextBoxColumn cProfesional = new DataGridViewTextBoxColumn();
            cProfesional.HeaderText = "Profesional";
            cProfesional.ReadOnly = true;
            grillaTurnos.Columns.Add(cProfesional);

            DataGridViewTextBoxColumn cEspecialidad = new DataGridViewTextBoxColumn();
            cEspecialidad.HeaderText = "Especialidad";
            cEspecialidad.ReadOnly = true;
            grillaTurnos.Columns.Add(cEspecialidad);

            DataGridViewTextBoxColumn cFecha = new DataGridViewTextBoxColumn();
            cFecha.HeaderText = "Fecha";
            cFecha.ReadOnly = true;
            grillaTurnos.Columns.Add(cFecha);
        }

        private void txtNroAfiliado_TextChanged(object sender, EventArgs e)
        {
            registrarLlegada.numeroAfiliado = txtNroAfiliado.Text;

            registrarLlegada.cargarTurnosFiltrados();

            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            grillaTurnos.Rows.Clear();

            registrarLlegada.turnosFiltrados.ForEach(t => grillaTurnos.Rows.Add(t.afiliado.numeroDeAfiliado, 
                                                    t.afiliado.usuario.nombre + " " + t.afiliado.usuario.apellido, 
                                                    t.profesional.usuario.nombre + " " + t.profesional.usuario.apellido,
                                                    t.especialidad.descripcion, t.fechaDeTurno));
        }

        private void cmdConfirmarBono_Click(object sender, EventArgs e)
        {
            if (!registrarLlegada.ejecutarExitosamente())
            {
                MessageBox.Show(registrarLlegada.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Llegada registrada exitosamente");

            Close();
        }

        private void grillaTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceSeleccionado = 0;

            try
            {
                indiceSeleccionado = grillaTurnos.CurrentRow.Index;
            }
            catch (Exception)
            {
                indiceSeleccionado = 0;
                //escondemos todo vieja
            }

            registrarLlegada.turnoDeAfiliado = indiceSeleccionado < registrarLlegada.turnosFiltrados.Count ?
                                        registrarLlegada.turnosFiltrados[indiceSeleccionado] : null;

            txtBono.Enabled = registrarLlegada.turnoDeAfiliado != null;
        }

        private void txtBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtBono_TextChanged(object sender, EventArgs e)
        {
            cmdConfirmarBono.Enabled = txtBono.Text != "" && txtBono.Text != "0";
        }

        private void dtpHoraLlegada_ValueChanged(object sender, EventArgs e)
        {
            registrarLlegada.fechaLlegada = dtpHoraLlegada.Value;
        }
    }
}
