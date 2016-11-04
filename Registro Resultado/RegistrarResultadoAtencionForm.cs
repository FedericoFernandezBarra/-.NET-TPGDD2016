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
        private bool yaExistiaElDiagnostico = false;

        public RegistrarResultadoAtencionForm(Usuario usuarioProfesional, Rol rol)
        {
            InitializeComponent();
            ProfesionalRepository repositorioDeProfesionales = new ProfesionalRepository();
            resultadoAtencionMedica = new ResultadoAtencionMedica();

            if (rol.nombre == "PROFESIONAL")
            {
                profesional = repositorioDeProfesionales.traerProfesionalPorUser(usuarioProfesional);
                txtProfesional.Text = profesional.usuario.nombreCompleto;
                filtrarCalendarioPorTurnos();
            }
            else
            {
                btnBuscarProfesional.Visible = true;
            }   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            resultadoAtencionMedica.sintomas = rtxtSintomas.Text;
            resultadoAtencionMedica.diagnostico = rtxtDiagnostico.Text;
            resultadoAtencionMedica.fechaDeDiagnostico = new DateTime(dtpFechaDiagnostico.Value.Year, dtpFechaDiagnostico.Value.Month, 
                dtpFechaDiagnostico.Value.Day, dtpHoraDiagnostico.Value.Hour, dtpHoraDiagnostico.Value.Minute, dtpHoraDiagnostico.Value.Second);

            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@id_turno", resultadoAtencionMedica.turnoID);
            DataBase.Instance.agregarParametro(parametros, "@sintoma", resultadoAtencionMedica.sintomas);
            DataBase.Instance.agregarParametro(parametros, "@enfermedad", resultadoAtencionMedica.diagnostico);
            DataBase.Instance.agregarParametro(parametros, "@fecha_diagnostico", resultadoAtencionMedica.fechaDeDiagnostico);

            if (yaExistiaElDiagnostico)
            {
                DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_actualizar_consulta", parametros);
            }
            else
            {
                DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_registrar_consulta", parametros);
            }

            MessageBox.Show("Se ha guardado el diagnóstico exitosamente.", "Resultado de Atención Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turno turnoSeleccionado = ((Turno)cmbPacientes.SelectedItem);

            if (yaTieneDiagnostico(turnoSeleccionado))
            {
                resultadoAtencionMedica = obtenerResultadoDeAtencionMedicaDe(turnoSeleccionado);
                dtpFechaDiagnostico.Value = resultadoAtencionMedica.fechaDeDiagnostico;
                dtpHoraDiagnostico.Value = resultadoAtencionMedica.fechaDeDiagnostico;
                rtxtSintomas.Text = resultadoAtencionMedica.sintomas;
                rtxtDiagnostico.Text = resultadoAtencionMedica.diagnostico;
                btnConfirmar.Enabled = true;

                yaExistiaElDiagnostico = true;
            }
            else
            {
                yaExistiaElDiagnostico = false;
            }

            lblNombreAfiliado.Text = turnoSeleccionado.nombreAfiliadoCompleto;
            resultadoAtencionMedica.turnoID = turnoSeleccionado.id;
            dtpFechaDiagnostico.Enabled = true;
            dtpHoraDiagnostico.Enabled = true;    
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

        private void dtpFechaTurno_CloseUp(object sender, EventArgs e)
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
                rtxtSintomas.Enabled = true;
                rtxtDiagnostico.Enabled = true;
                lblNombreAfiliado.Text = ((Turno)cmbPacientes.SelectedItem).nombreAfiliadoCompleto;
                dtpFechaDiagnostico.MinDate = dtpFechaTurno.Value;
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
                filtrarCalendarioPorTurnos();
            }
        }

        private void filtrarCalendarioPorTurnos()
        {
            TurnoRepository turnoRepository = new TurnoRepository();
            if (turnoRepository.tieneTurno(profesional))
            {
                dtpFechaTurno.MinDate = turnoRepository.obtenerFechaMinimaDeTurnoDe(profesional);
                dtpFechaTurno.MaxDate = turnoRepository.obtenerFechaMaximaDeTurnoDe(profesional);
                dtpFechaTurno.Value = dtpFechaTurno.MinDate;
                dtpFechaTurno.Enabled = true;
            }
            else
            {
                MessageBox.Show("ERROR: El profesional no tiene turnos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaTurno.Enabled = false;
                cmbPacientes.Enabled = false;
                rtxtSintomas.Enabled = false;
                rtxtDiagnostico.Enabled = false;
                btnConfirmar.Enabled = false;
            } 
        }

        private bool yaTieneDiagnostico(Turno unTurno)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@turno", unTurno.id);

            return DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_obtener_consulta", parametros).Count > 0;
        }

        private ResultadoAtencionMedica obtenerResultadoDeAtencionMedicaDe(Turno unTurno)
        {
            ResultadoAtencionMedica resultadoAtencionMedica = new ResultadoAtencionMedica();
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@turno", unTurno.id);

            List<Dictionary<String, Object>> resultado = DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_obtener_consulta", parametros);
            resultadoAtencionMedica.consultaID = Convert.ToInt64(resultado[0]["id_consulta"]);
            resultadoAtencionMedica.turnoID = Convert.ToInt64(resultado[0]["turno"]);
            resultadoAtencionMedica.sintomas = (String)resultado[0]["sintoma"].ToString();
            resultadoAtencionMedica.diagnostico = (String)resultado[0]["enfermedad"];
            resultadoAtencionMedica.fechaDeDiagnostico = (DateTime)resultado[0]["fecha_diagnostico"];

            return resultadoAtencionMedica;
        }
    }
}
