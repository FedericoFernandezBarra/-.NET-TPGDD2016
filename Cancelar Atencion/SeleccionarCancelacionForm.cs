using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Abm_Profesional;
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
    public partial class SeleccionarCancelacionForm : Form
    {
        private const string CANCELAR_AFILIADO = "CANCELAR TURNO AFILIADO";
        private const string CANCELAR_PROFESIONAL = "CANCELAR TURNOS PROFESIONAL";

        private Form formularioDeCancelacion = null;

        public Form getFormularioCancelacionSeleccionado()
        {
            return formularioDeCancelacion;
        }

        public SeleccionarCancelacionForm()
        {
            InitializeComponent();
        }

        private void SeleccionarCancelacionForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            comboBox_Cancelaciones.Items.Add(CANCELAR_AFILIADO);
            comboBox_Cancelaciones.Items.Add(CANCELAR_PROFESIONAL);
            comboBox_Cancelaciones.SelectedIndex = 0;
        }

        private void continuar_Boton_Click(object sender, EventArgs e)
        {
            switch (comboBox_Cancelaciones.SelectedItem.ToString())
            {
                case CANCELAR_AFILIADO:

                    BuscarAfiliadoForm buscarAfiliado = new BuscarAfiliadoForm();
                    Hide();
                    buscarAfiliado.ShowDialog();
                    Afiliado afiliado;

                    if (!buscarAfiliado.seSeleccionoUnAfiliado())
                    {
                        break;
                    }

                    afiliado = buscarAfiliado.getAfiliadoSeleccionado();

                    formularioDeCancelacion = new CancelarTurnoForm(afiliado);

                    break;

                case CANCELAR_PROFESIONAL:

                    BuscarProfesionalForm buscarProfesional = new BuscarProfesionalForm();
                    Hide();
                    buscarProfesional.ShowDialog();
                    Profesional profesional;

                    if (!buscarProfesional.seSeleccionoUnProfesional())
                    {
                        break;
                    }

                    profesional = buscarProfesional.getProfesionalSeleccionado();

                    formularioDeCancelacion = new CancelarDiasForm(profesional);

                    break;
            }

            Close();
        }
    }
}
