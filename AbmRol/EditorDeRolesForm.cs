using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class EditorDeRolesForm : Form
    {
        private EditorDeRol editorDeRoles = new EditorDeRol();

        public EditorDeRolesForm(Rol rol)
        {
            editorDeRoles.rol = rol;
            editorDeRoles.accion = new ModificarRolAction();
            InitializeComponent();
        }

        public EditorDeRolesForm()
        {
            editorDeRoles.rol = new Rol();
            editorDeRoles.accion = new CrearRolAction();
            InitializeComponent();
        }

        private void EditorDeRolesForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            foreach (Funcionalidad item in editorDeRoles.funcionalidadesSistema)
            {
                bool isChecked = editorDeRoles.rol.funcionalidades.Exists(f => f.nombre == item.nombre);
                cbxFuncionalidades.Items.Add(item, isChecked);
            }

            cbxFuncionalidades.DisplayMember = "nombre";
            //cmbEstadoCivil.DataSource = altaAfiliado.estadosCivilesSistema;

            txtNombre.DataBindings.Add("Text", editorDeRoles.rol, "nombre");
            cbxHabilitado.DataBindings.Add("Checked", editorDeRoles.rol, "habilitado");
        }

        private void Cancelar_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Guardar_Button_Click(object sender, EventArgs e)
        {
            cargarFuncionalidadesARol();

            if (!editorDeRoles.ejecutarAccion())
            {
                MessageBox.Show(editorDeRoles.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("La operacion se ha realizado con exito");

            Close();
        }

        private void cargarFuncionalidadesARol()
        {
            editorDeRoles.rol.funcionalidades.Clear();

            foreach (Funcionalidad item in cbxFuncionalidades.CheckedItems)
            {
                editorDeRoles.rol.funcionalidades.Add(item);
            }
        }
    }
}
