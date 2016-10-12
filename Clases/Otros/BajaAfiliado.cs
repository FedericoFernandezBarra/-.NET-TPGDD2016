using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Clases.DAOS;

namespace ClinicaFrba.Clases.Otros
{
    public class BajaAfiliado
    {
        public Afiliado afiliado { get; set; }
        private AfiliadoRepository repoAfiliado = new AfiliadoRepository();
        public string mensajeDeError { get; set; }

        public BajaAfiliado()
        {
            mensajeDeError = "";
        }

        internal bool darDeBajaExitosa()
        {
            repoAfiliado.darDeBajaAfiliado(afiliado);
            return true;
        }
    }
}
