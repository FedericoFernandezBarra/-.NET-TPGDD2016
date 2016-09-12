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
            this.tsmSesion_CerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionDeClinica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCancelaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelaciones_Afiliado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelaciones_Profesional = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionDeAfiliados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAfiliados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCompraDeBonos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPedirTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistroDeLlegada = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmRegistroDeResultados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRecetar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionDeProfesionales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProfesionales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmGestionDeClinica,
            this.tsmGestionDeAfiliados,
            this.tsmGestionDeProfesionales,
            this.tsmAgenda});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1178, 136);
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
            this.tsmSesion_CerrarSesion});
            this.tsmSesion.Name = "tsmSesion";
            this.tsmSesion.Size = new System.Drawing.Size(152, 22);
            this.tsmSesion.Text = "Sesión";
            // 
            // tsmSesion_IniciarSesion
            // 
            this.tsmSesion_IniciarSesion.Name = "tsmSesion_IniciarSesion";
            this.tsmSesion_IniciarSesion.Size = new System.Drawing.Size(152, 22);
            this.tsmSesion_IniciarSesion.Text = "Iniciar sesión";
            this.tsmSesion_IniciarSesion.Click += new System.EventHandler(this.tsmSesion_IniciarSesion_Click);
            // 
            // tsmSesion_CerrarSesion
            // 
            this.tsmSesion_CerrarSesion.Name = "tsmSesion_CerrarSesion";
            this.tsmSesion_CerrarSesion.Size = new System.Drawing.Size(152, 22);
            this.tsmSesion_CerrarSesion.Text = "Cerrar sesión";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(152, 22);
            this.tsmSalir.Text = "Salir";
            // 
            // tsmGestionDeClinica
            // 
            this.tsmGestionDeClinica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPlanes,
            this.toolStripSeparator6,
            this.tsmRoles,
            this.tsmUsuarios,
            this.toolStripSeparator7,
            this.tsmCancelaciones});
            this.tsmGestionDeClinica.Image = ((System.Drawing.Image)(resources.GetObject("tsmGestionDeClinica.Image")));
            this.tsmGestionDeClinica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmGestionDeClinica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmGestionDeClinica.Name = "tsmGestionDeClinica";
            this.tsmGestionDeClinica.Size = new System.Drawing.Size(240, 132);
            this.tsmGestionDeClinica.Text = "Gestión de clínica";
            // 
            // tsmPlanes
            // 
            this.tsmPlanes.Name = "tsmPlanes";
            this.tsmPlanes.Size = new System.Drawing.Size(150, 22);
            this.tsmPlanes.Text = "Planes";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(147, 6);
            // 
            // tsmRoles
            // 
            this.tsmRoles.Name = "tsmRoles";
            this.tsmRoles.Size = new System.Drawing.Size(150, 22);
            this.tsmRoles.Text = "Roles";
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(150, 22);
            this.tsmUsuarios.Text = "Usuarios";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(147, 6);
            // 
            // tsmCancelaciones
            // 
            this.tsmCancelaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCancelaciones_Afiliado,
            this.tsmCancelaciones_Profesional});
            this.tsmCancelaciones.Name = "tsmCancelaciones";
            this.tsmCancelaciones.Size = new System.Drawing.Size(150, 22);
            this.tsmCancelaciones.Text = "Cancelaciones";
            // 
            // tsmCancelaciones_Afiliado
            // 
            this.tsmCancelaciones_Afiliado.Name = "tsmCancelaciones_Afiliado";
            this.tsmCancelaciones_Afiliado.Size = new System.Drawing.Size(133, 22);
            this.tsmCancelaciones_Afiliado.Text = "Afiliado";
            // 
            // tsmCancelaciones_Profesional
            // 
            this.tsmCancelaciones_Profesional.Name = "tsmCancelaciones_Profesional";
            this.tsmCancelaciones_Profesional.Size = new System.Drawing.Size(133, 22);
            this.tsmCancelaciones_Profesional.Text = "Profesional";
            // 
            // tsmGestionDeAfiliados
            // 
            this.tsmGestionDeAfiliados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAfiliados,
            this.toolStripSeparator1,
            this.tsmCompraDeBonos,
            this.tsmPedirTurno,
            this.tsmRegistroDeLlegada,
            this.toolStripSeparator2,
            this.tsmRegistroDeResultados,
            this.tsmRecetar});
            this.tsmGestionDeAfiliados.Image = ((System.Drawing.Image)(resources.GetObject("tsmGestionDeAfiliados.Image")));
            this.tsmGestionDeAfiliados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmGestionDeAfiliados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmGestionDeAfiliados.Name = "tsmGestionDeAfiliados";
            this.tsmGestionDeAfiliados.Size = new System.Drawing.Size(250, 132);
            this.tsmGestionDeAfiliados.Text = "Gestión de afiliados";
            // 
            // tsmAfiliados
            // 
            this.tsmAfiliados.Name = "tsmAfiliados";
            this.tsmAfiliados.Size = new System.Drawing.Size(190, 22);
            this.tsmAfiliados.Text = "Afiliados";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmCompraDeBonos
            // 
            this.tsmCompraDeBonos.Name = "tsmCompraDeBonos";
            this.tsmCompraDeBonos.Size = new System.Drawing.Size(190, 22);
            this.tsmCompraDeBonos.Text = "Compra de bonos";
            // 
            // tsmPedirTurno
            // 
            this.tsmPedirTurno.Name = "tsmPedirTurno";
            this.tsmPedirTurno.Size = new System.Drawing.Size(190, 22);
            this.tsmPedirTurno.Text = "Pedir turno";
            // 
            // tsmRegistroDeLlegada
            // 
            this.tsmRegistroDeLlegada.Name = "tsmRegistroDeLlegada";
            this.tsmRegistroDeLlegada.Size = new System.Drawing.Size(190, 22);
            this.tsmRegistroDeLlegada.Text = "Registro de llegada";
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
            // 
            // tsmRecetar
            // 
            this.tsmRecetar.Name = "tsmRecetar";
            this.tsmRecetar.Size = new System.Drawing.Size(190, 22);
            this.tsmRecetar.Text = "Recetar";
            // 
            // tsmGestionDeProfesionales
            // 
            this.tsmGestionDeProfesionales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProfesionales,
            this.tsmEspecialidades,
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
            this.tsmProfesionales.Name = "tsmProfesionales";
            this.tsmProfesionales.Size = new System.Drawing.Size(180, 22);
            this.tsmProfesionales.Text = "Profesionales";
            // 
            // tsmEspecialidades
            // 
            this.tsmEspecialidades.Name = "tsmEspecialidades";
            this.tsmEspecialidades.Size = new System.Drawing.Size(180, 22);
            this.tsmEspecialidades.Text = "Especialidades Méd.";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
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
            // 
            // tsmAgenda_Registrar
            // 
            this.tsmAgenda_Registrar.Name = "tsmAgenda_Registrar";
            this.tsmAgenda_Registrar.Size = new System.Drawing.Size(125, 22);
            this.tsmAgenda_Registrar.Text = "Registrar";
            // 
            // PaginaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 386);
            this.Controls.Add(this.mnuPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PaginaPrincipalForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem tsmGestionDeClinica;
        private System.Windows.Forms.ToolStripMenuItem tsmPlanes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmRoles;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelaciones_Afiliado;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelaciones_Profesional;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionDeAfiliados;
        private System.Windows.Forms.ToolStripMenuItem tsmAfiliados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmCompraDeBonos;
        private System.Windows.Forms.ToolStripMenuItem tsmPedirTurno;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistroDeLlegada;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistroDeResultados;
        private System.Windows.Forms.ToolStripMenuItem tsmRecetar;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionDeProfesionales;
        private System.Windows.Forms.ToolStripMenuItem tsmProfesionales;
        private System.Windows.Forms.ToolStripMenuItem tsmEspecialidades;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmAgenda;
        private System.Windows.Forms.ToolStripMenuItem tsmAgenda_Consultar;
        private System.Windows.Forms.ToolStripMenuItem tsmAgenda_Registrar;
    }
}

