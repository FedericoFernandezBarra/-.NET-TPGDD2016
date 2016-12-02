using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clases.POJOS;
using TostadoPersistentKit;
using ClinicaFrba.Clases.DAOS;

namespace ClinicaFrba.Clases.Otros
{
    public class ComprarBonos
    {
        public string mensajeDeError { get; set; }
        //public Afiliado afiliado { get; set; }
        public Compra compra { get; set; }
        public List<Bono> bonosComprados = new List<Bono>();

        public ComprarBonos()
        {
            compra = new Compra();
            compra.fecha = DataBase.Instance.getDate();
            mensajeDeError = "";
        }

        internal bool compraExitosa()
        {
            if (!cumpleValidaciones())
            {
                return false;
            }

            insertarCompra();

            insertarBonos();

            return true;
        }

        public void cargarMonto()
        {
            compra.monto = compra.comprador.planMedico.precioDeBonoConsulta * compra.cantidad;
        }

        private void insertarBonos()
        {
            BonoRepository repoBono = new BonoRepository();

            for (int i = 0; i < compra.cantidad; i++)
            {
                bonosComprados.Add(repoBono.insertarBono(compra));
            }
        }

        private void insertarCompra()
        {
            (new CompraRepository()).insertarCompra(compra);
        }

        private bool cumpleValidaciones()
        {
            if (compra.comprador==null)
            {
                mensajeDeError = "Debe especificar un comprador";
                return false;
            }
            if (compra.comprador.numeroDeAfiliado==0)
            {
                mensajeDeError = "No puede comprar un afiliado sin nro de afiliado";
                return false;
            }
            if (compra.comprador.bajaLogica)
            {
                mensajeDeError = "No puede comprar un afiliado bloqueado";
                return false;
            }
            if (compra.cantidad==0)
            {
                mensajeDeError = "Debe comprar al menos 1 bono";
                return false;
            }

            return true;
        }
    }
}
