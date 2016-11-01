using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
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

namespace ClinicaFrba.Registro_Resultado
{
    public partial class RegistrarResultadoAtencionForm : Form
    {
        Profesional profesional; //asumo que la funcionalidad sólo está disponible para el profesional, no el admin.
        ResultadoAtencionMedica resultadoAtencionMedica;

        public RegistrarResultadoAtencionForm(Usuario usuarioProfesional)
        {
            InitializeComponent();
            ProfesionalRepository repositorioDeProfesionales = new ProfesionalRepository();
            profesional = repositorioDeProfesionales.traerProfesionalPorUser(usuarioProfesional);
            resultadoAtencionMedica = new ResultadoAtencionMedica();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpFechaTurno_ValueChanged(object sender, EventArgs e)
        {
            TurnoRepository repositorioDeTurnos = new TurnoRepository();
            List<Turno> turnosDelProfesionalEnEseDia = new List<Turno>();
            turnosDelProfesionalEnEseDia = repositorioDeTurnos.traerTurnosDeProfesional(profesional, dtpFechaTurno.Value);

            if (turnosDelProfesionalEnEseDia.Count == 0)
            {
                MessageBox.Show("ERROR: No existen turnos en la fecha seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmbPacientes.DataSource = turnosDelProfesionalEnEseDia;
                cmbPacientes.DisplayMember = "nombreAfiliadoCompleto";
                cmbPacientes.Enabled = true;
                dtpFechaDiagnostico.MinDate = dtpFechaTurno.Value;
            }
        }

        private void RegistrarResultadoAtencionForm_Load(object sender, EventArgs e)
        {
            lblProfesional.Text = lblProfesional.Text + " " + profesional.usuario.nombreCompleto;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            resultadoAtencionMedica.sintomas = rtxtSintomas.Text;
            resultadoAtencionMedica.diagnostico = rtxtDiagnostico.Text;
            resultadoAtencionMedica.fechaDeDiagnostico = new DateTime(dtpFechaDiagnostico.Value.Year, dtpFechaDiagnostico.Value.Month, 
                dtpFechaDiagnostico.Value.Day, dtpHoraDiagnostico.Value.Hour, dtpHoraDiagnostico.Value.Minute, dtpHoraDiagnostico.Value.Second);
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (true) //TODO: Verificar que no tenga diagnostico todavia
            {
                lblAfiliado.Text = lblAfiliado.Text + " " + cmbPacientes.SelectedText;
                resultadoAtencionMedica.turnoID = ((Turno)cmbPacientes.SelectedItem).id;
                dtpFechaDiagnostico.Enabled = true;
                dtpHoraDiagnostico.Enabled = true;
            }
            else
            {
                MessageBox.Show("ERROR: El paciente ya tiene su diagnóstico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void activarBotonConfirmar()
        {
            if (rtxtSintomas.Text != "" && rtxtDiagnostico.Text != "")
            {
                btnConfirmar.Enabled = true;
            }
            else
            {
                btnConfirmar.Enabled = false;
            }
        }

        private void rtxtDiagnostico_TextChanged(object sender, EventArgs e)
        {
            activarBotonConfirmar();
        }

        private void rtxtSintomas_TextChanged(object sender, EventArgs e)
        {
            activarBotonConfirmar();
        }

        private void dtpHoraDiagnostico_ValueChanged(object sender, EventArgs e)
        {
            rtxtSintomas.Enabled = true;
            rtxtDiagnostico.Enabled = true;
        }
    }
}
