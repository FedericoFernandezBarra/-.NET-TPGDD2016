using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Clases.POJOS;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class ConsultarHistorialCambiosForm : Form
    {
        private Afiliado afiliado;

        public ConsultarHistorialCambiosForm()
        {
            InitializeComponent();
        }

        public ConsultarHistorialCambiosForm(Afiliado afiliado)
        {
            this.afiliado = afiliado;
        }
    }
}
