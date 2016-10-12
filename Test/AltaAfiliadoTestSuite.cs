using System;
using ClinicaFrba.Clases.POJOS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TostadoPersistentKit;
using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;

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
    }
}
