﻿using ClinicaFrba.Clases.Otros;
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
            modificarAfiliado.cargarPlanMedicoActual();

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

            cmbPlanes.DisplayMember = "descripcion";
            cmbPlanes.DataSource = modificarAfiliado.planesMedicosSistema;
            cmbPlanes.DataBindings.Add("SelectedItem", modificarAfiliado.afiliado, "planMedico");

            //Por las dudas vieja
            foreach (PlanMedico item in cmbPlanes.Items)
            {
                if (item.id==modificarAfiliado.afiliado.planMedico.id)
                {
                    cmbPlanes.SelectedItem = item;
                }
            }
            
        }

        private void txtHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
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
    }
}
