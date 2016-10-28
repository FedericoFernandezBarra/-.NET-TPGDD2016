using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.AbmRol;
using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Clases.Otros;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Logueo;
using ClinicaFrba.Registrar_Agenta_Medico;
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

        private void tsmCancelaciones_Profesional_Click(object sender, EventArgs e)
        {
            CancelarDiasForm cancelacionProfesional = new CancelarDiasForm();

            Hide();

            cancelacionProfesional.ShowDialog();

            Show();
        }

        private void tsmCancelaciones_Afiliado_Click(object sender, EventArgs e)
        {
            CancelarTurnoForm cancelacionAfiliado = new CancelarTurnoForm();

            Hide();

            cancelacionAfiliado.ShowDialog();

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

            //Esto carga el usuario posta que esta logueado (Ej un Afiliado)
            //menu.cargarDatosDeRol();

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
            RegistrarAgendaForm registrarAgenda = new RegistrarAgendaForm(this, menu.usuario);

            Hide();

            registrarAgenda.ShowDialog();

            Show();
        }
    }
}
