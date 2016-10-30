using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Clases.Otros;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class ConsultarHistorialCambiosForm : Form
    {
        private ConsultarHistorialCambios consultarHistorial = new ConsultarHistorialCambios();

        public ConsultarHistorialCambiosForm(Afiliado afiliado)
        {
            consultarHistorial.afiliado = afiliado;
            InitializeComponent();
        }

        private void ConsultarHistorialCambiosForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            label1.Text += consultarHistorial.afiliado.usuario.nombre + " " + consultarHistorial.afiliado.usuario.apellido;

            initDataGrid();

            consultarHistorial.buscarHistorialDeCambios();

            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            grillaCambiosDePlan.Rows.Clear();

            consultarHistorial.historiales.ForEach(h => grillaCambiosDePlan.Rows.Add(h.plan.descripcion,h.motivo,h.fecha));
        }

        private void initDataGrid()
        {
            DataGridViewTextBoxColumn cPlan = new DataGridViewTextBoxColumn();
            cPlan.HeaderText = "Plan Medico";
            cPlan.ReadOnly = true;
            grillaCambiosDePlan.Columns.Add(cPlan);

            DataGridViewTextBoxColumn cMotivo = new DataGridViewTextBoxColumn();
            cMotivo.HeaderText = "Motivo";
            cMotivo.ReadOnly = true;
            grillaCambiosDePlan.Columns.Add(cMotivo);

            DataGridViewTextBoxColumn cFecha = new DataGridViewTextBoxColumn();
            cFecha.HeaderText = "Fecha";
            cFecha.ReadOnly = true;
            grillaCambiosDePlan.Columns.Add(cFecha);
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
