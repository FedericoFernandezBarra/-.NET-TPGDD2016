using ClinicaFrba.Clases.POJOS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TostadoPersistentKit;
using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.Otros;

namespace ClinicaFrba.Test
{
    [TestClass]
    public class AltaAfiliadoTestSuite
    {
        private DefaultDatabaseCreator dbCreator = new DefaultDatabaseCreator();

        [TestInitialize()]
        public void Initialize()
        {
            dbCreator.createPersistentDefaultModel(true);
            dbCreator.executeScript("tostado_tests.sql");
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
