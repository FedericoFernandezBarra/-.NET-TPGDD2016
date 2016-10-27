using ClinicaFrba.Clases.POJOS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TostadoPersistentKit;
using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.Otros;

namespace ClinicaFrba.Test
{
    [TestClass]
    public class ABMAfiliadoTestSuite
    {
        private DefaultDatabaseCreator dbCreator = new DefaultDatabaseCreator();

        [TestInitialize()]
        public void Initialize()
        {
            dbCreator.createPersistentDefaultModel(true);
            DataBase.Instance.executeScript("tostado_tests.sql");
        }

        [TestMethod]
        public void insertarAfiliado_datosCorrectos_afiliadoSeInsertaEnLaDb()
        {
            Afiliado afiliadoCorrecto = crearAfiliadoCorrecto();

            AfiliadoRepository repoAfiliado = new AfiliadoRepository();

            repoAfiliado.insertarAfiliado(afiliadoCorrecto);

            Afiliado afiliadoExistente = repoAfiliado.traerAfiliadoPorId(afiliadoCorrecto.id);

            Assert.IsNotNull(afiliadoExistente);
        }

        [TestMethod]
        public void insertarAfiliado_conConyugeEHijo_afiliadosSeInsertanEnLaDb()
        {
            Afiliado afiliadoConFamilia = crearAfiliadoCorrecto();
            afiliadoConFamilia.cantidadDeHijos = 1;

            AltaAfiliado altaAfliado = new AltaAfiliado();
            altaAfliado.nuevoAfiliado = afiliadoConFamilia;

            altaAfliado.crearConyuge();
            completarConyuge(afiliadoConFamilia.conyuge);

            altaAfliado.crearNuevoHijo();
            completarHijo(afiliadoConFamilia.hijos[0]);

            altaAfliado.guardarAfiliado();

            AfiliadoRepository repoAfiliado = new AfiliadoRepository();

            Afiliado afiliadoPrincipal = repoAfiliado.traerAfiliadoPorId(afiliadoConFamilia.id);
            Afiliado conyuge = repoAfiliado.traerAfiliadoPorId(afiliadoConFamilia.id+1);
            Afiliado hijo = repoAfiliado.traerAfiliadoPorId(afiliadoConFamilia.id+2);

            Assert.IsNotNull(afiliadoPrincipal);
            Assert.IsNotNull(conyuge);
            Assert.IsNotNull(hijo);
        }

        [TestMethod]
        public void modificarAfiliado_modificarPlanSinMotivo_modificacionFallida()
        {
            ModificarAfiliado modificarAfiliado = new ModificarAfiliado();
            modificarAfiliado.afiliado = crearAfiliadoCorrecto();
            modificarAfiliado.planMedicoActual = modificarAfiliado.afiliado.planMedico;

            (new AfiliadoRepository()).insertarAfiliado(modificarAfiliado.afiliado);//Esto esta mal
                                                                                    //se supone que deberia 
                                                                                    //tener insertado un afiliado
            modificarAfiliado.afiliado.planMedico = new PlanMedico();
            modificarAfiliado.afiliado.planMedico.id = modificarAfiliado.planMedicoActual.id + 1;

            Assert.IsFalse(modificarAfiliado.ejecutarModificacionesExitosamente());
        }

        [TestMethod]
        public void modificarAfiliado_modificarPlanConMotivo_modificacionExitosa()
        {
            ModificarAfiliado modificarAfiliado = new ModificarAfiliado();
            modificarAfiliado.afiliado = crearAfiliadoCorrecto();
            modificarAfiliado.planMedicoActual = modificarAfiliado.afiliado.planMedico;

            AfiliadoRepository repoAfiliado = new AfiliadoRepository();

            repoAfiliado.insertarAfiliado(modificarAfiliado.afiliado);

            modificarAfiliado.afiliado.planMedico = new PlanMedico();
            modificarAfiliado.afiliado.planMedico.id = modificarAfiliado.planMedicoActual.id + 1;

            modificarAfiliado.motivo = "Porque puedo";

            bool modificacionExitosa = modificarAfiliado.ejecutarModificacionesExitosamente();

            PlanMedico nuevoPlan = repoAfiliado.traerAfiliadoPorId(modificarAfiliado.afiliado.id).planMedico;

            Assert.IsTrue(modificacionExitosa);
            Assert.AreEqual(modificarAfiliado.afiliado.planMedico.id, nuevoPlan.id);
        }

        [TestMethod]
        public void borrarAfiliado_afiliadoActivo_afiliadoApareceNoActivo()
        {
            BajaAfiliado bajaAfiliado = new BajaAfiliado();
            bajaAfiliado.afiliado = crearAfiliadoCorrecto();
            bajaAfiliado.afiliado.bajaLogica = false;

            AfiliadoRepository repoAfiliado = new AfiliadoRepository();

            repoAfiliado.insertarAfiliado(bajaAfiliado.afiliado);

            bool bajaExitosa = bajaAfiliado.darDeBajaExitosa();

            Afiliado afiliadoDadoDeBaja = repoAfiliado.traerAfiliadoPorId(bajaAfiliado.afiliado.id);

            Assert.IsTrue(bajaExitosa);
            Assert.IsTrue(afiliadoDadoDeBaja.bajaLogica);
        }

        private Afiliado crearAfiliadoCorrecto()
        {
            Afiliado afiliado = new Afiliado();
            afiliado.usuario = new Usuario();

            afiliado.numeroFamiliar = 1;
            afiliado.estadoCivil = new EstadoCivil();
            afiliado.estadoCivil.id = 1;
            afiliado.planMedico = new PlanMedico();
            afiliado.planMedico.id = 1;
            afiliado.usuario.nombre = "yisus";
            afiliado.usuario.apellido = "illuminati";
            afiliado.usuario.tipoDeDocumento = new TipoDocumento();
            afiliado.usuario.tipoDeDocumento.id = 1;
            afiliado.usuario.documento = "666";
            afiliado.usuario.direccion = "heaven 333";
            afiliado.usuario.telefono = "0800-333";
            afiliado.usuario.mail = "yisus_rey_do_mundo@gmail.com";
            afiliado.usuario.sexo = 'M';

            return afiliado;
        }

        private void completarConyuge(Afiliado conyuge)
        {
            conyuge.usuario.nombre = "negra";
            conyuge.usuario.apellido = "illuminati";
            conyuge.usuario.tipoDeDocumento = new TipoDocumento();
            conyuge.usuario.tipoDeDocumento.id = 1;
            conyuge.usuario.documento = "667";
            conyuge.usuario.telefono = "0800-333";
            conyuge.usuario.mail = "vieja@gmail.com";
            conyuge.usuario.sexo = 'F';
        }

        private void completarHijo(Afiliado hijo)
        {
            hijo.usuario.nombre = "negro";
            hijo.usuario.apellido = "illuminati";
            hijo.usuario.tipoDeDocumento = new TipoDocumento();
            hijo.usuario.tipoDeDocumento.id = 1;
            hijo.estadoCivil = new EstadoCivil();
            hijo.estadoCivil.id = 1;
            hijo.usuario.direccion = "heaven 333";
            hijo.usuario.documento = "668";
            hijo.usuario.telefono = "0800-333";
            hijo.usuario.mail = "negro_manco@gmail.com";
            hijo.usuario.sexo = 'M';
        }
    }
}
