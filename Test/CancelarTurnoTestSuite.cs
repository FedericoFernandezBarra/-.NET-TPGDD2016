using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClinicaFrba.Test
{
    [TestClass]
    public class CancelarTurnoTestSuite
    {
        [TestMethod]
        public void cancelarTurnoProfesional_fechasErroneas_cancelacionFalla()
        {
            CancelarDias cancelarProfesional = cancelacionProfesionalStandard();

            cancelarProfesional.fechaInicioCancelacion = cancelarProfesional.fechaInicioCancelacion.AddDays(1);

            Assert.IsFalse(cancelarProfesional.cancelacionExitosa());

            cancelarProfesional.fechaInicioCancelacion = cancelarProfesional.fechaInicioCancelacion.AddDays(-2);

            Assert.IsFalse(cancelarProfesional.cancelacionExitosa());
        }

        [TestMethod]
        public void cancelarTurnoProfesional_sinJustificativo_cancelacionFalla()
        {
            CancelarDias cancelarProfesional = cancelacionProfesionalStandard();

            cancelarProfesional.motivoDeCancelacion = "";

            Assert.IsFalse(cancelarProfesional.cancelacionExitosa());
        }

        [TestMethod]
        public void cancelarTurnoProfesional_noHayTurnoHoy_cancelacionExitosa()
        {
            CancelarDias cancelarProfesional = cancelacionProfesionalStandard();

            Assert.IsFalse(cancelarProfesional.hayTurnoHoy());
            Assert.IsTrue(cancelarProfesional.cancelacionExitosa());
        }

        [TestMethod]
        public void cancelarTurnoProfesional_hayTurnoHoy_cancelacionFallida()
        {
            CancelarDias cancelarProfesional = cancelacionProfesionalStandard();

            //agregarTurnoParaHoy();

            Assert.IsTrue(cancelarProfesional.hayTurnoHoy());
            Assert.IsFalse(cancelarProfesional.cancelacionExitosa());
        }

        [TestMethod]
        public void cancelarTurnoAfiliado_sinJustificativo_cancelacionFalla()
        {
            CancelarTurno cancelarAfiliado = cancelacionAfiliadoStandard();

            cancelarAfiliado.motivoDeCancelacion = "";

            Assert.IsFalse(cancelarAfiliado.cancelacionExitosa());
        }

        [TestMethod]
        public void cancelarTurnoAfiliado_noHayTurnoHoy_cancelacionExitosa()
        {
            CancelarTurno cancelarAfiliado = cancelacionAfiliadoStandard();

            Assert.IsFalse(cancelarAfiliado.hayTurnoHoy());
            Assert.IsTrue(cancelarAfiliado.cancelacionExitosa());
        }

        [TestMethod]
        public void cancelarTurnoAfiliado_hayTurnoHoy_cancelacionFallida()
        {
            CancelarTurno cancelarAfiliado = cancelacionAfiliadoStandard();

            //agregarTurnoParaHoy();
            
            Assert.IsTrue(cancelarAfiliado.hayTurnoHoy());
            Assert.IsFalse(cancelarAfiliado.cancelacionExitosa());
        }

        private CancelarDias cancelacionProfesionalStandard()
        {
            //En alguna parte se tiene que "loguear el porfesional"
            CancelarDias cancelarProfesional = new CancelarDias();
            cancelarProfesional.profesional = new Profesional();
            cancelarProfesional.profesional.id = 1;
            cancelarProfesional.tipoDeCancelacion = new TipoCancelacion();
            cancelarProfesional.tipoDeCancelacion.id = 1;
            cancelarProfesional.motivoDeCancelacion = "Porque si vieja";

            return cancelarProfesional;
        }

        private CancelarTurno cancelacionAfiliadoStandard()
        {
            //En alguna parte se tiene que "loguear el porfesional"
            CancelarTurno cancelarAfiliado = new CancelarTurno();
            cancelarAfiliado.motivoDeCancelacion = "Porque si vieja";
            cancelarAfiliado.afiliado = new Afiliado();
            cancelarAfiliado.afiliado.id = 1;
            cancelarAfiliado.tipoDeCancelacion = new TipoCancelacion();
            cancelarAfiliado.tipoDeCancelacion.id = 1;

            cancelarAfiliado.inicializarListas();

            return cancelarAfiliado;
        }

    }
}
