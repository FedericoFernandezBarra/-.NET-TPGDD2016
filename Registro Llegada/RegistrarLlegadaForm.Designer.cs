namespace ClinicaFrba.Registro_Llegada
{
    partial class RegistrarLlegadaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumeroAfiliado = new System.Windows.Forms.Label();
            this.cmdConfirmarBono = new System.Windows.Forms.Button();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.SeleccionTurno = new System.Windows.Forms.GroupBox();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaTurnos = new System.Windows.Forms.DataGridView();
            this.Medico = new System.Windows.Forms.GroupBox();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.cNroAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.SeleccionTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).BeginInit();
            this.Medico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumeroAfiliado);
            this.groupBox2.Controls.Add(this.cmdConfirmarBono);
            this.groupBox2.Controls.Add(this.txtBono);
            this.groupBox2.Location = new System.Drawing.Point(16, 394);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(669, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bono Consulta";
            // 
            // lblNumeroAfiliado
            // 
            this.lblNumeroAfiliado.AutoSize = true;
            this.lblNumeroAfiliado.Location = new System.Drawing.Point(8, 47);
            this.lblNumeroAfiliado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroAfiliado.Name = "lblNumeroAfiliado";
            this.lblNumeroAfiliado.Size = new System.Drawing.Size(174, 17);
            this.lblNumeroAfiliado.TabIndex = 9;
            this.lblNumeroAfiliado.Text = "Ingrese  Numero de Bono:";
            // 
            // cmdConfirmarBono
            // 
            this.cmdConfirmarBono.Enabled = false;
            this.cmdConfirmarBono.Location = new System.Drawing.Point(440, 73);
            this.cmdConfirmarBono.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConfirmarBono.Name = "cmdConfirmarBono";
            this.cmdConfirmarBono.Size = new System.Drawing.Size(188, 28);
            this.cmdConfirmarBono.TabIndex = 7;
            this.cmdConfirmarBono.Text = "Confirmar Bono";
            this.cmdConfirmarBono.UseVisualStyleBackColor = true;
            this.cmdConfirmarBono.Click += new System.EventHandler(this.cmdConfirmarBono_Click);
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(208, 43);
            this.txtBono.Margin = new System.Windows.Forms.Padding(4);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(172, 22);
            this.txtBono.TabIndex = 0;
            this.txtBono.TextChanged += new System.EventHandler(this.txtBono_TextChanged);
            this.txtBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBono_KeyPress);
            // 
            // SeleccionTurno
            // 
            this.SeleccionTurno.Controls.Add(this.txtNroAfiliado);
            this.SeleccionTurno.Controls.Add(this.label1);
            this.SeleccionTurno.Controls.Add(this.grillaTurnos);
            this.SeleccionTurno.Location = new System.Drawing.Point(13, 97);
            this.SeleccionTurno.Margin = new System.Windows.Forms.Padding(4);
            this.SeleccionTurno.Name = "SeleccionTurno";
            this.SeleccionTurno.Padding = new System.Windows.Forms.Padding(4);
            this.SeleccionTurno.Size = new System.Drawing.Size(677, 289);
            this.SeleccionTurno.TabIndex = 8;
            this.SeleccionTurno.TabStop = false;
            this.SeleccionTurno.Text = "Seleccion Turno";
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(236, 30);
            this.txtNroAfiliado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(180, 22);
            this.txtNroAfiliado.TabIndex = 9;
            this.txtNroAfiliado.TextChanged += new System.EventHandler(this.txtNroAfiliado_TextChanged);
            this.txtNroAfiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroAfiliado_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese el Numero de Afiliado:";
            // 
            // grillaTurnos
            // 
            this.grillaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNroAfiliado,
            this.cAfiliado,
            this.cProfesional,
            this.cEspecialidad,
            this.cFecha});
            this.grillaTurnos.Location = new System.Drawing.Point(8, 62);
            this.grillaTurnos.Margin = new System.Windows.Forms.Padding(4);
            this.grillaTurnos.Name = "grillaTurnos";
            this.grillaTurnos.Size = new System.Drawing.Size(661, 220);
            this.grillaTurnos.TabIndex = 0;
            this.grillaTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTurnos_CellClick);
            // 
            // Medico
            // 
            this.Medico.Controls.Add(this.cmdSeleccionar);
            this.Medico.Location = new System.Drawing.Point(13, 14);
            this.Medico.Margin = new System.Windows.Forms.Padding(4);
            this.Medico.Name = "Medico";
            this.Medico.Padding = new System.Windows.Forms.Padding(4);
            this.Medico.Size = new System.Drawing.Size(346, 74);
            this.Medico.TabIndex = 7;
            this.Medico.TabStop = false;
            this.Medico.Text = "Seleccionar Profesional";
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Location = new System.Drawing.Point(56, 23);
            this.cmdSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(197, 28);
            this.cmdSeleccionar.TabIndex = 0;
            this.cmdSeleccionar.Text = "Seleccionar Profesional";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpHoraLlegada);
            this.groupBox1.Location = new System.Drawing.Point(367, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(323, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Hora de llegada";
            // 
            // dtpHoraLlegada
            // 
            this.dtpHoraLlegada.CustomFormat = "HH:mm";
            this.dtpHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraLlegada.Location = new System.Drawing.Point(89, 28);
            this.dtpHoraLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraLlegada.Name = "dtpHoraLlegada";
            this.dtpHoraLlegada.ShowUpDown = true;
            this.dtpHoraLlegada.Size = new System.Drawing.Size(145, 22);
            this.dtpHoraLlegada.TabIndex = 18;
            this.dtpHoraLlegada.ValueChanged += new System.EventHandler(this.dtpHoraLlegada_ValueChanged);
            // 
            // cNroAfiliado
            // 
            this.cNroAfiliado.HeaderText = "Nro de Afiliado";
            this.cNroAfiliado.Name = "cNroAfiliado";
            this.cNroAfiliado.ReadOnly = true;
            // 
            // cAfiliado
            // 
            this.cAfiliado.HeaderText = "Afiliado";
            this.cAfiliado.Name = "cAfiliado";
            this.cAfiliado.ReadOnly = true;
            // 
            // cProfesional
            // 
            this.cProfesional.HeaderText = "Profesional";
            this.cProfesional.Name = "cProfesional";
            this.cProfesional.ReadOnly = true;
            // 
            // cEspecialidad
            // 
            this.cEspecialidad.HeaderText = "Especialidad";
            this.cEspecialidad.Name = "cEspecialidad";
            this.cEspecialidad.ReadOnly = true;
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "Fecha";
            this.cFecha.Name = "cFecha";
            this.cFecha.ReadOnly = true;
            // 
            // RegistrarLlegadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SeleccionTurno);
            this.Controls.Add(this.Medico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrarLlegadaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistrarLlegadaForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SeleccionTurno.ResumeLayout(false);
            this.SeleccionTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).EndInit();
            this.Medico.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumeroAfiliado;
        private System.Windows.Forms.Button cmdConfirmarBono;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.GroupBox SeleccionTurno;
        private System.Windows.Forms.TextBox txtNroAfiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaTurnos;
        private System.Windows.Forms.GroupBox Medico;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNroAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
    }
}