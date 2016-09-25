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

        private EditorDeRolesForm(Rol rol,EditorDeRolAction accionEditor)
        {
            editorDeRoles.rol = rol;
            editorDeRoles.accion = accionEditor;
            InitializeComponent();
        }

        public EditorDeRolesForm(Rol rol)
        {
            new EditorDeRolesForm(rol, new ModificarRolAction());
        }

        public EditorDeRolesForm()
        {
            new EditorDeRolesForm(new Rol(), new CrearRolAction());
        }

        private void EditorDeRolesForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            editorDeRoles.funcionalidadesSistema.ForEach(funcionalidad => cbxFuncionalidades.Items.Add(funcionalidad));

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
                MessageBox.Show(editorDeRoles.mensajeDeError);
                return;
            }

            Close();
        }

        private void cargarFuncionalidadesARol()
        {
            editorDeRoles.rol.funcionalidades.Clear();

            foreach (var item in cbxFuncionalidades.Items)
            {
                if (cbxFuncionalidades.SelectedItems.Contains(item))
                {
                    editorDeRoles.rol.funcionalidades.Add((Funcionalidad)item);
                }
            }
        }
    }
}
