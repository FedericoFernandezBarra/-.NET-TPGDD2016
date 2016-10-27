using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Clases;
using ClinicaFrba.Registrar_Agenta_Medico;
using System;
using System.Windows.Forms;

namespace ClinicaFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaginaPrincipalForm());
        }
    }
}
