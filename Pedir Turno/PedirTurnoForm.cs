using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class PedirTurnoForm : Form
    {
        private Usuario afiliadoASacarTurno;
        private UsuarioRepository usuarioRepository;

        public PedirTurnoForm()
        {
            InitializeComponent();
            usuarioRepository = new UsuarioRepository();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ConsultarTurnosForm consultarTurnosForm = new ConsultarTurnosForm(afiliadoASacarTurno);
            consultarTurnosForm.ShowDialog();
            Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarAfiliado_Click(object sender, EventArgs e)
        {
            BuscarAfiliadoForm buscarAfiliadoForm = new BuscarAfiliadoForm();

            Hide();

            buscarAfiliadoForm.ShowDialog();

            Show();

            if (buscarAfiliadoForm.seSeleccionoUnAfiliado())
            {
                afiliadoASacarTurno = usuarioRepository.traerUsuarioPorId(buscarAfiliadoForm.getAfiliadoSeleccionado().id);

                txtAfiliado.Text = afiliadoASacarTurno.apellido + " " + afiliadoASacarTurno.nombre;

                btnConfirmar.Enabled = true;
            }
        }
    }
}
