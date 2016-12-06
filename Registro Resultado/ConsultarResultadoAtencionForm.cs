using ClinicaFrba.Abm_Profesional;
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
using TostadoPersistentKit;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class ConsultarResultadoAtencionForm : Form
    {
        ResultadoAtencionMedicaRepository resultadoAtencionMedicaRepository;
        Profesional profesional;

        public ConsultarResultadoAtencionForm(Usuario usuarioProfesional, Rol rol)
        {
            InitializeComponent();
            ProfesionalRepository repositorioDeProfesionales = new ProfesionalRepository();
            resultadoAtencionMedicaRepository = new ResultadoAtencionMedicaRepository();

            if (rol.nombre == "PROFESIONAL")
            {
                profesional = repositorioDeProfesionales.traerProfesionalPorUser(usuarioProfesional);
                txtProfesional.Text = profesional.usuario.nombreCompleto;
                delimitarFechasPorConsultas();
            }
            else
            {
                btnBuscarProfesional.Visible = true;
            }

            mcFechaConsulta.TodayDate = DataBase.Instance.getDate();
            lblDatoAfiliado.Text = "";
            lblDatoFecha.Text = "";
            lblDatoHora.Text = "";
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultadoAtencionMedica consulta = (ResultadoAtencionMedica)cmbPacientes.SelectedItem;
            lblDatoAfiliado.Text = consulta.nombreAfiliadoCompleto;
            lblDatoFecha.Text = consulta.fechaDeDiagnostico.ToString("dd/MM/yyyy");
            lblDatoHora.Text = consulta.fechaDeDiagnostico.ToString("HH:mm");
            rtxtSintomas.Text = consulta.sintomas;
            rtxtDiagnostico.Text = consulta.diagnostico;
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
                delimitarFechasPorConsultas();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mcFechaConsulta_DateSelected(object sender, DateRangeEventArgs e)
        {
            List<ResultadoAtencionMedica> resultadosAtencionMedica = resultadoAtencionMedicaRepository.
                obtenerConsultasMedicasDe(profesional, mcFechaConsulta.SelectionRange.Start);
            if (resultadosAtencionMedica.Count > 0)
            {
                cmbPacientes.DataSource = resultadosAtencionMedica;
                cmbPacientes.DisplayMember = "nombreAfiliadoCompleto";
                cmbPacientes.Enabled = true;
            }
            else
            {
                MessageBox.Show("ERROR: El profesional no tiene consultas en la fecha seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDatoAfiliado.Text = "";
                lblDatoFecha.Text = "";
                lblDatoHora.Text = "";
                rtxtSintomas.Text = "";
                rtxtDiagnostico.Text = "";
                cmbPacientes.Enabled = false;
            }
        }

        private void delimitarFechasPorConsultas()
        {
            mcFechaConsulta.Enabled = true;
            try
            {
                mcFechaConsulta.MinDate = resultadoAtencionMedicaRepository.obtenerFechaMinimaDeConsultaDe(profesional);
                mcFechaConsulta.MaxDate = resultadoAtencionMedicaRepository.obtenerFechaMaximaDeConsultaDe(profesional);
                if(DataBase.Instance.getDate().Date <= mcFechaConsulta.MaxDate.Date && DataBase.Instance.getDate().Date >= mcFechaConsulta.MinDate.Date)
                {
                    mcFechaConsulta.SetDate(DataBase.Instance.getDate().Date);
                }
            }
            catch
            {
                MessageBox.Show("ERROR: El profesional no tiene consultas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
