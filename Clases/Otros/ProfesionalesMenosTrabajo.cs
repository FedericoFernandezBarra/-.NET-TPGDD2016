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
    public class ProfesionalesMenosTrabajo : Listado
    {
        private List<Especialidad> especialidades;

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
            DataGridViewTextBoxColumn cHoras = new DataGridViewTextBoxColumn();
            cHoras.HeaderText = "Horas trabajadas";
            cHoras.ReadOnly = true;
            grilla.Columns.Add(cHoras);
        }

        public override string initFiltros(ComboBox filtro)
        {
            especialidades = (new EspecialidadRepository()).traerEspecialidades();
            especialidades.ForEach(e => filtro.Items.Add(e.descripcion));
            return "Especialidad:";
        }

        public override void llenarDataGrid(DataGridView grilla, int mes, int anio)
        {
            ProfesionalRepository repoProfesional = new ProfesionalRepository();

            Especialidad filtroEspecialidad = indexFiltro >= 0 ? especialidades[indexFiltro] : null;

            List<Dictionary<string, object>> profesionalesYHoras = repoProfesional.top5ProfesionalesMenosHorasTRabajadas(mes, anio, filtroEspecialidad);

            grilla.Rows.Clear();

            profesionalesYHoras.ToList().ForEach(o => grilla.Rows.Add(((Profesional)o["profesional"]).matricula, ((Profesional)o["profesional"]).usuario.nombre, ((Profesional)o["profesional"]).usuario.apellido, o["horas"]));
        }

        public override void llenarDataGrid(ref DataGridView grilla, List<int> meses, int anio)
        {
            throw new NotImplementedException();
        }
    }
}
