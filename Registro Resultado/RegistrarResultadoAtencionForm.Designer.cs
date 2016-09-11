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
            this.gpRecetas = new System.Windows.Forms.GroupBox();
            this.cmdGeneraReceta = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.gpHistoriaClinica = new System.Windows.Forms.GroupBox();
            this.txtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.cmdConfirmarSintomas = new System.Windows.Forms.Button();
            this.txtSintomas = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnConfEsp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            this.gpRecetas.SuspendLayout();
            this.gpHistoriaClinica.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpRecetas
            // 
            this.gpRecetas.Controls.Add(this.cmdGeneraReceta);
            this.gpRecetas.Controls.Add(this.label25);
            this.gpRecetas.Location = new System.Drawing.Point(25, 468);
            this.gpRecetas.Margin = new System.Windows.Forms.Padding(4);
            this.gpRecetas.Name = "gpRecetas";
            this.gpRecetas.Padding = new System.Windows.Forms.Padding(4);
            this.gpRecetas.Size = new System.Drawing.Size(724, 123);
            this.gpRecetas.TabIndex = 10;
            this.gpRecetas.TabStop = false;
            this.gpRecetas.Text = "Recetas Médicas";
            this.gpRecetas.Visible = false;
            // 
            // cmdGeneraReceta
            // 
            this.cmdGeneraReceta.Location = new System.Drawing.Point(295, 76);
            this.cmdGeneraReceta.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGeneraReceta.Name = "cmdGeneraReceta";
            this.cmdGeneraReceta.Size = new System.Drawing.Size(100, 28);
            this.cmdGeneraReceta.TabIndex = 57;
            this.cmdGeneraReceta.Text = "Si";
            this.cmdGeneraReceta.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(260, 36);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(170, 17);
            this.label25.TabIndex = 56;
            this.label25.Text = "¿Desea generar recetas?";
            // 
            // gpHistoriaClinica
            // 
            this.gpHistoriaClinica.Controls.Add(this.txtDiagnostico);
            this.gpHistoriaClinica.Controls.Add(this.cmdConfirmarSintomas);
            this.gpHistoriaClinica.Controls.Add(this.txtSintomas);
            this.gpHistoriaClinica.Controls.Add(this.label5);
            this.gpHistoriaClinica.Controls.Add(this.label4);
            this.gpHistoriaClinica.Location = new System.Drawing.Point(25, 247);
            this.gpHistoriaClinica.Margin = new System.Windows.Forms.Padding(4);
            this.gpHistoriaClinica.Name = "gpHistoriaClinica";
            this.gpHistoriaClinica.Padding = new System.Windows.Forms.Padding(4);
            this.gpHistoriaClinica.Size = new System.Drawing.Size(724, 207);
            this.gpHistoriaClinica.TabIndex = 9;
            this.gpHistoriaClinica.TabStop = false;
            this.gpHistoriaClinica.Text = "Resultado";
            this.gpHistoriaClinica.Visible = false;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(345, 43);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(283, 117);
            this.txtDiagnostico.TabIndex = 12;
            this.txtDiagnostico.Text = "";
            // 
            // cmdConfirmarSintomas
            // 
            this.cmdConfirmarSintomas.Location = new System.Drawing.Point(295, 169);
            this.cmdConfirmarSintomas.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConfirmarSintomas.Name = "cmdConfirmarSintomas";
            this.cmdConfirmarSintomas.Size = new System.Drawing.Size(100, 28);
            this.cmdConfirmarSintomas.TabIndex = 7;
            this.cmdConfirmarSintomas.Text = "Confirmar";
            this.cmdConfirmarSintomas.UseVisualStyleBackColor = true;
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(12, 43);
            this.txtSintomas.Margin = new System.Windows.Forms.Padding(4);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(283, 117);
            this.txtSintomas.TabIndex = 11;
            this.txtSintomas.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diagnóstico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sintomas:";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lbl2);
            this.gbDatos.Controls.Add(this.btnConfEsp);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.cmbEspecialidades);
            this.gbDatos.Controls.Add(this.cmbHora);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.cmdAceptar);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.dtpFechaAtencion);
            this.gbDatos.Location = new System.Drawing.Point(13, 13);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatos.Size = new System.Drawing.Size(736, 226);
            this.gbDatos.TabIndex = 8;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Atención";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(8, 20);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(58, 17);
            this.lbl2.TabIndex = 60;
            this.lbl2.Text = "Afiliado:";
            // 
            // btnConfEsp
            // 
            this.btnConfEsp.Location = new System.Drawing.Point(307, 91);
            this.btnConfEsp.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfEsp.Name = "btnConfEsp";
            this.btnConfEsp.Size = new System.Drawing.Size(100, 28);
            this.btnConfEsp.TabIndex = 59;
            this.btnConfEsp.Text = "Confirmar";
            this.btnConfEsp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Especialidad de la Atención:";
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(276, 58);
            this.cmbEspecialidades.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(160, 24);
            this.cmbEspecialidades.TabIndex = 9;
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(400, 148);
            this.cmbHora.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(160, 24);
            this.cmbHora.TabIndex = 8;
            this.cmbHora.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hora de la Atención:";
            this.label2.Visible = false;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(316, 181);
            this.cmdAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(100, 28);
            this.cmdAceptar.TabIndex = 5;
            this.cmdAceptar.Text = "Confirmar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de la Atención:";
            this.label1.Visible = false;
            // 
            // dtpFechaAtencion
            // 
            this.dtpFechaAtencion.Location = new System.Drawing.Point(85, 149);
            this.dtpFechaAtencion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaAtencion.Name = "dtpFechaAtencion";
            this.dtpFechaAtencion.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaAtencion.TabIndex = 5;
            this.dtpFechaAtencion.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(34, 661);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 17);
            this.lbl1.TabIndex = 59;
            this.lbl1.Text = "Profesional:";
            // 
            // cmdFinalizar
            // 
            this.cmdFinalizar.Location = new System.Drawing.Point(320, 610);
            this.cmdFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.Size = new System.Drawing.Size(100, 28);
            this.cmdFinalizar.TabIndex = 60;
            this.cmdFinalizar.Text = "Finalizar";
            this.cmdFinalizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 687);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmdFinalizar);
            this.Controls.Add(this.gpRecetas);
            this.Controls.Add(this.gpHistoriaClinica);
            this.Controls.Add(this.gbDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpRecetas.ResumeLayout(false);
            this.gpRecetas.PerformLayout();
            this.gpHistoriaClinica.ResumeLayout(false);
            this.gpHistoriaClinica.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpRecetas;
        private System.Windows.Forms.Button cmdGeneraReceta;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox gpHistoriaClinica;
        private System.Windows.Forms.RichTextBox txtDiagnostico;
        private System.Windows.Forms.Button cmdConfirmarSintomas;
        private System.Windows.Forms.RichTextBox txtSintomas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnConfEsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencion;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button cmdFinalizar;
    }
}