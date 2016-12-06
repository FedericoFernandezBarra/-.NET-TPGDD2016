namespace ClinicaFrba.Registro_Resultado
{
    partial class ConsultarResultadoAtencionForm
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.rtxtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.rtxtSintomas = new System.Windows.Forms.RichTextBox();
            this.lblDatoHora = new System.Windows.Forms.Label();
            this.lblDatoFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDatoAfiliado = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.btnBuscarProfesional = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mcFechaConsulta = new System.Windows.Forms.MonthCalendar();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(464, 442);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(126, 48);
            this.btnVolver.TabIndex = 40;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rtxtDiagnostico
            // 
            this.rtxtDiagnostico.Enabled = false;
            this.rtxtDiagnostico.Location = new System.Drawing.Point(7, 17);
            this.rtxtDiagnostico.MaxLength = 255;
            this.rtxtDiagnostico.Name = "rtxtDiagnostico";
            this.rtxtDiagnostico.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDiagnostico.Size = new System.Drawing.Size(375, 181);
            this.rtxtDiagnostico.TabIndex = 3;
            this.rtxtDiagnostico.Text = "";
            // 
            // rtxtSintomas
            // 
            this.rtxtSintomas.Enabled = false;
            this.rtxtSintomas.Location = new System.Drawing.Point(6, 19);
            this.rtxtSintomas.MaxLength = 255;
            this.rtxtSintomas.Name = "rtxtSintomas";
            this.rtxtSintomas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtSintomas.Size = new System.Drawing.Size(276, 228);
            this.rtxtSintomas.TabIndex = 2;
            this.rtxtSintomas.Text = "";
            // 
            // lblDatoHora
            // 
            this.lblDatoHora.AutoSize = true;
            this.lblDatoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoHora.Location = new System.Drawing.Point(405, 175);
            this.lblDatoHora.Name = "lblDatoHora";
            this.lblDatoHora.Size = new System.Drawing.Size(58, 16);
            this.lblDatoHora.TabIndex = 50;
            this.lblDatoHora.Text = "HH:MM";
            // 
            // lblDatoFecha
            // 
            this.lblDatoFecha.AutoSize = true;
            this.lblDatoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoFecha.Location = new System.Drawing.Point(544, 145);
            this.lblDatoFecha.Name = "lblDatoFecha";
            this.lblDatoFecha.Size = new System.Drawing.Size(104, 16);
            this.lblDatoFecha.TabIndex = 49;
            this.lblDatoFecha.Text = "DD/MM/AAAA";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(340, 175);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(59, 16);
            this.lblHora.TabIndex = 48;
            this.lblHora.Text = "HORA: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(340, 145);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(198, 16);
            this.lblFecha.TabIndex = 47;
            this.lblFecha.Text = "FECHA DE DIAGNÓSTICO: ";
            // 
            // lblDatoAfiliado
            // 
            this.lblDatoAfiliado.AutoSize = true;
            this.lblDatoAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoAfiliado.Location = new System.Drawing.Point(437, 115);
            this.lblDatoAfiliado.Name = "lblDatoAfiliado";
            this.lblDatoAfiliado.Size = new System.Drawing.Size(153, 16);
            this.lblDatoAfiliado.TabIndex = 46;
            this.lblDatoAfiliado.Text = "APELLIDO, NOMBRE";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(340, 115);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(91, 16);
            this.lblPaciente.TabIndex = 45;
            this.lblPaciente.Text = "PACIENTE: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtSintomas);
            this.groupBox2.Location = new System.Drawing.Point(14, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 253);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Síntomas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtDiagnostico);
            this.groupBox1.Location = new System.Drawing.Point(332, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 201);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnóstico";
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacientes.Enabled = false;
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(7, 19);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(375, 21);
            this.cmbPacientes.TabIndex = 4;
            this.cmbPacientes.SelectedIndexChanged += new System.EventHandler(this.cmbPacientes_SelectedIndexChanged);
            // 
            // txtProfesional
            // 
            this.txtProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfesional.Enabled = false;
            this.txtProfesional.Location = new System.Drawing.Point(144, 18);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.ReadOnly = true;
            this.txtProfesional.Size = new System.Drawing.Size(459, 20);
            this.txtProfesional.TabIndex = 38;
            // 
            // btnBuscarProfesional
            // 
            this.btnBuscarProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProfesional.Location = new System.Drawing.Point(620, 15);
            this.btnBuscarProfesional.Name = "btnBuscarProfesional";
            this.btnBuscarProfesional.Size = new System.Drawing.Size(87, 26);
            this.btnBuscarProfesional.TabIndex = 1;
            this.btnBuscarProfesional.Text = "BUSCAR";
            this.btnBuscarProfesional.UseVisualStyleBackColor = true;
            this.btnBuscarProfesional.Visible = false;
            this.btnBuscarProfesional.Click += new System.EventHandler(this.btnBuscarProfesional_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPacientes);
            this.groupBox3.Location = new System.Drawing.Point(332, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 50);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paciente";
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(17, 21);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(121, 16);
            this.lblProfesional.TabIndex = 41;
            this.lblProfesional.Text = "PROFESIONAL: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mcFechaConsulta);
            this.groupBox4.Location = new System.Drawing.Point(45, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 178);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fecha de consulta";
            // 
            // mcFechaConsulta
            // 
            this.mcFechaConsulta.Enabled = false;
            this.mcFechaConsulta.Location = new System.Drawing.Point(0, 16);
            this.mcFechaConsulta.MaxSelectionCount = 1;
            this.mcFechaConsulta.Name = "mcFechaConsulta";
            this.mcFechaConsulta.TabIndex = 52;
            this.mcFechaConsulta.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcFechaConsulta_DateSelected);
            // 
            // ConsultarResultadoAtencionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 502);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDatoHora);
            this.Controls.Add(this.lblDatoFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDatoAfiliado);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.btnBuscarProfesional);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblProfesional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsultarResultadoAtencionForm";
            this.Text = "ConsultarResultadoAtencionForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RichTextBox rtxtDiagnostico;
        private System.Windows.Forms.RichTextBox rtxtSintomas;
        private System.Windows.Forms.Label lblDatoHora;
        private System.Windows.Forms.Label lblDatoFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDatoAfiliado;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.Button btnBuscarProfesional;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MonthCalendar mcFechaConsulta;

    }
}