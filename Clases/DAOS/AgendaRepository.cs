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

        public DateTime fechaSistema;

        public AgendaRepository()
        {
            fechaSistema = db.getDate();
        }

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
            if (listaDB.Count == 0) return null;

            List<DiaAgenda> listaDiasAgenda = new List<DiaAgenda>();
            foreach (Dictionary<string, object> dic in listaDB)
            {
                DiaAgenda diaAgenda;
                if (dic["id_especialidad"] == DBNull.Value)
                {
                    diaAgenda = new DiaAgenda((string)dic["dia"], 0, "", (TimeSpan)dic["horario_inicial"], (TimeSpan)dic["horario_final"]);
                }
                else
                {
                    diaAgenda = new DiaAgenda((string)dic["dia"], Convert.ToInt64(dic["id_especialidad"]), (string)dic["especialidad"], (TimeSpan)dic["horario_inicial"], (TimeSpan)dic["horario_final"]);
                }
                
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
            if (listaDB.Count == 0) return null;

            Dictionary<long, string> especialidades = new Dictionary<long, string>();
            foreach (Dictionary<string, object> dic in listaDB)
            {
                especialidades.Add(Convert.ToInt64(dic["id_especialidad"]), (string)dic["descripcion"]);
            }

            return especialidades;
        }

        public void insertarAgendaNueva(long idProfesional, DateTime fechaInicial, DateTime fechaFinal, List<DiaAgenda> diasAgenda)
        {
            //inserto primero la agenda
            string procedimiento = "BEMVINDO.sp_insertar_nueva_agenda";

            SqlParameter pIdProfesional = new SqlParameter("@id_profesional", idProfesional);
            SqlParameter pFechaInicial = new SqlParameter("@fecha_inicial", fechaInicial);
            SqlParameter pFechaFinal = new SqlParameter("@fecha_final", fechaFinal);
            List<SqlParameter> parametros = new List<SqlParameter> {pIdProfesional, pFechaInicial, pFechaFinal};

            long idAgendaNueva = Convert.ToInt64(db.ejecutarStoredProcedure(procedimiento, parametros)[0]["id_agenda"]);


            //inserto los dias_agendas
            procedimiento = "BEMVINDO.sp_insertar_nuevo_dia_agenda";

            foreach (DiaAgenda dA in diasAgenda)
            {
                SqlParameter pIdAgenda = new SqlParameter("@id_agenda", idAgendaNueva);
                SqlParameter pIdEspecialidad = new SqlParameter("@id_especialidad", dA.idEspecialidad);
                SqlParameter pDia = new SqlParameter("@dia", dA.nombreDia);
                SqlParameter pHoraIni = new SqlParameter("@hora_inicial", dA.horaInicial);
                SqlParameter pHoraFin = new SqlParameter("@hora_final", dA.horaFinal);
                parametros = new List<SqlParameter> { pIdAgenda, pIdEspecialidad, pDia, pHoraIni, pHoraFin };

                db.ejecutarStoredProcedure(procedimiento, parametros);
            }
        }

        public void insertarNuevosDiasAgenda(Agenda agenda, List<DiaAgenda> diasNuevosAAgregar)
        {
            string procedimiento = "BEMVINDO.sp_insertar_nuevo_dia_agenda";

            foreach (DiaAgenda dA in diasNuevosAAgregar)
            {
                SqlParameter pIdAgenda = new SqlParameter("@id_agenda", agenda.idAgenda);
                SqlParameter pIdEspecialidad = new SqlParameter("@id_especialidad", dA.idEspecialidad);
                SqlParameter pDia = new SqlParameter("@dia", dA.nombreDia);
                SqlParameter pHoraIni = new SqlParameter("@hora_inicial", dA.horaInicial);
                SqlParameter pHoraFin = new SqlParameter("@hora_final", dA.horaFinal);
                List<SqlParameter> parametros = new List<SqlParameter> { pIdAgenda, pIdEspecialidad, pDia, pHoraIni, pHoraFin };

                db.ejecutarStoredProcedure(procedimiento, parametros);
            }
        }

    }
}
