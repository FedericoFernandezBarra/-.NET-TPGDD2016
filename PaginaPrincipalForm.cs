using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.AbmRol;
using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Compra_Bono;
using ClinicaFrba.Listados;
using ClinicaFrba.Logueo;
using ClinicaFrba.Pedir_Turno;
using ClinicaFrba.Registrar_Agenta_Medico;
using ClinicaFrba.Registro_Llegada;
using ClinicaFrba.Registro_Resultado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaFrba
{
    public partial class PaginaPrincipalForm : Form
    {
        private MenuPrincipal menu = new MenuPrincipal();

        private Dictionary<ToolStripMenuItem, string> actions = new Dictionary<ToolStripMenuItem, string>();

        public PaginaPrincipalForm()
        {
            InitializeComponent();
        }

        private void tsmSesion_IniciarSesion_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();

            Hide();

            login.ShowDialog();

            menu.usuario = login.getUsuarioLogueado();

            Show();
        }

        private void PaginaPrincipalForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            actions.Add(tsmSesion, "LOGIN Y SEGURIDAD");
            actions.Add(tsmAfiliados, "ABM AFILIADO");
            actions.Add(tsmRoles, "ABM ROL");
            actions.Add(tsmPedirTurno, "PEDIR TURNO");
            actions.Add(tsmCompraDeBonos, "COMPRA DE BONOS");
            actions.Add(tsmAgenda_Registrar, "REGISTRAR AGENDA DEL MEDICO");
            actions.Add(tsmRegistroDeLlegada, "REGISTRO DE LLEGADA PARA ATENCION MEDICA");
            actions.Add(tsmRegistroDeResultados, "REGISTRO DE RESULTADO PARA ATENCION MEDICA");
            actions.Add(estadísticasToolStripMenuItem, "LISTADO ESTADISTICO");
            actions.Add(tsmCancelaciones, "CANCELAR ATENCION MEDICA");

            initBotones();
        }

        private void initBotones()
        {
            actions.Keys.ToList().ForEach(a => a.Visible = false);
            tsmSesion.Visible = true;
        }

        private void crearModificarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //validar si puede modificar los roles
            AbmRolForm abmRol = new AbmRolForm();

            Hide();
            abmRol.ShowDialog();
            Show();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void seleccionarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!menu.usuarioLogueado())
            {
                MessageBox.Show("Debe loguearse antes de seleccionar un rol");
                return;
            }

            SeleccionDeRolForm seleccionDeRol = new SeleccionDeRolForm(menu.usuario);

            Hide();

            seleccionDeRol.ShowDialog();

            menu.rol = seleccionDeRol.getRolSeleccionado();

            menu.cargarDatosDeRol();

            cargarFormSegunRol();

            Show();
        }

        private void cargarFormSegunRol()
        {
            actions.Keys.ToList().ForEach(a => a.Visible = false);

            List<ToolStripMenuItem> accionesPermitidas = actions.Keys.ToList().FindAll(a => menu.usuarioPuedeUsar(actions[a]));

            accionesPermitidas.ForEach(a => a.Visible = true);
        }

        private void tsmSesion_CerrarSesion_Click(object sender, EventArgs e)
        {
            menu.cerrarSesion();
            initBotones();
            MessageBox.Show("Sesion cerrada");
        }

        private void registrarAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAfiliadoForm altaAfiliado = new AltaAfiliadoForm();

            Hide();

            altaAfiliado.ShowDialog();

            Show();
        }

        private void modificarAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAfiliadoForm buscarAfiliado = new BuscarAfiliadoForm();

            Hide();

            buscarAfiliado.ShowDialog();

            Afiliado afiliado = buscarAfiliado.getAfiliadoSeleccionado();

            if (!buscarAfiliado.seSeleccionoUnAfiliado())
            {
                Show();
                return;
            }

            ModificarAfiliadoForm modificarAfiliado = new ModificarAfiliadoForm(afiliado);

            modificarAfiliado.ShowDialog();

            Show();
        }

        private void bloquearAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAfiliadoForm buscarAfiliado = new BuscarAfiliadoForm();

            Hide();

            buscarAfiliado.ShowDialog();

            Afiliado afiliado = buscarAfiliado.getAfiliadoSeleccionado();

            if (!buscarAfiliado.seSeleccionoUnAfiliado())
            {
                Show();
                return;
            }

            BajaAfiliadoForm bajaAfiliado = new BajaAfiliadoForm(afiliado);

            bajaAfiliado.ShowDialog();

            Show();
        }

        private void crearModificarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmRolForm abmRol = new AbmRolForm();

            Hide();

            abmRol.ShowDialog();

            Show();
        }

        private void tsmAgenda_Registrar_Click(object sender, EventArgs e)
        {
            RegistrarAgendaForm registrarAgenda = new RegistrarAgendaForm(/*this, */menu.usuario);

            Hide();

            registrarAgenda.ShowDialog();

            Show();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoEstadisticoForm listadoEstadistico = new ListadoEstadisticoForm();

            Hide();

            listadoEstadistico.ShowDialog();

            Show();
        }

        private void tsmCompraDeBonos_Click(object sender, EventArgs e)
        {
            Hide();

            Afiliado afiliado;

            if (!menu.userEsAfiliado())
            {
                BuscarAfiliadoForm buscarAfiliado = new BuscarAfiliadoForm();

                buscarAfiliado.ShowDialog();

                afiliado = buscarAfiliado.getAfiliadoSeleccionado();

                if (!buscarAfiliado.seSeleccionoUnAfiliado())
                {
                    Show();
                    return;
                }
            }
            else
            {
                afiliado = (Afiliado)menu.usuarioPosta;
            }

            ComprarBonosForm comprarBono = new ComprarBonosForm(afiliado);

            comprarBono.ShowDialog();

            Show();
        }

        private void tsmPedirTurno_Click(object sender, EventArgs e)
        {
            ConsultarTurnosForm pedirTurno = new ConsultarTurnosForm(menu.usuario);

            Hide();

            pedirTurno.ShowDialog();

            Show();
        }

        private void tsmRegistroDeLlegada_Click(object sender, EventArgs e)
        {
            RegistrarLlegadaForm registrarLlegada = new RegistrarLlegadaForm();

            Hide();

            registrarLlegada.ShowDialog();

            Show();
        }

        private void tsmRegistroDeResultados_Click(object sender, EventArgs e)
        {
            RegistrarResultadoAtencionForm registrarResultado = new RegistrarResultadoAtencionForm();

            Hide();

            registrarResultado.ShowDialog();

            Show();
        }

        private void tsmCancelaciones_Click(object sender, EventArgs e)
        {
            Form cancelacion = getFormDeCancelacion();

            Hide();

            cancelacion.ShowDialog();

            Show();
        }

        internal Form getFormDeCancelacion()
        {
            if (menu.userEsAfiliado())
            {
                return new CancelarTurnoForm((Afiliado)menu.usuarioPosta);
            }
            if (menu.userEsProfesional())
            {
                return new CancelarDiasForm((Profesional)menu.usuarioPosta);
            }

            return new Form();
        }

        private void buscarAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAfiliadoForm buscarAfiliado = new BuscarAfiliadoForm();

            Hide();

            buscarAfiliado.ShowDialog();

            Afiliado afiliado = buscarAfiliado.getAfiliadoSeleccionado();

            if (!buscarAfiliado.seSeleccionoUnAfiliado())
            {
                Show();
                return;
            }

            ConsultarHistorialCambiosForm consultarHistorial = new ConsultarHistorialCambiosForm(afiliado);

            consultarHistorial.ShowDialog();

            Show();
        }

        private void buscarAfiliadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarAfiliadoForm buscarAfiliado = new BuscarAfiliadoForm();

            Hide();

            buscarAfiliado.ShowDialog();

            Show();
        }
    }
}
