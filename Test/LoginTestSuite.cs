using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.Otros;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TostadoPersistentKit;

namespace ClinicaFrba.Test
{
    [TestClass]
    public class LoginTestSuite
    {
        private DefaultDatabaseCreator dbCreator = new DefaultDatabaseCreator();

        [TestInitialize()]
        public void Initialize()
        {
            dbCreator.createPersistentDefaultModel(true);
        }

        [TestCleanup()]
        public void CleanUp()
        {
            //dbCreator.dropExistingTables();
        }

        [TestMethod]
        public void loguearUser_userExistente_pasaElLogueo()
        {
            UsuarioRepository repoUsuario = new UsuarioRepository();

            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.nick = "yisus";
            nuevoUsuario.pass = "miracle";
            nuevoUsuario.sexo = 'M';

            //if (repoUsuario.selectByProperty("nick","yisus").Count==0)
            {
                repoUsuario.insert(nuevoUsuario);
            }

            Login login = new Login();

            login.username = nuevoUsuario.nick;
            login.password = nuevoUsuario.pass;

            Assert.IsTrue(login.logueoExitoso());
        }

        [TestMethod]
        public void loguearUser_userNoExistente_noPasaElLogueo()
        {
            UsuarioRepository repoUsuario = new UsuarioRepository();

            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.nick = "";
            nuevoUsuario.pass = "";

            Login login = new Login();

            login.username = nuevoUsuario.nick;
            login.password = nuevoUsuario.pass;

            Assert.IsFalse(login.logueoExitoso());
        }
    }
}
