namespace ClinicaFrba
{
    partial class PaginaPrincipalForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipalForm));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSesion_IniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSesion_CerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionDeAfiliados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAfiliados = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.crearModificarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCompraDeBonos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPedirTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistroDeLlegada = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmRegistroDeResultados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionDeProfesionales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProfesionales = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProfesionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgenda_Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgenda_Registrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchivo,
            this.tsmGestionDeAfiliados,
            this.tsmGestionDeProfesionales,
            this.tsmAgenda});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(926, 136);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            this.tsmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSesion,
            this.toolStripSeparator4,
            this.estadísticasToolStripMenuItem,
            this.toolStripSeparator5,
            this.tsmSalir});
            this.tsmArchivo.Image = ((System.Drawing.Image)(resources.GetObject("tsmArchivo.Image")));
            this.tsmArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmArchivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmArchivo.Name = "tsmArchivo";
            this.tsmArchivo.Size = new System.Drawing.Size(188, 132);
            this.tsmArchivo.Text = "Archivo";
            // 
            // tsmSesion
            // 
            this.tsmSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSesion_IniciarSesion,
            this.seleccionarRolToolStripMenuItem,
            this.tsmSesion_CerrarSesion});
            this.tsmSesion.Name = "tsmSesion";
            this.tsmSesion.Size = new System.Drawing.Size(134, 22);
            this.tsmSesion.Text = "Sesión";
            // 
            // tsmSesion_IniciarSesion
            // 
            this.tsmSesion_IniciarSesion.Name = "tsmSesion_IniciarSesion";
            this.tsmSesion_IniciarSesion.Size = new System.Drawing.Size(154, 22);
            this.tsmSesion_IniciarSesion.Text = "Iniciar sesión";
            this.tsmSesion_IniciarSesion.Click += new System.EventHandler(this.tsmSesion_IniciarSesion_Click);
            // 
            // seleccionarRolToolStripMenuItem
            // 
            this.seleccionarRolToolStripMenuItem.Name = "seleccionarRolToolStripMenuItem";
            this.seleccionarRolToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.seleccionarRolToolStripMenuItem.Text = "Seleccionar Rol";
            this.seleccionarRolToolStripMenuItem.Click += new System.EventHandler(this.seleccionarRolToolStripMenuItem_Click);
            // 
            // tsmSesion_CerrarSesion
            // 
            this.tsmSesion_CerrarSesion.Name = "tsmSesion_CerrarSesion";
            this.tsmSesion_CerrarSesion.Size = new System.Drawing.Size(154, 22);
            this.tsmSesion_CerrarSesion.Text = "Cerrar sesión";
            this.tsmSesion_CerrarSesion.Click += new System.EventHandler(this.tsmSesion_CerrarSesion_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(131, 6);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            this.estadísticasToolStripMenuItem.Visible = false;
            this.estadísticasToolStripMenuItem.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(131, 6);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(134, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsmGestionDeAfiliados
            // 
            this.tsmGestionDeAfiliados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAfiliados,
            this.toolStripSeparator1,
            this.tsmRoles,
            this.tsmCompraDeBonos,
            this.tsmPedirTurno,
            this.tsmRegistroDeLlegada,
            this.toolStripSeparator2,
            this.tsmRegistroDeResultados,
            this.tsmCancelaciones});
            this.tsmGestionDeAfiliados.Image = ((System.Drawing.Image)(resources.GetObject("tsmGestionDeAfiliados.Image")));
            this.tsmGestionDeAfiliados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmGestionDeAfiliados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmGestionDeAfiliados.Name = "tsmGestionDeAfiliados";
            this.tsmGestionDeAfiliados.Size = new System.Drawing.Size(250, 132);
            this.tsmGestionDeAfiliados.Text = "Gestión de afiliados";
            // 
            // tsmAfiliados
            // 
            this.tsmAfiliados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAfiliadoToolStripMenuItem,
            this.modificarAfiliadoToolStripMenuItem,
            this.bloquearAfiliadoToolStripMenuItem,
            this.buscarAfiliadoToolStripMenuItem});
            this.tsmAfiliados.Name = "tsmAfiliados";
            this.tsmAfiliados.Size = new System.Drawing.Size(190, 22);
            this.tsmAfiliados.Text = "Afiliados";
            this.tsmAfiliados.Visible = false;
            // 
            // registrarAfiliadoToolStripMenuItem
            // 
            this.registrarAfiliadoToolStripMenuItem.Name = "registrarAfiliadoToolStripMenuItem";
            this.registrarAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.registrarAfiliadoToolStripMenuItem.Text = "Registrar Afiliado";
            this.registrarAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.registrarAfiliadoToolStripMenuItem_Click);
            // 
            // modificarAfiliadoToolStripMenuItem
            // 
            this.modificarAfiliadoToolStripMenuItem.Name = "modificarAfiliadoToolStripMenuItem";
            this.modificarAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.modificarAfiliadoToolStripMenuItem.Text = "Modificar Afiliado";
            this.modificarAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.modificarAfiliadoToolStripMenuItem_Click);
            // 
            // bloquearAfiliadoToolStripMenuItem
            // 
            this.bloquearAfiliadoToolStripMenuItem.Name = "bloquearAfiliadoToolStripMenuItem";
            this.bloquearAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.bloquearAfiliadoToolStripMenuItem.Text = "Bloquear Afiliado";
            this.bloquearAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.bloquearAfiliadoToolStripMenuItem_Click);
            // 
            // buscarAfiliadoToolStripMenuItem
            // 
            this.buscarAfiliadoToolStripMenuItem.Name = "buscarAfiliadoToolStripMenuItem";
            this.buscarAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.buscarAfiliadoToolStripMenuItem.Text = "Consultar Historial de Cambios";
            this.buscarAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.buscarAfiliadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmRoles
            // 
            this.tsmRoles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearModificarRolToolStripMenuItem});
            this.tsmRoles.Name = "tsmRoles";
            this.tsmRoles.Size = new System.Drawing.Size(190, 22);
            this.tsmRoles.Text = "Roles";
            this.tsmRoles.Visible = false;
            // 
            // crearModificarRolToolStripMenuItem
            // 
            this.crearModificarRolToolStripMenuItem.Name = "crearModificarRolToolStripMenuItem";
            this.crearModificarRolToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.crearModificarRolToolStripMenuItem.Text = "Crear/Modificar Rol";
            this.crearModificarRolToolStripMenuItem.Click += new System.EventHandler(this.crearModificarRolToolStripMenuItem_Click);
            // 
            // tsmCompraDeBonos
            // 
            this.tsmCompraDeBonos.Name = "tsmCompraDeBonos";
            this.tsmCompraDeBonos.Size = new System.Drawing.Size(190, 22);
            this.tsmCompraDeBonos.Text = "Compra de bonos";
            this.tsmCompraDeBonos.Visible = false;
            this.tsmCompraDeBonos.Click += new System.EventHandler(this.tsmCompraDeBonos_Click);
            // 
            // tsmPedirTurno
            // 
            this.tsmPedirTurno.Name = "tsmPedirTurno";
            this.tsmPedirTurno.Size = new System.Drawing.Size(190, 22);
            this.tsmPedirTurno.Text = "Pedir turno";
            this.tsmPedirTurno.Visible = false;
            this.tsmPedirTurno.Click += new System.EventHandler(this.tsmPedirTurno_Click);
            // 
            // tsmRegistroDeLlegada
            // 
            this.tsmRegistroDeLlegada.Name = "tsmRegistroDeLlegada";
            this.tsmRegistroDeLlegada.Size = new System.Drawing.Size(190, 22);
            this.tsmRegistroDeLlegada.Text = "Registro de llegada";
            this.tsmRegistroDeLlegada.Visible = false;
            this.tsmRegistroDeLlegada.Click += new System.EventHandler(this.tsmRegistroDeLlegada_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmRegistroDeResultados
            // 
            this.tsmRegistroDeResultados.Name = "tsmRegistroDeResultados";
            this.tsmRegistroDeResultados.Size = new System.Drawing.Size(190, 22);
            this.tsmRegistroDeResultados.Text = "Registro de resultados";
            this.tsmRegistroDeResultados.Visible = false;
            this.tsmRegistroDeResultados.Click += new System.EventHandler(this.tsmRegistroDeResultados_Click);
            // 
            // tsmCancelaciones
            // 
            this.tsmCancelaciones.Name = "tsmCancelaciones";
            this.tsmCancelaciones.Size = new System.Drawing.Size(190, 22);
            this.tsmCancelaciones.Text = "Cancelaciones";
            this.tsmCancelaciones.Visible = false;
            this.tsmCancelaciones.Click += new System.EventHandler(this.tsmCancelaciones_Click);
            // 
            // tsmGestionDeProfesionales
            // 
            this.tsmGestionDeProfesionales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProfesionales,
            this.toolStripSeparator3});
            this.tsmGestionDeProfesionales.Image = ((System.Drawing.Image)(resources.GetObject("tsmGestionDeProfesionales.Image")));
            this.tsmGestionDeProfesionales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmGestionDeProfesionales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmGestionDeProfesionales.Name = "tsmGestionDeProfesionales";
            this.tsmGestionDeProfesionales.Size = new System.Drawing.Size(276, 132);
            this.tsmGestionDeProfesionales.Text = "Gestión de profesionales";
            // 
            // tsmProfesionales
            // 
            this.tsmProfesionales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProfesionalToolStripMenuItem});
            this.tsmProfesionales.Name = "tsmProfesionales";
            this.tsmProfesionales.Size = new System.Drawing.Size(144, 22);
            this.tsmProfesionales.Text = "Profesionales";
            this.tsmProfesionales.Visible = false;
            // 
            // buscarProfesionalToolStripMenuItem
            // 
            this.buscarProfesionalToolStripMenuItem.Name = "buscarProfesionalToolStripMenuItem";
            this.buscarProfesionalToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.buscarProfesionalToolStripMenuItem.Text = "Buscar Profesional";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmAgenda
            // 
            this.tsmAgenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgenda_Consultar,
            this.tsmAgenda_Registrar});
            this.tsmAgenda.Image = ((System.Drawing.Image)(resources.GetObject("tsmAgenda.Image")));
            this.tsmAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmAgenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmAgenda.Name = "tsmAgenda";
            this.tsmAgenda.Size = new System.Drawing.Size(188, 132);
            this.tsmAgenda.Text = "Agenda";
            // 
            // tsmAgenda_Consultar
            // 
            this.tsmAgenda_Consultar.Name = "tsmAgenda_Consultar";
            this.tsmAgenda_Consultar.Size = new System.Drawing.Size(125, 22);
            this.tsmAgenda_Consultar.Text = "Consultar";
            this.tsmAgenda_Consultar.Visible = false;
            // 
            // tsmAgenda_Registrar
            // 
            this.tsmAgenda_Registrar.Name = "tsmAgenda_Registrar";
            this.tsmAgenda_Registrar.Size = new System.Drawing.Size(125, 22);
            this.tsmAgenda_Registrar.Text = "Registrar";
            this.tsmAgenda_Registrar.Visible = false;
            this.tsmAgenda_Registrar.Click += new System.EventHandler(this.tsmAgenda_Registrar_Click);
            // 
            // PaginaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 139);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PaginaPrincipalForm";
            this.Text = "ClinicaFrba";
            this.Load += new System.EventHandler(this.PaginaPrincipalForm_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmSesion_IniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmSesion_CerrarSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionDeAfiliados;
        private System.Windows.Forms.ToolStripMenuItem tsmAfiliados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmCompraDeBonos;
        private System.Windows.Forms.ToolStripMenuItem tsmPedirTurno;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistroDeLlegada;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistroDeResultados;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionDeProfesionales;
        private System.Windows.Forms.ToolStripMenuItem tsmProfesionales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmAgenda;
        private System.Windows.Forms.ToolStripMenuItem tsmAgenda_Consultar;
        private System.Windows.Forms.ToolStripMenuItem tsmAgenda_Registrar;
        private System.Windows.Forms.ToolStripMenuItem seleccionarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProfesionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRoles;
        private System.Windows.Forms.ToolStripMenuItem crearModificarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelaciones;
    }
}

