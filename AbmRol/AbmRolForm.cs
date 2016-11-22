using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class AbmRolForm : Form
    {
        private Clases.Otros.AbmRol abmRol = new Clases.Otros.AbmRol();

        public AbmRolForm()
        {
            InitializeComponent();
        }

        private void Volver_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Nuevo_Button_Click(object sender, EventArgs e)
        {
            EditorDeRolesForm editorRoles = new EditorDeRolesForm();

            Hide();
            editorRoles.ShowDialog();
            Close();
        }

        private void Modificar_Button_Click(object sender, EventArgs e)
        {
            if (abmRol.rolSeleccionado==null)//No me gusta que esto este asi pero bueh
            {
                MessageBox.Show("Debe seleccionar un rol");
                return;
            }

            EditorDeRolesForm editorRoles = new EditorDeRolesForm(abmRol.rolSeleccionado);

            Hide();
            editorRoles.ShowDialog();
            Close();
        }

        private void AbmRolForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            tablaRoles.DataSource = abmRol.rolesSistema;
        }

        private void tablaRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceSeleccionado = 0;

            try
            {
                indiceSeleccionado = tablaRoles.CurrentRow.Index;
            }
            catch (Exception)
            {
                indiceSeleccionado = 0;
                //escondemos todo vieja
            }

            abmRol.rolSeleccionado = indiceSeleccionado < abmRol.rolesSistema.Count ? 
                                        abmRol.rolesSistema[indiceSeleccionado] : null;
        }
    }
}
