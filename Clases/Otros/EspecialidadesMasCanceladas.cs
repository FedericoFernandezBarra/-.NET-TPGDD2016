using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Clases.Otros
{
    public class EspecialidadesMasCanceladas : Listado
    {
        public override void initDataGrid(ref DataGridView grilla)
        {
            DataGridViewTextBoxColumn cDescripcion = new DataGridViewTextBoxColumn();
            cDescripcion.HeaderText = "Descripcion";
            cDescripcion.ReadOnly = true;
            grilla.Columns.Add(cDescripcion);
            DataGridViewTextBoxColumn cTipoEspecialidad = new DataGridViewTextBoxColumn();
            cTipoEspecialidad.HeaderText = "Tipo de Especialidad";
            cTipoEspecialidad.ReadOnly = true;
            grilla.Columns.Add(cTipoEspecialidad);
            DataGridViewTextBoxColumn cCancelaciones = new DataGridViewTextBoxColumn();
            cCancelaciones.HeaderText = "Cantidad de cancelaciones";
            cCancelaciones.ReadOnly = true;
            grilla.Columns.Add(cCancelaciones);
        }

        public override string initFiltros(ComboBox filtro)
        {
            return "";
        }

        public override void llenarDataGrid(DataGridView grilla, int mes, int anio)
        {
            grilla.Rows.Clear();

            EspecialidadRepository repoEspecialidad = new EspecialidadRepository();

           List<Dictionary<string, object>> especialidadesYCancelaciones = repoEspecialidad.top5EspecialidadesCanceladas(mes,anio);

            especialidadesYCancelaciones.ToList().ForEach(o => grilla.Rows.Add(((Especialidad)o["especialidad"]).descripcion, ((Especialidad)o["especialidad"]).tipoDeEspecialidad.descripcion, o["cancelaciones"]));
        }

        public override void llenarDataGrid(ref DataGridView grilla, List<int> meses, int anio)
        {
            throw new NotImplementedException();
        }
    }
}
