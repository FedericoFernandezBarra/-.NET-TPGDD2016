using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Clases.Otros
{
    public abstract class Listado
    {
        internal int indexFiltro = -1;
        //internal UsuarioRepository repositorio = new UsuarioRepository();

        public abstract void initDataGrid(ref DataGridView grilla);
        public abstract void llenarDataGrid(ref DataGridView grilla, List<int> meses, int anio);
        public abstract void llenarDataGrid(DataGridView grilla, int mes, int anio);

        public void seleccionarFiltro(int selectedIndex)
        {
            indexFiltro = selectedIndex;
        }

        public abstract string initFiltros(ComboBox filtro);
    }
}
