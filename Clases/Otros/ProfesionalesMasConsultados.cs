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
    public class ProfesionalesMasConsultados : Listado
    {
        private List<PlanMedico> planes;

        public override void initDataGrid(ref DataGridView grilla)
        {
            DataGridViewTextBoxColumn cMatricula = new DataGridViewTextBoxColumn();
            cMatricula.HeaderText = "Matricula";
            cMatricula.ReadOnly = true;
            grilla.Columns.Add(cMatricula);
            DataGridViewTextBoxColumn cNombre = new DataGridViewTextBoxColumn();
            cNombre.HeaderText = "Nombre";
            cNombre.ReadOnly = true;
            grilla.Columns.Add(cNombre);
            DataGridViewTextBoxColumn cApellido = new DataGridViewTextBoxColumn();
            cApellido.HeaderText = "Apellido";
            cApellido.ReadOnly = true;
            grilla.Columns.Add(cApellido);
            DataGridViewTextBoxColumn cConsultas = new DataGridViewTextBoxColumn();
            cConsultas.HeaderText = "Cantidad de consultas";
            cConsultas.ReadOnly = true;
            grilla.Columns.Add(cConsultas);
        }

        public override string initFiltros(ComboBox filtro)
        {
            PlanMedicoRepository repoPlan = new PlanMedicoRepository();
            planes = repoPlan.traerPlanesMedicos();

            planes.ForEach(p => filtro.Items.Add(p.descripcion));

            return "Plan:";
        }

        public override void llenarDataGrid(DataGridView grilla, int mes, int anio)
        {
            ProfesionalRepository repoProfesional = new ProfesionalRepository();

            PlanMedico filtroPlan = indexFiltro >= 0 ? planes[indexFiltro] : null;

            List<Dictionary<string, object>> profesionalesYconsultas = repoProfesional.top5ProfesionalesMasConsultas(mes, anio, filtroPlan);

            grilla.Rows.Clear();

            profesionalesYconsultas.ToList().ForEach(o => grilla.Rows.Add(((Profesional)o["profesional"]).matricula, ((Profesional)o["profesional"]).usuario.nombre, ((Profesional)o["especialidad"]).usuario.apellido, o["consultas"]));
        }

        public override void llenarDataGrid(ref DataGridView grilla, List<int> meses, int anio)
        {
            throw new NotImplementedException();
        }
    }
}
