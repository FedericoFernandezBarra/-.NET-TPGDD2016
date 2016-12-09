using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    internal class AgendaRepository
    {
        DataBase db = DataBase.Instance;

        public DateTime fechaSistema;

        public AgendaRepository()
        {
            fechaSistema = db.getDate();
        }

        public Agenda traerAgendaDelProfesional(Usuario usuario)
        {
            string procedimiento = "BEMVINDO.sp_agenda_del_profesional";

            SqlParameter pIdProfesional = new SqlParameter("@id_profesional", usuario.id);
            List<SqlParameter> parametros = new List<SqlParameter> { pIdProfesional };

            List<Dictionary<string, object>> listaDB = db.ejecutarStoredProcedure(procedimiento, parametros);

            if (listaDB.Count == 0) return new Agenda(0, usuario.id, db.getDate(), db.getDate(), new List<DiaAgenda>(), TipoAgenda.Nuevo);

            //creo los dias agenda
            List<DiaAgenda> listaDiasAgenda = new List<DiaAgenda>();
            
            DiaAgenda diaAgenda;
            foreach (Dictionary<string, object> dic in listaDB)
            {
                if (listaDiasAgenda.Exists(x=> x.idDiaAgenda == Convert.ToInt64(dic["id_dia_agenda"])))
                {
                    diaAgenda = listaDiasAgenda.Find(x => x.idDiaAgenda == Convert.ToInt64(dic["id_dia_agenda"]));
                    diaAgenda.especialidades.Add((string)dic["descripcion"], Convert.ToInt64(dic["id_especialidad"]));
                }
                else
                {
                    Dictionary<string, long> nuevaEsp = new Dictionary<string, long>();
                    nuevaEsp.Add((string)dic["descripcion"], Convert.ToInt64(dic["id_especialidad"]));

                    diaAgenda = new DiaAgenda(Convert.ToInt64(dic["id_dia_agenda"]), (string)dic["dia"], nuevaEsp, (TimeSpan)dic["horario_inicial"], (TimeSpan)dic["horario_final"]);
                    listaDiasAgenda.Add(diaAgenda);
                }
            }
            
            TipoAgenda tipo = ((DateTime)listaDB[0]["fecha_final"] < db.getDate())? TipoAgenda.Vencido : TipoAgenda.Actual;
            return new Agenda(Convert.ToInt64(listaDB[0]["id_agenda"]), usuario.id, (DateTime)listaDB[0]["fecha_inicial"], (DateTime)listaDB[0]["fecha_final"], listaDiasAgenda, tipo);
        }

        public Dictionary<string, long> traerEspecialidadesDeProfesional(Usuario usuario)
        {
            string procedimiento = "BEMVINDO.sp_nombre_de_especialidades_del_profesional";

            SqlParameter pIdProfesional = new SqlParameter("@id_profesional", usuario.id);
            List<SqlParameter> parametros = new List<SqlParameter> { pIdProfesional };

            List<Dictionary<string, object>> listaDB = db.ejecutarStoredProcedure(procedimiento, parametros);
            if (listaDB.Count == 0) return null;

            Dictionary<string, long> especialidades = new Dictionary<string, long>();
            foreach (Dictionary<string, object> dic in listaDB)
            {
                especialidades.Add((string)dic["descripcion"], Convert.ToInt64(dic["id_especialidad"]));
            }

            return especialidades;
        }

        public void insertarAgenda(Agenda agenda)
        {
            //inserto primero la agenda
            string procAgenda = "BEMVINDO.sp_insertar_nueva_agenda";

            SqlParameter pIdProfesional = new SqlParameter("@id_profesional", agenda.idProfesional);
            SqlParameter pFechaInicial = new SqlParameter("@fecha_inicial", agenda.fecha_inicial);
            SqlParameter pFechaFinal = new SqlParameter("@fecha_final", agenda.fecha_final);
            List<SqlParameter> parametros = new List<SqlParameter> {pIdProfesional, pFechaInicial, pFechaFinal};

            long idAgendaNueva = Convert.ToInt64(db.ejecutarStoredProcedure(procAgenda, parametros)[0]["id_agenda"]);

            //inserto los dias_agendas
            string procDiaAgenda = "BEMVINDO.sp_insertar_nuevo_dia_agenda";

            foreach (DiaAgenda dA in agenda.listaDeDiasAgenda)
            {
                SqlParameter pIdAgenda = new SqlParameter("@id_agenda", idAgendaNueva);
                SqlParameter pDia = new SqlParameter("@dia", dA.nombreDia);
                SqlParameter pHoraIni = new SqlParameter("@hora_inicial", dA.horaInicial);
                SqlParameter pHoraFin = new SqlParameter("@hora_final", dA.horaFinal);
                parametros = new List<SqlParameter> { pIdAgenda, pDia, pHoraIni, pHoraFin };

                long idDiaAgendaNueva = Convert.ToInt64(db.ejecutarStoredProcedure(procDiaAgenda, parametros)[0]["id_dia_agenda"]);

                //inserto las especialidades por diaAgenda
                foreach (var esp in dA.especialidades)
                {
                    string procEspPorDiaAgenda = "BEMVINDO.sp_insertar_especialidad_por_dia_agenda";

                    SqlParameter pEspIdDiaAgenda = new SqlParameter("@id_dia_agenda", idDiaAgendaNueva);
                    SqlParameter pEspIdEspecialidad = new SqlParameter("@especialidad", esp.Value);
                    parametros = new List<SqlParameter> { pEspIdDiaAgenda, pEspIdEspecialidad };

                    db.ejecutarStoredProcedure(procEspPorDiaAgenda, parametros);
                } 
            }
        }

        public Agenda obtenerAgendaDe(Profesional unProfesional, Especialidad enUnaEspecialidad, DateTime enUnaFecha)
        {
            string procedimiento = "BEMVINDO.sp_obtener_agenda_del_profesional_por_especialidad";

            List<SqlParameter> parametros = new List<SqlParameter>();
            db.agregarParametro(parametros, "@profesional", unProfesional.usuario.id);
            db.agregarParametro(parametros, "@especialidad", enUnaEspecialidad.id);
            db.agregarParametro(parametros, "@fecha", enUnaFecha);

            List<Dictionary<string, object>> listaDB = db.ejecutarStoredProcedure(procedimiento, parametros);

            if (listaDB.Count == 0) return null;

            List<DiaAgenda> listaDiasAgenda = new List<DiaAgenda>();

            foreach (Dictionary<string, object> dic in listaDB)
            {
                Dictionary<string, long> nuevaEsp = new Dictionary<string, long>();
                nuevaEsp.Add(enUnaEspecialidad.descripcion, enUnaEspecialidad.id);

                listaDiasAgenda.Add( new DiaAgenda(Convert.ToInt64(dic["id_dia_agenda"]), (string)dic["dia"], nuevaEsp, 
                    (TimeSpan)dic["horario_inicial"], (TimeSpan)dic["horario_final"]));
            }
 
            return new Agenda(Convert.ToInt64(listaDB[0]["id_agenda"]), unProfesional.usuario.id, 
                (DateTime)listaDB[0]["fecha_inicial"], (DateTime)listaDB[0]["fecha_final"], listaDiasAgenda, TipoAgenda.Nuevo);
        }   
    }
}
