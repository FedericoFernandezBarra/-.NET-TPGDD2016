using ClinicaFrba.Clases.Otros;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

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

            cancelarProfesional.motiovoDeCancelacion = "";

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

        private CancelarDias cancelacionProfesionalStandard()
        {
            //En alguna parte se tiene que "loguear el porfesional"
            CancelarDias cancelarProfesional = new CancelarDias();
            cancelarProfesional.motiovoDeCancelacion = "Porque si vieja";

            return cancelarProfesional;
        }

    }
}
