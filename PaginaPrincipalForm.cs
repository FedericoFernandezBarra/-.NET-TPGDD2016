using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Clases;
using ClinicaFrba.Logueo;
using System;
using System.Windows.Forms;

namespace ClinicaFrba
{
    public partial class PaginaPrincipalForm : Form
    {
        public PaginaPrincipalForm()
        {
            InitializeComponent();
        }

        private void tsmSesion_IniciarSesion_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();

            Hide();

            login.ShowDialog();

            Show();
        }

        private void tsmCancelaciones_Profesional_Click(object sender, EventArgs e)
        {
            CancelarDiasForm cancelacionProfesional = new CancelarDiasForm();

            Hide();

            cancelacionProfesional.ShowDialog();

            Show();
        }
    }
}
