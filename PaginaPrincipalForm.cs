using ClinicaFrba.AbmRol;
using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Clases;
using ClinicaFrba.Logueo;
using System;
using System.Windows.Forms;
using UsingTostadoPersistentKit.TostadoPersistentKit;

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

        private void tsmCancelaciones_Afiliado_Click(object sender, EventArgs e)
        {
            CancelarTurnoForm cancelacionAfiliado = new CancelarTurnoForm();

            Hide();

            cancelacionAfiliado.ShowDialog();

            Show();
        }

        private void PaginaPrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void crearModificarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //validar si puede modificar los roles
            AbmRolForm abmRol = new AbmRolForm();

            Hide();
            abmRol.ShowDialog();
            Show();
        }
    }
}
