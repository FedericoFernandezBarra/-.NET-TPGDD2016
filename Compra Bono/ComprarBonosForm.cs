using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Windows.Forms;

namespace ClinicaFrba.Compra_Bono
{
    public partial class ComprarBonosForm : Form
    {
        private ComprarBonos comprarBonos = new ComprarBonos();

        public ComprarBonosForm(Afiliado afiliado)
        {
            comprarBonos.compra.comprador = afiliado;
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (!comprarBonos.compraExitosa())
            {
                MessageBox.Show(comprarBonos.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void ComprarBonosForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            textBox1.DataBindings.Add("Text", comprarBonos.compra, "cantidad");

            if (comprarBonos.compra.comprador!=null)
            {
                textBox1.Enabled = true;
                btnComprar.Enabled = true;
                tbAfiliado.Text = comprarBonos.compra.comprador.numeroDeAfiliado.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comprarBonos.cargarMonto();
            tbPrecioTotal.Text = comprarBonos.compra.monto.ToString();
        }
    }
}
