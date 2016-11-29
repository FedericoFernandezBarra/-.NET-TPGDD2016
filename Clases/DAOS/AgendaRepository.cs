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
            string procedimiento = "BEMVINDO.sp_agenda_deL_profesional";

            SqlParameter pIdProfesional = new SqlParameter("@id_profesional", usuario.id);
            List<SqlParameter> parametros = new List<SqlParameter> { pIdProfesional };

            List<Dictionary<string, object>> listaDB = db.ejecutarStoredProcedure(procedimiento, parametros);

            if (listaDB.Count == 0) return new Agenda(0, usuario.id, db.getDate(), db.getDate(), new List<DiaAgenda>(), TipoAgenda.Nuevo);
                        
            //creo los dias agenda
            List<DiaAgenda> listaDiasAgenda = new List<DiaAgenda>();
            foreach (Dictionary<string, object> dic in listaDB)
            {
                DiaAgenda diaAgenda;

                string especialidadDia = (dic["id_especialidad"] == DBNull.Value) ? "TODAS LAS DEL PROFESIONAL" : (string)dic["especialidad"];
                long idEspecialidadDia = (dic["id_especialidad"] == DBNull.Value) ? 0 : Convert.ToInt64(dic["id_especialidad"]);

                diaAgenda = new DiaAgenda(Convert.ToInt64(dic["id_dia_agenda"]), (string)dic["dia"], idEspecialidadDia, especialidadDia, (TimeSpan)dic["horario_inicial"], (TimeSpan)dic["horario_final"], TipoDiaAgenda.Migrado);
                listaDiasAgenda.Add(diaAgenda);
            }

            //valido para crear la agenda final
            TipoAgenda tipo;
            DateTime fechaInicial;
            DateTime fechaFinal;

            if (listaDB[0]["fecha_inicial"] == DBNull.Value && listaDB[0]["fecha_final"] == DBNull.Value) {
                tipo = TipoAgenda.PrimeraVez;
                fechaInicial = db.getDate();
                fechaFinal = db.getDate();
            }
            else
            {
                tipo = TipoAgenda.Migrado;
                fechaInicial = (DateTime)listaDB[0]["fecha_inicial"];
                fechaFinal = (DateTime)listaDB[0]["fecha_final"];
            }

            return new Agenda(Convert.ToInt64(listaDB[0]["id_agenda"]), usuario.id, fechaInicial, fechaFinal, listaDiasAgenda, tipo);
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


        public void guardarAgenda(Agenda agenda)
        {
            switch (agenda.tipoAgenda)
            {
                case TipoAgenda.Nuevo:
                    insertarAgendaNueva(agenda);
                    break;

                case TipoAgenda.PrimeraVez:
                    actualizarFechasAgenda(agenda);
                    insertarAgendaMigrada(agenda);
                    break;

                case TipoAgenda.Migrado:
                    insertarAgendaMigrada(agenda);
                    break;

                default:
                    break;
            }
        }

        public void insertarAgendaNueva(Agenda agenda)
        {
            //inserto primero la agenda
            string procedimiento = "BEMVINDO.sp_insertar_nueva_agenda";

            SqlParameter pIdProfesional = new SqlParameter("@id_profesional", agenda.idProfesional);
            SqlParameter pFechaInicial = new SqlParameter("@fecha_inicial", agenda.fecha_inicial);
            SqlParameter pFechaFinal = new SqlParameter("@fecha_final", agenda.fecha_final);
            List<SqlParameter> parametros = new List<SqlParameter> {pIdProfesional, pFechaInicial, pFechaFinal};

            long idAgendaNueva = Convert.ToInt64(db.ejecutarStoredProcedure(procedimiento, parametros)[0]["id_agenda"]);

            //inserto los dias_agendas
            procedimiento = "BEMVINDO.sp_insertar_nuevo_dia_agenda";

            foreach (DiaAgenda dA in agenda.diasAgendaNuevas())
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

        public void insertarAgendaMigrada(Agenda agenda)
        {
            //elimino los dias agenda borrados
            eliminarDiasAgendaBorrados(agenda);

            //inserto los dias agenda nuevos
            string procedimiento = "BEMVINDO.sp_insertar_nuevo_dia_agenda";

            foreach (DiaAgenda dA in agenda.diasAgendaNuevas())
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

        public void eliminarDiasAgendaBorrados(Agenda agenda)
        {
            string procedimiento = "BEMVINDO.sp_eliminar_dia_agenda_por_id";

            foreach (DiaAgenda dA in agenda.diasAgendaBorradasConId0())
            {
                SqlParameter pIdDiaAgenda = new SqlParameter("@id_dia_agenda", dA.idDiaAgenda);
                List<SqlParameter> parametros = new List<SqlParameter> { pIdDiaAgenda };

                db.ejecutarStoredProcedure(procedimiento, parametros);
            }
        }

        public void actualizarFechasAgenda(Agenda agenda)
        {
            string procedimiento = "BEMVINDO.sp_actualizar_fechas_agenda";

            SqlParameter pIdDiaAgenda = new SqlParameter("@id_agenda", agenda.idAgenda);
            SqlParameter pfechaInicial = new SqlParameter("@fecha_inicial", agenda.fecha_inicial);
            SqlParameter pfechaFinal = new SqlParameter("@fecha_final", agenda.fecha_final);
            List<SqlParameter> parametros = new List<SqlParameter> { pIdDiaAgenda, pfechaInicial, pfechaFinal };

            db.ejecutarStoredProcedure(procedimiento, parametros);
        }

    }
}
