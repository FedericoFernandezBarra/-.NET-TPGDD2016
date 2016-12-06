using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TostadoPersistentKit;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class RegistrarResultadoAtencionForm : Form
    {
        Profesional profesional;
        ResultadoAtencionMedica resultadoAtencionMedica;

        public RegistrarResultadoAtencionForm(Usuario usuarioProfesional, Rol rol)
        {
            InitializeComponent();
            ProfesionalRepository repositorioDeProfesionales = new ProfesionalRepository();
            resultadoAtencionMedica = new ResultadoAtencionMedica();

            if (rol.nombre == "PROFESIONAL")
            {
                profesional = repositorioDeProfesionales.traerProfesionalPorUser(usuarioProfesional);
                txtProfesional.Text = profesional.usuario.nombreCompleto;
                cargarPacientesADiagnosticarDe(profesional);
            }
            else
            {
                btnBuscarProfesional.Visible = true;
            }

            lblDatoAfiliado.Text = "";
            lblDatoFecha.Text = "";
            lblDatoHora.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            resultadoAtencionMedica.sintomas = rtxtSintomas.Text;
            resultadoAtencionMedica.diagnostico = rtxtDiagnostico.Text;
            resultadoAtencionMedica.fechaDeDiagnostico = DataBase.Instance.getDate();

            new ResultadoAtencionMedicaRepository().registrarConsultaMedica(resultadoAtencionMedica);
            MessageBox.Show("Se ha guardado el diagnóstico exitosamente.", "Resultado de Atención Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
        

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turno turnoSeleccionado = ((Turno)cmbPacientes.SelectedItem);
            rtxtSintomas.Text = "";
            rtxtDiagnostico.Text = "";
            lblDatoAfiliado.Text = turnoSeleccionado.nombreAfiliadoCompleto;
            resultadoAtencionMedica.turno.id = turnoSeleccionado.id;
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

        public void cargarPacientesADiagnosticarDe(Profesional unProfesional)
        {
            List<Turno> turnosADiagnosticar = new List<Turno>();
            turnosADiagnosticar = new TurnoRepository().obtenerTurnosADiagnosticarDe(unProfesional);
            if (turnosADiagnosticar.Count > 0)
            {
                cmbPacientes.DataSource = turnosADiagnosticar;
                cmbPacientes.DisplayMember = "nombreAfiliadoCompleto";
                cmbPacientes.Enabled = true;
                rtxtSintomas.Enabled = true;
                rtxtDiagnostico.Enabled = true;
                lblDatoFecha.Text = DataBase.Instance.getDate().ToString("dddd dd/MM/yyyy");
                lblDatoHora.Text = DataBase.Instance.getDate().ToString("HH:mm");
                lblDatoAfiliado.Text = ((Turno)cmbPacientes.SelectedItem).nombreAfiliadoCompleto;
            }
            else
            {
                MessageBox.Show("ERROR: No hay turnos que se hayan registrado su llegada. Fecha: " + DataBase.Instance.getDate().ToString("dd/MM/yyyy HH:mm"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPacientes.Enabled = false;
                rtxtSintomas.Enabled = false;
                rtxtDiagnostico.Enabled = false;
                btnConfirmar.Enabled = false;    
            }
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            BuscarProfesionalForm buscarProfesionalForm = new BuscarProfesionalForm();

            Hide();

            buscarProfesionalForm.ShowDialog();

            Show();

            if (buscarProfesionalForm.seSeleccionoUnProfesional())
            {
                profesional = buscarProfesionalForm.getProfesionalSeleccionado();
                txtProfesional.Text = profesional.usuario.nombreCompleto;
                cmbPacientes.Enabled = false;
                rtxtSintomas.Enabled = false;
                rtxtDiagnostico.Enabled = false;
                btnConfirmar.Enabled = false;
                cargarPacientesADiagnosticarDe(profesional);
            }
        }
    }
}
