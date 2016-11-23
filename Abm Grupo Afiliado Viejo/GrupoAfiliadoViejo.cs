using ClinicaFrba.Clases.DAOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Grupo_Afiliado_Viejo
{
    public partial class GrupoAfiliadoViejo : Form
    {
        /*ATRIBUTOS*/
        /*************************************************************************************/
        List<Dictionary<string, object>> listaAfiliadosSinNumero = new List<Dictionary<string, object>>();

        GrupoAfiliadoViejoRepository db = new GrupoAfiliadoViejoRepository();

        long idPrincipal = 0;

        long idConyuge = 0;

        Dictionary<string, long> diccionarioHijos = new Dictionary<string, long>();


        /*FUNCIONES*/
        /*************************************************************************************/
        public GrupoAfiliadoViejo()
        {
            InitializeComponent();

            listaAfiliadosSinNumero = db.traerAfiliadosSinNumero();

            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            listaAfiliadosSinNumero = db.traerAfiliadosSinNumero();
            if (listaAfiliadosSinNumero == null) return;

            dataGridAfiliados.Rows.Clear();

            foreach (Dictionary<string, object> par in listaAfiliadosSinNumero)
            {
                dataGridAfiliados.Rows.Add(par["DNI"].ToString(), par["NOMBRE"].ToString(), par["APELLIDO"].ToString());
            }
            dataGridAfiliados.AutoResizeColumns();
            dataGridAfiliados.AutoResizeRows();
        }

        private long obtenerIdPorDNI(string dni)
        {
            foreach (Dictionary<string, object> par in listaAfiliadosSinNumero)
            {
                if (par["DNI"].ToString() == dni) return Convert.ToInt64(par["ID"]);
            }
            return 0;
        }

        private Dictionary<string, object> obtenerDatosPorDNI(string dni)
        {
            foreach (Dictionary<string, object> par in listaAfiliadosSinNumero)
            {
                if (par["DNI"].ToString() == dni) return par;
            }
            return null;
        }

        private void actualizarListboxHijos()
        {
            listBoxHijos.Items.Clear();

            Dictionary<string, object> datos = new Dictionary<string, object>();

            foreach (KeyValuePair<string, long> par in diccionarioHijos)
            {
                datos = obtenerDatosPorDNI(par.Key);

                listBoxHijos.Items.Add(
                    datos["DNI"].ToString()+" "+
                    datos["NOMBRE"]+" "+
                    datos["APELLIDO"]);   
            }
        }

        private void reiniciarVariablesYElementosDeLAVista()
        {
            idPrincipal = 0;
            idConyuge = 0;
            diccionarioHijos.Clear();

            lbPrincipal.Text = "";
            lbConyuge.Text = "";
            listBoxHijos.Items.Clear();
        }

        private void bloquearBotones()
        {
            bGuardarCambios.Enabled = false;
            bVolverAtras.Enabled = false;
            bAgregarHijo.Enabled = false;
            bEliminarHijo.Enabled = false;
            bAsignarPrincipal.Enabled = false;
            bAsignarConyuge.Enabled = false;
        }

        private void desbloquearBotones()
        {
            bGuardarCambios.Enabled = true;
            bVolverAtras.Enabled = true;
            bAgregarHijo.Enabled = true;
            bEliminarHijo.Enabled = true;
            bAsignarPrincipal.Enabled = true;
            bAsignarConyuge.Enabled = true;
        }

        /*VALIDACIONES*/
        /*************************************************************************************/
        private bool cumpleValidacionesParaAgregarHijo()
        {
            if (diccionarioHijos.ContainsKey(dataGridAfiliados.SelectedRows[0].Cells["DNI"].Value.ToString()))
            {
                MessageBox.Show("El afiliado ya se encuentra en la lista de hijos", "ERROR!", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool cumpleValidacionesParaGuardarCambios()
        {
            if (idPrincipal == 0)
            {
                MessageBox.Show("Debe seleccionar un principal", "ERROR!", MessageBoxButtons.OK);
                return false;
            }

            if (idConyuge == idPrincipal || diccionarioHijos.ContainsValue(idPrincipal) || diccionarioHijos.ContainsValue(idConyuge))
            {
                MessageBox.Show("Existen afiliados repetidos en los seleccionados", "ERROR!", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        /*BOTONES Y EVENTOS*/
        /*************************************************************************************/
        private void bGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!cumpleValidacionesParaGuardarCambios()) return;

            bloquearBotones();

            try
            {
                db.asignarNuerosDeUsuario(idPrincipal, idConyuge, diccionarioHijos.Values.ToList());
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar los cambios", "ERROR!", MessageBoxButtons.OK);
                return;
            }

            cargarDataGrid();
            reiniciarVariablesYElementosDeLAVista();

            desbloquearBotones();

            MessageBox.Show("Se han guardado los cambios exitosamente", "Aviso", MessageBoxButtons.OK);
        }

        private void bAsignarPrincipal_Click(object sender, EventArgs e)
        {
            if (dataGridAfiliados.SelectedRows.Count == 0) return;
            
            idPrincipal = obtenerIdPorDNI(dataGridAfiliados.SelectedRows[0].Cells["DNI"].Value.ToString());
            
            lbPrincipal.Text = 
                dataGridAfiliados.SelectedRows[0].Cells["DNI"].Value.ToString()+" "+
                dataGridAfiliados.SelectedRows[0].Cells["NOMBRE"].Value.ToString()+" "+
                dataGridAfiliados.SelectedRows[0].Cells["APELLIDO"].Value.ToString();
        }

        private void bAsignarConyuge_Click(object sender, EventArgs e)
        {
            if (dataGridAfiliados.SelectedRows.Count == 0) return;

            idConyuge = obtenerIdPorDNI(dataGridAfiliados.SelectedRows[0].Cells["DNI"].Value.ToString());

            lbConyuge.Text =
                dataGridAfiliados.SelectedRows[0].Cells["DNI"].Value.ToString() + " " +
                dataGridAfiliados.SelectedRows[0].Cells["NOMBRE"].Value.ToString() + " " +
                dataGridAfiliados.SelectedRows[0].Cells["APELLIDO"].Value.ToString();
        }

        private void bAgregarHijo_Click(object sender, EventArgs e)
        {
            if (dataGridAfiliados.SelectedRows.Count == 0) return;

            if (!cumpleValidacionesParaAgregarHijo()) return;

            long idHijoSeleccionado = obtenerIdPorDNI(dataGridAfiliados.SelectedRows[0].Cells["DNI"].Value.ToString());
            string dniHijoSelecionado = dataGridAfiliados.SelectedRows[0].Cells["DNI"].Value.ToString();

            diccionarioHijos.Add(dniHijoSelecionado, idHijoSeleccionado);

            actualizarListboxHijos();
        }

        private void bEliminarHijo_Click(object sender, EventArgs e)
        {
            if (listBoxHijos.SelectedIndex == -1) return;

            int indexHijoBorrado = listBoxHijos.SelectedIndex;
            string dniHijoSelecionado = listBoxHijos.SelectedItem.ToString().Split(' ')[0];

            diccionarioHijos.Remove(dniHijoSelecionado);

            actualizarListboxHijos();
        }

        private void bVolverAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
