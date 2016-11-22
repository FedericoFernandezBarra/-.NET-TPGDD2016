using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Clases.POJOS;

namespace ClinicaFrba.Compra_Bono
{
    public partial class ImprimirBonosForm : Form
    {
        private List<Bono> bonosComprados;

        public ImprimirBonosForm(List<Bono> bonosComprados)
        {
            this.bonosComprados = bonosComprados;
            InitializeComponent();
        }

        private void ImprimirBonosForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            tbNroAfiliado.Text = bonosComprados[0].compra.comprador.numeroDeAfiliado.ToString();
            tbNombreCompleto.Text = bonosComprados[0].compra.comprador.usuario.nombreCompleto;

            foreach (Bono bono in bonosComprados)
            {
                lstBonosConsulta.Items.Add("Bono N°:  " + bono.id.ToString() + " - Plan: " + bono.compra.comprador.planMedico.descripcion);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
