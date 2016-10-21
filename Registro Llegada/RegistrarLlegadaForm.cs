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
            BuscarProfesionalForm buscarProfesional = new BuscarProfesionalForm();

            Hide();

            buscarProfesional.ShowDialog();

            Show();

            registrarLlegada.profesional = buscarProfesional.getProfesionalSeleccionado();
            registrarLlegada.especialidad = buscarProfesional.getEspecialidadSeleccionada();
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

            registrarLlegada.cargarTurnosFiltrados();//Inicializo turnos filtrados

            grillaTurnos.DataSource = registrarLlegada.turnosFiltrados;
        }

        private void txtNroAfiliado_TextChanged(object sender, EventArgs e)
        {
            registrarLlegada.cargarTurnosFiltrados();
        }

        private void cmdConfirmarBono_Click(object sender, EventArgs e)
        {
            if (!registrarLlegada.ejecutarExitosamente())
            {
                MessageBox.Show(registrarLlegada.mensajeDeError);
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
        }
    }
}
