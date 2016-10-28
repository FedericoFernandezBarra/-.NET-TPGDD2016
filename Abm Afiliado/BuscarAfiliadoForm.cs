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

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class BuscarAfiliadoForm : Form
    {
        BuscarAfiliado buscarAfiliado = new BuscarAfiliado();
        private bool busquedaOK = false;

        public BuscarAfiliadoForm()
        {
            InitializeComponent();
        }

        private void BuscarAfiliadoForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            txtNombre.DataBindings.Add("Text", buscarAfiliado, "nombre");
            txtApellido.DataBindings.Add("Text", buscarAfiliado, "apellido");
            txtDni.DataBindings.Add("Text", buscarAfiliado, "dni");
            txtNumAfiliado.DataBindings.Add("Text", buscarAfiliado, "nroAfiliado");

            grillaPacientes.DataSource = buscarAfiliado.afiliados;

            cmbPlanes.DisplayMember = "descripcion";
            cmbPlanes.DataSource = buscarAfiliado.planesMedicosSistema;
            cmbPlanes.DataBindings.Add("SelectedItem", buscarAfiliado, "planMedico");
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (!buscarAfiliado.busquedaExitosa())
            {
                MessageBox.Show(buscarAfiliado.mensajeDeError);
            }
        }

        internal Afiliado getAfiliadoSeleccionado()
        {
            return buscarAfiliado.afiliado;
        }

        public bool seSeleccionoUnAfiliado()
        {
            return busquedaOK;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            bindearAfiliado();

            if (buscarAfiliado.afiliado != null)
            {
                busquedaOK = true;
            }

            Close();
        }

        private void bindearAfiliado()
        {
            int indiceSeleccionado = 0;

            try
            {
                indiceSeleccionado = grillaPacientes.CurrentRow.Index;
            }
            catch (Exception)
            {
                indiceSeleccionado = 0;
                //escondemos todo vieja
            }

            buscarAfiliado.afiliado = indiceSeleccionado < buscarAfiliado.afiliados.Count ?
                                        buscarAfiliado.afiliados[indiceSeleccionado] : null;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNumAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
