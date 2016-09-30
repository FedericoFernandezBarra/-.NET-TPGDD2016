using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsingTostadoPersistentKit.TostadoPersistentKit;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AltaAfiliadoForm : Form
    {
        private AltaAfiliado altaAfiliado = new AltaAfiliado();

        public AltaAfiliadoForm()
        {
            InitializeComponent();
        }

        private void AltaAfiliadoForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            txtNombre.DataBindings.Add("Text", altaAfiliado.nuevoAfiliado.usuario, "nombre");
            txtApellido.DataBindings.Add("Text", altaAfiliado.nuevoAfiliado.usuario, "apellido");
            dtpFechaNacimiento.DataBindings.Add("Value", altaAfiliado.nuevoAfiliado.usuario, "fechaDeNacimiento");
            txtDni.DataBindings.Add("Text", altaAfiliado.nuevoAfiliado.usuario, "documento");
            txtDir.DataBindings.Add("Text", altaAfiliado.nuevoAfiliado.usuario, "direccion");
            txtTel.DataBindings.Add("Text", altaAfiliado.nuevoAfiliado.usuario, "telefono");
            txtMail.DataBindings.Add("Text", altaAfiliado.nuevoAfiliado.usuario, "mail");
            txtHijos.DataBindings.Add("Text", altaAfiliado.nuevoAfiliado, "cantidadDeHijos");

            cmbEstadoCivil.DisplayMember = "descripcion";
            cmbEstadoCivil.DataSource = altaAfiliado.estadosCivilesSistema;
            cmbEstadoCivil.DataBindings.Add("SelectedItem", altaAfiliado.nuevoAfiliado, "estadoCivil");

            cmbSexo.DataSource = altaAfiliado.sexosSistema;
            cmbEstadoCivil.DataBindings.Add("SelectedItem", altaAfiliado.nuevoAfiliado.usuario, "sexo");

            cmbEstadoCivil.DisplayMember = "descripcion";
            cmbEstadoCivil.DataSource = altaAfiliado.tiposDeDocumentoSistema;
            cmbEstadoCivil.DataBindings.Add("SelectedItem", altaAfiliado.nuevoAfiliado.usuario, "tipoDeDocumento");

            cmbEstadoCivil.DisplayMember = "descripcion";
            cmbEstadoCivil.DataSource = altaAfiliado.planesMedicosSistema;
            cmbEstadoCivil.DataBindings.Add("SelectedItem", altaAfiliado.nuevoAfiliado, "planMedico");
        }

        private void cmbVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (!altaAfiliado.ejecutarGuardadoExitoso())
            {
                MessageBox.Show(altaAfiliado.mensajeDeError);
                return;
            }
        }
    }
}
