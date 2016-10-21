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

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarTurnoForm : Form
    {
        private CancelarTurno cancelarTurno = new CancelarTurno();

        public CancelarTurnoForm()
        {
            cancelarTurno.inicializarListas();
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!cancelarTurno.cancelacionExitosa())
            {
                MessageBox.Show(cancelarTurno.mensajeDeError);
                return;
            }

            MessageBox.Show("Cancelacion ejecutada con exito");

            Close();
        }

        private void CancelarTurnoForm_Load(object sender, EventArgs e)
        {
            inicializarForm();

            bindearForm();
        }

        private void bindearForm()
        {
            cmbCancelacion.DataBindings.Add("SelectedItem", cancelarTurno, "tipoDeCancelacion");
            txtMotivo.DataBindings.Add("Text", cancelarTurno, "motivoDeCancelacion");

            grillaTurnos.DataSource = cancelarTurno.turnosDeAfiliado;
            //Tengo que bindear que turno quiere cancelar del datagrid
        }

        private void inicializarForm()
        {
            foreach (var item in cancelarTurno.tiposDeCancelacion)
            {
                cmbCancelacion.Items.Add(item);
            }

        }

        private void grillaTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceSeleccionado = 0;

            try
            {
                indiceSeleccionado = grillaTurnos.CurrentRow.Index;
            }
            catch (Exception)
            {
                indiceSeleccionado = 0;
                //escondemos todo vieja
            }

            cancelarTurno.turnoACancelar = indiceSeleccionado < cancelarTurno.turnosDeAfiliado.Count ?
                                        cancelarTurno.turnosDeAfiliado[indiceSeleccionado] : null;
        }
    }
}
