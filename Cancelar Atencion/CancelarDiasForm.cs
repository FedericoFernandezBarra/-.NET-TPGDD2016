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
using TostadoPersistentKit;
using ClinicaFrba.Clases.POJOS;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarDiasForm : Form
    {
        CancelarDias cancelarDias = new CancelarDias();

        public CancelarDiasForm(Profesional profesional)
        {
            cancelarDias.profesional = profesional;
            InitializeComponent();
        }

        private void CancelarDiasForm_Load(object sender, EventArgs e)
        {
            inicializarForm();

            bindearForm();
        }

        private void bindearForm()
        {
            fechaInicioCancelacion.DataBindings.Add("Value", cancelarDias, "fechaInicioCancelacion");
            fechaFinCancelacion.DataBindings.Add("Value", cancelarDias, "fechaFinCancelacion");
            txtMotivo.DataBindings.Add("Text", cancelarDias, "motivoDeCancelacion");

            cmbCancelacion.DisplayMember = "descripcion";
            cmbCancelacion.DataSource = cancelarDias.tiposDeCancelacion;
            cmbCancelacion.DataBindings.Add("SelectedItem", cancelarDias, "tipoDeCancelacion");

            lblProfesional.Text += " "+cancelarDias.profesional.usuario.nombre + " " + cancelarDias.profesional.usuario.apellido;
        }

        private void inicializarForm()
        {
            /*foreach (var item in cancelarDias.tiposDeCancelacion)
            {
                cmbCancelacion.Items.Add(item);
            }*/

            //fechaInicioCancelacion.Value = DataBase.Instance.getDate();
            //fechaFinCancelacion.Value = DataBase.Instance.getDate();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!cancelarDias.cancelacionExitosa())
            {
                MessageBox.Show(cancelarDias.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cancelacion ejecutada con exito");

            Close();
        }
    }
}
