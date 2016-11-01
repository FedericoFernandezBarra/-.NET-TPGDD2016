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
            this.groupBox2.SuspendLayout();
            this.SeleccionTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).BeginInit();
            this.Medico.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumeroAfiliado);
            this.groupBox2.Controls.Add(this.cmdConfirmarBono);
            this.groupBox2.Controls.Add(this.txtBono);
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bono Consulta";
            // 
            // lblNumeroAfiliado
            // 
            this.lblNumeroAfiliado.AutoSize = true;
            this.lblNumeroAfiliado.Location = new System.Drawing.Point(6, 38);
            this.lblNumeroAfiliado.Name = "lblNumeroAfiliado";
            this.lblNumeroAfiliado.Size = new System.Drawing.Size(131, 13);
            this.lblNumeroAfiliado.TabIndex = 9;
            this.lblNumeroAfiliado.Text = "Ingrese  Numero de Bono:";
            // 
            // cmdConfirmarBono
            // 
            this.cmdConfirmarBono.Enabled = false;
            this.cmdConfirmarBono.Location = new System.Drawing.Point(330, 59);
            this.cmdConfirmarBono.Name = "cmdConfirmarBono";
            this.cmdConfirmarBono.Size = new System.Drawing.Size(141, 23);
            this.cmdConfirmarBono.TabIndex = 7;
            this.cmdConfirmarBono.Text = "Confirmar Bono";
            this.cmdConfirmarBono.UseVisualStyleBackColor = true;
            this.cmdConfirmarBono.Click += new System.EventHandler(this.cmdConfirmarBono_Click);
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(156, 35);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(130, 20);
            this.txtBono.TabIndex = 0;
            // 
            // SeleccionTurno
            // 
            this.SeleccionTurno.Controls.Add(this.txtNroAfiliado);
            this.SeleccionTurno.Controls.Add(this.label1);
            this.SeleccionTurno.Controls.Add(this.grillaTurnos);
            this.SeleccionTurno.Location = new System.Drawing.Point(10, 79);
            this.SeleccionTurno.Name = "SeleccionTurno";
            this.SeleccionTurno.Size = new System.Drawing.Size(508, 235);
            this.SeleccionTurno.TabIndex = 8;
            this.SeleccionTurno.TabStop = false;
            this.SeleccionTurno.Text = "Seleccion Turno";
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(177, 24);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(136, 20);
            this.txtNroAfiliado.TabIndex = 9;
            this.txtNroAfiliado.TextChanged += new System.EventHandler(this.txtNroAfiliado_TextChanged);
            this.txtNroAfiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroAfiliado_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese el Numero de Afiliado:";
            // 
            // grillaTurnos
            // 
            this.grillaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTurnos.Location = new System.Drawing.Point(6, 50);
            this.grillaTurnos.Name = "grillaTurnos";
            this.grillaTurnos.Size = new System.Drawing.Size(496, 179);
            this.grillaTurnos.TabIndex = 0;
            this.grillaTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTurnos_CellClick);
            // 
            // Medico
            // 
            this.Medico.Controls.Add(this.cmdSeleccionar);
            this.Medico.Location = new System.Drawing.Point(10, 11);
            this.Medico.Name = "Medico";
            this.Medico.Size = new System.Drawing.Size(508, 60);
            this.Medico.TabIndex = 7;
            this.Medico.TabStop = false;
            this.Medico.Text = "Seleccionar Profesional";
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Location = new System.Drawing.Point(140, 19);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(148, 23);
            this.cmdSeleccionar.TabIndex = 0;
            this.cmdSeleccionar.Text = "Seleccionar Profesional";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // RegistrarLlegadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SeleccionTurno);
            this.Controls.Add(this.Medico);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarLlegadaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistrarLlegadaForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SeleccionTurno.ResumeLayout(false);
            this.SeleccionTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).EndInit();
            this.Medico.ResumeLayout(false);
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
    }
}