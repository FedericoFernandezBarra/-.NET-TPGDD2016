using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class ModificarAfiliadoForm : Form
    {
        private ModificarAfiliado modificarAfiliado = new ModificarAfiliado();

        public ModificarAfiliadoForm(Afiliado afiliado)
        {
            modificarAfiliado.afiliado = afiliado;
            modificarAfiliado.cargarDatosActuales();

            InitializeComponent();
        }

        private void ModificarAfiliadoForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hayCambioDePlan= ((PlanMedico)cmbPlanes.SelectedItem).id != modificarAfiliado.planMedicoActual.id;
            txtMotivo.Visible = hayCambioDePlan;
            lblMotivo.Visible = hayCambioDePlan;
        }

        private void initForm()
        {
            txtDir.DataBindings.Add("Text", modificarAfiliado.afiliado.usuario, "direccion");
            txtTel.DataBindings.Add("Text", modificarAfiliado.afiliado.usuario, "telefono");
            txtMail.DataBindings.Add("Text", modificarAfiliado.afiliado.usuario, "mail");
            txtMotivo.DataBindings.Add("Text", modificarAfiliado, "motivo");
            txtCantHijos.DataBindings.Add("Text", modificarAfiliado.afiliado, "cantidadDeHijos");

            cmbPlanes.DisplayMember = "descripcion";
            cmbPlanes.DataSource = modificarAfiliado.planesMedicosSistema;
            cmbPlanes.DataBindings.Add("SelectedItem", modificarAfiliado.afiliado, "planMedico");

            cmbEstadoCivil.DisplayMember = "descripcion";
            cmbEstadoCivil.DataSource = modificarAfiliado.estadosCivilesSistema;
            cmbEstadoCivil.DataBindings.Add("SelectedItem", modificarAfiliado.afiliado, "estadoCivil");

            //Por las dudas vieja
            foreach (PlanMedico item in cmbPlanes.Items)
            {
                if (item.id==modificarAfiliado.afiliado.planMedico.id)
                {
                    cmbPlanes.SelectedItem = item;
                }
            }

            foreach (EstadoCivil item in cmbEstadoCivil.Items)
            {
                if (item.id == modificarAfiliado.afiliado.estadoCivil.id)
                {
                    cmbEstadoCivil.SelectedItem = item;
                }
            }

        }

        private void cmbVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (!modificarAfiliado.ejecutarModificacionesExitosamente())
            {
                MessageBox.Show(modificarAfiliado.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Afiliado modificado exitosamente");

            Close();
        }

        private void btnConyuge_Click(object sender, EventArgs e)
        {
            modificarAfiliado.crearConyuge();

            AltaAfiliadoForm altaConyuge = new AltaAfiliadoForm(modificarAfiliado.afiliado.conyuge);
            altaConyuge.altaConyuge = true;

            Hide();

            altaConyuge.ShowDialog();

            if (!altaConyuge.altaExitosa)
            {
                modificarAfiliado.afiliado.conyuge = null;
            }

            Show();
        }

        private void btnHijo_Click(object sender, EventArgs e)
        {
            Afiliado hijo = modificarAfiliado.crearHijo();

            AltaAfiliadoForm altaHijo = new AltaAfiliadoForm(hijo);
            altaHijo.altaHijo = true;

            Hide();

            altaHijo.ShowDialog();

            if (altaHijo.altaExitosa)
            {
                modificarAfiliado.afiliado.hijos.Add(hijo);
            }

            Show();
        }

        private void cmbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoCivil.SelectedItem != null)
            {
                modificarAfiliado.afiliado.estadoCivil = (EstadoCivil)cmbEstadoCivil.SelectedItem;

                btnConyuge.Enabled = modificarAfiliado.afiliadoTieneConyuge();
            }
        }
    }
}
