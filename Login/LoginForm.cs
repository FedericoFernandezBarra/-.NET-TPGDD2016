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
using ClinicaFrba.Clases;

namespace ClinicaFrba.Logueo
{
    public partial class LoginForm : Form
    {
        private Login login = new Login();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.DataBindings.Add("Text", login, "username");
            txtPassword.DataBindings.Add("Text", login, "password");
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (!login.cumpleValidaciones())
            {
                MessageBox.Show(login.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!login.logueoExitoso())
            {
                MessageBox.Show(login.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Logueo exitoso");

            Close();
        }

        internal Usuario getUsuarioLogueado()
        {
            return login.usuarioLogueado;
        }
    }
}
