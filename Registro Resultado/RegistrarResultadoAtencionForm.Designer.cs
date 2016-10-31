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
            this.dtpFechaTurno = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraDiagnostico = new System.Windows.Forms.DateTimePicker();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpFechaDiagnostico = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(12, 9);
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
            this.rtxtSintomas.Size = new System.Drawing.Size(276, 238);
            this.rtxtSintomas.TabIndex = 14;
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
            this.rtxtDiagnostico.Size = new System.Drawing.Size(375, 118);
            this.rtxtDiagnostico.TabIndex = 15;
            this.rtxtDiagnostico.Text = "";
            this.rtxtDiagnostico.TextChanged += new System.EventHandler(this.rtxtDiagnostico_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtDiagnostico);
            this.groupBox1.Location = new System.Drawing.Point(333, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 148);
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
            // dtpFechaTurno
            // 
            this.dtpFechaTurno.Location = new System.Drawing.Point(31, 19);
            this.dtpFechaTurno.Name = "dtpFechaTurno";
            this.dtpFechaTurno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaTurno.TabIndex = 18;
            this.dtpFechaTurno.ValueChanged += new System.EventHandler(this.dtpFechaTurno_ValueChanged);
            // 
            // dtpHoraDiagnostico
            // 
            this.dtpHoraDiagnostico.CustomFormat = "HH:mm";
            this.dtpHoraDiagnostico.Enabled = false;
            this.dtpHoraDiagnostico.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraDiagnostico.Location = new System.Drawing.Point(17, 20);
            this.dtpHoraDiagnostico.Name = "dtpHoraDiagnostico";
            this.dtpHoraDiagnostico.Size = new System.Drawing.Size(96, 20);
            this.dtpHoraDiagnostico.TabIndex = 19;
            this.dtpHoraDiagnostico.ValueChanged += new System.EventHandler(this.dtpHoraDiagnostico_ValueChanged);
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.Enabled = false;
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(6, 19);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(376, 21);
            this.cmbPacientes.TabIndex = 21;
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
            this.groupBox3.Location = new System.Drawing.Point(333, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 50);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paciente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpFechaTurno);
            this.groupBox4.Location = new System.Drawing.Point(15, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 50);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fecha del Turno";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpFechaDiagnostico);
            this.groupBox5.Location = new System.Drawing.Point(15, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 50);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fecha del Diagnóstico";
            // 
            // dtpFechaDiagnostico
            // 
            this.dtpFechaDiagnostico.Enabled = false;
            this.dtpFechaDiagnostico.Location = new System.Drawing.Point(31, 19);
            this.dtpFechaDiagnostico.Name = "dtpFechaDiagnostico";
            this.dtpFechaDiagnostico.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDiagnostico.TabIndex = 18;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpHoraDiagnostico);
            this.groupBox6.Location = new System.Drawing.Point(340, 140);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(145, 50);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hora del Diagnóstico";
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfiliado.Location = new System.Drawing.Point(12, 107);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(91, 16);
            this.lblAfiliado.TabIndex = 26;
            this.lblAfiliado.Text = "PACIENTE: ";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(474, 387);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(114, 61);
            this.btnConfirmar.TabIndex = 27;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(333, 460);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 30);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RegistrarResultadoAtencionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 502);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblAfiliado);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProfesional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RegistrarResultadoAtencionForm";
            this.Text = "Diagnóstico Médico";
            this.Load += new System.EventHandler(this.RegistrarResultadoAtencionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.RichTextBox rtxtSintomas;
        private System.Windows.Forms.RichTextBox rtxtDiagnostico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaTurno;
        private System.Windows.Forms.DateTimePicker dtpHoraDiagnostico;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpFechaDiagnostico;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;

    }
}