namespace ClinicaFrba.Registro_Resultado
{
    partial class RegistrarResultadoAtencionForm
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
            this.components = new System.ComponentModel.Container();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.rtxtSintomas = new System.Windows.Forms.RichTextBox();
            this.rtxtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarProfesional = new System.Windows.Forms.Button();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.lblDatoAfiliado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDatoFecha = new System.Windows.Forms.Label();
            this.lblDatoHora = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(18, 13);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(121, 16);
            this.lblProfesional.TabIndex = 11;
            this.lblProfesional.Text = "PROFESIONAL: ";
            // 
            // rtxtSintomas
            // 
            this.rtxtSintomas.Enabled = false;
            this.rtxtSintomas.Location = new System.Drawing.Point(6, 19);
            this.rtxtSintomas.MaxLength = 255;
            this.rtxtSintomas.Name = "rtxtSintomas";
            this.rtxtSintomas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtSintomas.Size = new System.Drawing.Size(276, 245);
            this.rtxtSintomas.TabIndex = 3;
            this.rtxtSintomas.Text = "";
            this.rtxtSintomas.TextChanged += new System.EventHandler(this.rtxtSintomas_TextChanged);
            // 
            // rtxtDiagnostico
            // 
            this.rtxtDiagnostico.Enabled = false;
            this.rtxtDiagnostico.Location = new System.Drawing.Point(7, 17);
            this.rtxtDiagnostico.MaxLength = 255;
            this.rtxtDiagnostico.Name = "rtxtDiagnostico";
            this.rtxtDiagnostico.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDiagnostico.Size = new System.Drawing.Size(375, 143);
            this.rtxtDiagnostico.TabIndex = 4;
            this.rtxtDiagnostico.Text = "";
            this.rtxtDiagnostico.TextChanged += new System.EventHandler(this.rtxtDiagnostico_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtDiagnostico);
            this.groupBox1.Location = new System.Drawing.Point(333, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 166);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnóstico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtSintomas);
            this.groupBox2.Location = new System.Drawing.Point(15, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 270);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Síntomas";
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacientes.Enabled = false;
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(6, 19);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(694, 21);
            this.cmbPacientes.TabIndex = 2;
            this.cmbPacientes.SelectedIndexChanged += new System.EventHandler(this.cmbPacientes_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPacientes);
            this.groupBox3.Location = new System.Drawing.Point(15, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 50);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paciente";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(18, 109);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(91, 16);
            this.lblPaciente.TabIndex = 26;
            this.lblPaciente.Text = "PACIENTE: ";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(475, 403);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(126, 48);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(333, 460);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarProfesional
            // 
            this.btnBuscarProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProfesional.Location = new System.Drawing.Point(621, 7);
            this.btnBuscarProfesional.Name = "btnBuscarProfesional";
            this.btnBuscarProfesional.Size = new System.Drawing.Size(87, 26);
            this.btnBuscarProfesional.TabIndex = 1;
            this.btnBuscarProfesional.Text = "BUSCAR";
            this.btnBuscarProfesional.UseVisualStyleBackColor = true;
            this.btnBuscarProfesional.Visible = false;
            this.btnBuscarProfesional.Click += new System.EventHandler(this.btnBuscarProfesional_Click);
            // 
            // txtProfesional
            // 
            this.txtProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfesional.Enabled = false;
            this.txtProfesional.Location = new System.Drawing.Point(145, 10);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.ReadOnly = true;
            this.txtProfesional.Size = new System.Drawing.Size(459, 20);
            this.txtProfesional.TabIndex = 1;
            // 
            // lblDatoAfiliado
            // 
            this.lblDatoAfiliado.AutoSize = true;
            this.lblDatoAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoAfiliado.Location = new System.Drawing.Point(115, 109);
            this.lblDatoAfiliado.Name = "lblDatoAfiliado";
            this.lblDatoAfiliado.Size = new System.Drawing.Size(153, 16);
            this.lblDatoAfiliado.TabIndex = 32;
            this.lblDatoAfiliado.Text = "APELLIDO, NOMBRE";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(18, 139);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(198, 16);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "FECHA DE DIAGNÓSTICO: ";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(18, 169);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(59, 16);
            this.lblHora.TabIndex = 34;
            this.lblHora.Text = "HORA: ";
            // 
            // lblDatoFecha
            // 
            this.lblDatoFecha.AutoSize = true;
            this.lblDatoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoFecha.Location = new System.Drawing.Point(222, 139);
            this.lblDatoFecha.Name = "lblDatoFecha";
            this.lblDatoFecha.Size = new System.Drawing.Size(104, 16);
            this.lblDatoFecha.TabIndex = 36;
            this.lblDatoFecha.Text = "DD/MM/AAAA";
            // 
            // lblDatoHora
            // 
            this.lblDatoHora.AutoSize = true;
            this.lblDatoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoHora.Location = new System.Drawing.Point(83, 169);
            this.lblDatoHora.Name = "lblDatoHora";
            this.lblDatoHora.Size = new System.Drawing.Size(58, 16);
            this.lblDatoHora.TabIndex = 37;
            this.lblDatoHora.Text = "HH:MM";
            // 
            // RegistrarResultadoAtencionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 502);
            this.Controls.Add(this.lblDatoHora);
            this.Controls.Add(this.lblDatoFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDatoAfiliado);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.btnBuscarProfesional);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProfesional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RegistrarResultadoAtencionForm";
            this.Text = "Diagnóstico Médico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.RichTextBox rtxtSintomas;
        private System.Windows.Forms.RichTextBox rtxtDiagnostico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarProfesional;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.Label lblDatoAfiliado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDatoFecha;
        private System.Windows.Forms.Label lblDatoHora;

    }
}