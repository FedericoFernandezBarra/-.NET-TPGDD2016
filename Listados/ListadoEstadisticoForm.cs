using ClinicaFrba.Clases.Otros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    public partial class ListadoEstadisticoForm : Form
    {
        private const string ESPECIALIDADES_MAS_CANCELADAS = "Especialidades con mas cancelaciones";
        private const string PROFESIONALES_MAS_CONSULTADOS = "Profesionales mas consultados por plan";
        private const string PROFESIONALES_MENOS_TRABAJO = "Profesionales con menos horas trabajadas";
        private const string ESPECIALIDADES_MAS_BONOS = "Especialidades con mas bonos gastados";
        private const string AFILIADOS_MAS_BONOS= "Afiliados con mas bonos comprados";
        private const string VACIO = "Ninguno";
        private Listado listado;
        private List<int> mesesFiltro;

        public ListadoEstadisticoForm()
        {
            InitializeComponent();
        }

        private void ListadoEstadisticoForm_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }
        private void inicializarFormulario()
        {
            filtroEspecial.Text = "";

            filtro.Enabled = false;

            semestre.Items.Clear();

            mes.Items.Clear();

            tipoListado.Items.Clear();

            tipoListado.Items.Add(VACIO);
            tipoListado.Items.Add(ESPECIALIDADES_MAS_CANCELADAS);
            tipoListado.Items.Add(PROFESIONALES_MAS_CONSULTADOS);
            tipoListado.Items.Add(PROFESIONALES_MENOS_TRABAJO);
            tipoListado.Items.Add(ESPECIALIDADES_MAS_BONOS);
            tipoListado.Items.Add(AFILIADOS_MAS_BONOS);

        tipoListado.SelectedItem = "ninguno";

            mes.Items.Add("ninguno");
            mes.Items.Add("enero");
            mes.Items.Add("febrero");
            mes.Items.Add("marzo");
            mes.Items.Add("abril");
            mes.Items.Add("mayo");
            mes.Items.Add("junio");
            mes.Items.Add("julio");
            mes.Items.Add("agosto");
            mes.Items.Add("septiembre");
            mes.Items.Add("octubre");
            mes.Items.Add("noviembre");
            mes.Items.Add("diciembre");

            mes.SelectedItem = "ninguno";

            anio.Text = "";

            for (int i = 0; i < 3; i++)
            {
                semestre.Items.Add(i);
            }

            semestre.SelectedIndex = 0;
            tipoListado.SelectedIndex = 0;

            filtro.Items.Clear();

            limpiarDataGrid();
        }

        private void limpiarDataGrid()
        {
            tablaEstadistica.Rows.Clear();
            tablaEstadistica.Columns.Clear();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*private void anio_TextChanged(object sender, EventArgs e)
        {
            if (anio.Text.Length > 4)
            {
                anio.Text = anio.Text.Remove(anio.Text.Length - 1);
            }

            semestre.Enabled = anio.Text.Length == 4;
        }*/

        /*private void semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoListado.Enabled = (int)semestre.SelectedItem != 0;
            mes.Enabled = (int)semestre.SelectedItem != 0;
            buscarButton.Enabled = (int)semestre.SelectedItem != 0;
        }*/

        /*private void limpiarBoton_Click(object sender, EventArgs e)
        {
            inicializarFormulario();
        }*/

        /*private void tipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarDataGrid();
            filtro.Items.Add("");
            filtro.SelectedItem = "";
            filtro.Items.Clear();//Esto es para que se borre el combo box cuando cambio a un listado sin filtro

            switch (tipoListado.SelectedItem.ToString())
            {
                case ESPECIALIDADES_MAS_CANCELADAS:
                    listado = new EspecialidadesMasCanceladas();
                    break;
                case PROFESIONALES_MAS_CONSULTADOS:
                    listado = new ProfesionalesMasConsultados();
                    break;
                case PROFESIONALES_MENOS_TRABAJO:
                    listado = new ProfesionalesMenosTrabajo();
                    break;
                case ESPECIALIDADES_MAS_BONOS:
                    listado = new EspecialidadesMasBonos();
                    break;
            }

            if (tipoListado.SelectedItem.ToString() != VACIO)
            {
                listado.initDataGrid(ref tablaEstadistica);
                filtroEspecial.Text = listado.initFiltros(ref filtro);

                filtro.Enabled = filtroEspecial.Text != "";
            }

            buscarButton.Enabled = tipoListado.SelectedItem.ToString() != VACIO;
        }*/

        /*private void buscarButton_Click(object sender, EventArgs e)
        {
            Regex regAnio = new Regex("[0-9]");
            bool anioSonNumeros = regAnio.IsMatch(anio.Text);
            if (anio.Text.Length != 4 || !anioSonNumeros)
            {
                MessageBox.Show("Año ingresado no valido");
                return;
            }
            if (Convert.ToInt16(semestre.SelectedItem) == 0)
            {
                MessageBox.Show("Debe seleccionar un trimestre");
                return;
            }

            tablaEstadistica.Rows.Clear();

            int semestreSeleccionado = Convert.ToInt16(semestre.SelectedItem);

            if ((semestreSeleccionado * 6 < mes.SelectedIndex || mes.SelectedIndex < (semestreSeleccionado * 6 - 5)) && mes.SelectedIndex > 0)
            {
                MessageBox.Show("Mes seleccionado no corresponde a trimestre");
                return;
            }

            updateFiltroMeses();

            listado.llenarDataGrid(ref tablaEstadistica, mesesFiltro, Convert.ToInt16(anio.Text));
        }*/

        private void updateFiltroMeses()
        {
            mesesFiltro = new List<int> { mes.SelectedIndex, 0, 0 };

            if (mes.SelectedIndex != 0)
            {
                return;
            }

            int semestreSeleccionado = Convert.ToInt16(semestre.SelectedItem);

            for (int i = 0; i < 2; i++)
            {
                mesesFiltro[i] = 6 * semestreSeleccionado - 5 + i;
            }
        }

        /*private void filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            listado.seleccionarFiltro(filtro.SelectedIndex);
        }*/

        private void anio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void anio_TextChanged(object sender, EventArgs e)
        {
            semestre.Enabled = anio.Text.Length == 4;
        }

        private void filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listado != null)
            {
                listado.seleccionarFiltro(filtro.SelectedIndex);
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Regex regAnio = new Regex("[0-9]");
            bool anioSonNumeros = regAnio.IsMatch(anio.Text);
            if (anio.Text.Length != 4 || !anioSonNumeros)
            {
                MessageBox.Show("Año ingresado no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt16(semestre.SelectedItem) == 0)
            {
                MessageBox.Show("Debe seleccionar un semestre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mes.SelectedIndex==0)
            {
                MessageBox.Show("Debe seleccionar un mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tablaEstadistica.Rows.Clear();

            int semestreSeleccionado = Convert.ToInt16(semestre.SelectedItem);

            if ((semestreSeleccionado * 6 < mes.SelectedIndex || mes.SelectedIndex < (semestreSeleccionado * 6 - 5)) && mes.SelectedIndex > 0)
            {
                MessageBox.Show("Mes seleccionado no corresponde a semestre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listado==null)
            {
                MessageBox.Show("Debe seleccionar un listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //updateFiltroMeses();

            listado.llenarDataGrid(tablaEstadistica, mes.SelectedIndex, Convert.ToInt16(anio.Text));
        }

        private void tipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarDataGrid();
            filtro.Items.Add("");
            filtro.SelectedItem = "";
            filtro.Items.Clear();//Esto es para que se borre el combo box cuando cambio a un listado sin filtro

            switch (tipoListado.SelectedItem.ToString())
            {
                case ESPECIALIDADES_MAS_CANCELADAS:
                    listado = new EspecialidadesMasCanceladas();
                    break;
                case PROFESIONALES_MAS_CONSULTADOS:
                    listado = new ProfesionalesMasConsultados();
                    break;
                case PROFESIONALES_MENOS_TRABAJO:
                    listado = new ProfesionalesMenosTrabajo();
                    break;
                case ESPECIALIDADES_MAS_BONOS:
                    listado = new EspecialidadesMasBonos();
                    break;
                case AFILIADOS_MAS_BONOS:
                    listado = new AfiliadosMasBonos();
                    break;
            }

            if (tipoListado.SelectedItem.ToString() != VACIO)
            {
                listado.initDataGrid(ref tablaEstadistica);
                filtroEspecial.Text = listado.initFiltros(filtro);

                filtro.Enabled = filtroEspecial.Text != "";
            }

            buscarButton.Enabled = tipoListado.SelectedItem.ToString() != VACIO;
        }

        private void limpiarBoton_Click(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoListado.Enabled = (int)semestre.SelectedItem != 0;
            mes.Enabled = (int)semestre.SelectedItem != 0;
            buscarButton.Enabled = (int)semestre.SelectedItem != 0;
        }
    }
}
