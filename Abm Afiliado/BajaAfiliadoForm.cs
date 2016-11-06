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
    public partial class BajaAfiliadoForm : Form
    {
        private BajaAfiliado bajaAfiliado = new BajaAfiliado();

        public BajaAfiliadoForm(Afiliado afiliado)
        {
            bajaAfiliado.afiliado = afiliado;

            InitializeComponent();
        }

        private void BajaAfiliadoForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            txtNombre.DataBindings.Add("Text", bajaAfiliado.afiliado.usuario, "nombre");
            txtNroAfliado.DataBindings.Add("Text", bajaAfiliado.afiliado, "numeroDeAfiliado");
            txtApellido.DataBindings.Add("Text", bajaAfiliado.afiliado.usuario, "apellido");
        }

        private void cmdBaja_Click(object sender, EventArgs e)
        {
            if (!bajaAfiliado.darDeBajaExitosa())
            {
                MessageBox.Show(bajaAfiliado.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Baja ejecutada exitosamente");

            Close();
        }

        private void cmbVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
