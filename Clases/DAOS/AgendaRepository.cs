using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    internal class AgendaRepository : Repository
    {
        DataBase db = DataBase.Instance;

        internal override Type getModelClassType()
        {
            throw new NotImplementedException();
        }

        public Agenda traerAgendaDelProfesional(Usuario usuario)
        {
            string procedimiento = "BEMVINDO.sp_agenda_deL_profesional";

            SqlParameter pIdProfesional = new SqlParameter("@id_profesional", usuario.id);
            List<SqlParameter> parametros = new List<SqlParameter> { pIdProfesional };

            List<Dictionary<string, object>> listaDB = db.ejecutarStoredProcedure(procedimiento, parametros);

            List<DiaAgenda> listaDiasAgenda = new List<DiaAgenda>();
            foreach (Dictionary<string, object> dic in listaDB)
            {
                DiaAgenda diaAgenda = new DiaAgenda((string)dic["dia"], (string)dic["especialidad"], (TimeSpan)dic["horario_inicial"], (TimeSpan)dic["horario_final"]);
                listaDiasAgenda.Add(diaAgenda);
            }

            return new Agenda(Convert.ToInt64(listaDB[0]["id_agenda"]), usuario.id, (DateTime)listaDB[0]["fecha_inicial"], (DateTime)listaDB[0]["fecha_final"], listaDiasAgenda);
        }

        public Dictionary<long, string> traerEspecialidadesDeProfesional(Usuario usuario)
        {
            string procedimiento = "BEMVINDO.sp_nombre_de_especialidades_del_profesional";

            SqlParameter pIdProfesional = new SqlParameter("@id_profesional", usuario.id);
            List<SqlParameter> parametros = new List<SqlParameter> { pIdProfesional };

            List<Dictionary<string, object>> listaDB = db.ejecutarStoredProcedure(procedimiento, parametros);

            Dictionary<long, string> especialidades = new Dictionary<long, string>();
            foreach (Dictionary<string, object> dic in listaDB)
            {
                especialidades.Add(Convert.ToInt64(dic["id_especialidad"]), (string)dic["descripcion"]);
            }

            return especialidades;
        }


    }
}
