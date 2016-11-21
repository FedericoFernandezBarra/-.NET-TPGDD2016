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
            if (cmbPlanes.SelectedItem!=null)
            {
                modificarAfiliado.afiliado.planMedico = modificarAfiliado.planesMedicosSistema[cmbPlanes.SelectedIndex];

                bool hayCambioDePlan = modificarAfiliado.hayCambioDePlan();
                txtMotivo.Visible = hayCambioDePlan;
                lblMotivo.Visible = hayCambioDePlan;
            }
        }

        private void initForm()
        {
            txtDir.DataBindings.Add("Text", modificarAfiliado.afiliado.usuario, "direccion");
            txtTel.DataBindings.Add("Text", modificarAfiliado.afiliado.usuario, "telefono");
            txtMail.DataBindings.Add("Text", modificarAfiliado.afiliado.usuario, "mail");
            txtMotivo.DataBindings.Add("Text", modificarAfiliado, "motivo");
            //txtCantHijos.DataBindings.Add("Text", modificarAfiliado.afiliado, "cantidadDeHijos");

            //cmbPlanes.DisplayMember = "descripcion";
            //cmbPlanes.DataSource = modificarAfiliado.planesMedicosSistema;
            //cmbPlanes.DataBindings.Add("SelectedItem", modificarAfiliado.afiliado, "planMedico");

            modificarAfiliado.planesMedicosSistema.ForEach(p => cmbPlanes.Items.Add(p.descripcion));

            //cmbEstadoCivil.DisplayMember = "descripcion";
            //cmbEstadoCivil.DataSource = modificarAfiliado.estadosCivilesSistema;
            //cmbEstadoCivil.DataBindings.Add("SelectedItem", modificarAfiliado.afiliado, "estadoCivil");

            modificarAfiliado.estadosCivilesSistema.ForEach(e => cmbEstadoCivil.Items.Add(e.descripcion));

            //Por las dudas vieja
            for (int i = 0; i < cmbPlanes.Items.Count; i++)
            {
                if (modificarAfiliado.planesMedicosSistema[i].id == modificarAfiliado.afiliado.planMedico.id)
                {
                    cmbPlanes.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cmbEstadoCivil.Items.Count; i++)
            {
                if (modificarAfiliado.estadosCivilesSistema[i].id == modificarAfiliado.afiliado.estadoCivil.id)
                {
                    cmbEstadoCivil.SelectedIndex = i;
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
                modificarAfiliado.afiliado.estadoCivil = modificarAfiliado.estadosCivilesSistema[cmbEstadoCivil.SelectedIndex];

                btnConyuge.Enabled = modificarAfiliado.afiliadoTieneConyuge();
            }
        }
    }
}
