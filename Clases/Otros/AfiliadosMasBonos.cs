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
    public class AfiliadosMasBonos : Listado
    {
        public override void initDataGrid(ref DataGridView grilla)
        {
            DataGridViewTextBoxColumn cNroAfiliado = new DataGridViewTextBoxColumn();
            cNroAfiliado.HeaderText = "Nro de afiliado";
            cNroAfiliado.ReadOnly = true;
            grilla.Columns.Add(cNroAfiliado);
            DataGridViewTextBoxColumn cNombre = new DataGridViewTextBoxColumn();
            cNombre.HeaderText = "Nombre";
            cNombre.ReadOnly = true;
            grilla.Columns.Add(cNombre);
            DataGridViewTextBoxColumn cApellido = new DataGridViewTextBoxColumn();
            cApellido.HeaderText = "Apellido";
            cApellido.ReadOnly = true;
            grilla.Columns.Add(cApellido);
            DataGridViewTextBoxColumn cConsultas = new DataGridViewTextBoxColumn();
            cConsultas.HeaderText = "Bonos comprados";
            cConsultas.ReadOnly = true;
            grilla.Columns.Add(cConsultas);
            DataGridViewTextBoxColumn cGrupoFamiliar = new DataGridViewTextBoxColumn();
            cGrupoFamiliar.HeaderText = "Pertenece a grupo familiar";
            cGrupoFamiliar.ReadOnly = true;
            grilla.Columns.Add(cGrupoFamiliar);
        }

        public override string initFiltros(ComboBox filtro)
        {
            return "";
        }

        public override void llenarDataGrid(DataGridView grilla, int mes, int anio)
        {
            AfiliadoRepository repoAfiliado = new AfiliadoRepository();

            List<Dictionary<string, object>> afiliadosYBonos = repoAfiliado.top5AfiliadosConMasBonos(mes, anio);

            grilla.Rows.Clear();

            afiliadosYBonos.ToList().ForEach(o => grilla.Rows.Add(((Afiliado)o["afiliado"]).numeroDeAfiliado, ((Afiliado)o["afiliado"]).usuario.nombre, ((Afiliado)o["afiliado"]).usuario.apellido, o["bonos"],o["grupo_familiar"]));
        }

        public override void llenarDataGrid(ref DataGridView grilla, List<int> meses, int anio)
        {
            throw new NotImplementedException();
        }
    }
}
