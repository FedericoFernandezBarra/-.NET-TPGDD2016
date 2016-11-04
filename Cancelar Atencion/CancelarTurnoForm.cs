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

        public CancelarTurnoForm(Afiliado afiliado)
        {
            cancelarTurno.afiliado = afiliado;
            cancelarTurno.inicializarListas();
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!cancelarTurno.cancelacionExitosa())
            {
                MessageBox.Show(cancelarTurno.mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            cargarDataGrid();

            //grillaTurnos.DataSource = cancelarTurno.turnosDeAfiliado;
            //Tengo que bindear que turno quiere cancelar del datagrid
        }

        private void cargarDataGrid()
        {
            grillaTurnos.Rows.Clear();

            cancelarTurno.turnosDeAfiliado.ForEach(t => grillaTurnos.Rows.Add(t.profesional.usuario.nombre + " " + t.profesional.usuario.apellido, t.especialidad.descripcion, t.fechaDeTurno));
        }

        private void inicializarForm()
        {
            foreach (var item in cancelarTurno.tiposDeCancelacion)
            {
                cmbCancelacion.Items.Add(item);
            }

            DataGridViewTextBoxColumn cProfesional = new DataGridViewTextBoxColumn();
            cProfesional.HeaderText = "Profesional";
            cProfesional.ReadOnly = true;
            grillaTurnos.Columns.Add(cProfesional);

            DataGridViewTextBoxColumn cEspecialidad = new DataGridViewTextBoxColumn();
            cEspecialidad.HeaderText = "Especialidad";
            cEspecialidad.ReadOnly = true;
            grillaTurnos.Columns.Add(cEspecialidad);

            DataGridViewTextBoxColumn cFecha = new DataGridViewTextBoxColumn();
            cFecha.HeaderText = "Fecha";
            cFecha.ReadOnly = true;
            grillaTurnos.Columns.Add(cFecha);
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
