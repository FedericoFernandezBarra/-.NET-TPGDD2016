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
            BuscarProfesionalForm buscarProfesional = new BuscarProfesionalForm(registrarLlegada.profesional);

            Hide();

            buscarProfesional.ShowDialog();

            Show();
        }

        private void txtNroAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
