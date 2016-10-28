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
using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;

namespace ClinicaFrba.Logueo
{
    public partial class SeleccionDeRolForm : Form
    {
        private SeleccionDeRol seleccionDeRol = new SeleccionDeRol();

        public SeleccionDeRolForm(Usuario usuario)
        {
            seleccionDeRol.usuario = usuario;
            seleccionDeRol.cargarRolesDeUsuario();
            InitializeComponent();
        }

        private void SeleccionDeRolForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            comboBox_Roles.DisplayMember = "nombre";
            comboBox_Roles.DataSource = seleccionDeRol.usuario.roles;
            comboBox_Roles.DataBindings.Add("SelectedItem", seleccionDeRol, "rolSeleccionado");
        }

        internal Rol getRolSeleccionado()
        {
            return seleccionDeRol.rolSeleccionado;
        }

        private void continuar_Boton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
