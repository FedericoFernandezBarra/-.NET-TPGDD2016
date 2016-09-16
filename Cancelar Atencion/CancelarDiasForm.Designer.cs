namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarDiasForm
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
            this.lblProfesional = new System.Windows.Forms.Label();
            this.fechaFinCancelacion = new System.Windows.Forms.DateTimePicker();
            this.lbl26 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.cmbCancelacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.fechaInicioCancelacion = new System.Windows.Forms.DateTimePicker();
            this.cmdRango = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(10, 218);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(62, 13);
            this.lblProfesional.TabIndex = 42;
            this.lblProfesional.Text = "Profesional:";
            // 
            // fechaFinCancelacion
            // 
            this.fechaFinCancelacion.Location = new System.Drawing.Point(7, 101);
            this.fechaFinCancelacion.Name = "fechaFinCancelacion";
            this.fechaFinCancelacion.Size = new System.Drawing.Size(215, 20);
            this.fechaFinCancelacion.TabIndex = 41;
            // 
            // lbl26
            // 
            this.lbl26.AutoSize = true;
            this.lbl26.Location = new System.Drawing.Point(7, 84);
            this.lbl26.Name = "lbl26";
            this.lbl26.Size = new System.Drawing.Size(134, 13);
            this.lbl26.TabIndex = 40;
            this.lbl26.Text = "Seleccione Dia Fin Rango:";
            this.lbl26.Visible = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(110, 171);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(246, 20);
            this.txtMotivo.TabIndex = 39;
            // 
            // cmbCancelacion
            // 
            this.cmbCancelacion.FormattingEnabled = true;
            this.cmbCancelacion.Location = new System.Drawing.Point(110, 145);
            this.cmbCancelacion.Name = "cmbCancelacion";
            this.cmbCancelacion.Size = new System.Drawing.Size(121, 21);
            this.cmbCancelacion.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tipo Cancelacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Motivo";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(362, 197);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 34);
            this.btnAction.TabIndex = 35;
            this.btnAction.Text = "Confirmar";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // fechaInicioCancelacion
            // 
            this.fechaInicioCancelacion.Location = new System.Drawing.Point(10, 24);
            this.fechaInicioCancelacion.Name = "fechaInicioCancelacion";
            this.fechaInicioCancelacion.Size = new System.Drawing.Size(215, 20);
            this.fechaInicioCancelacion.TabIndex = 34;
            // 
            // cmdRango
            // 
            this.cmdRango.Location = new System.Drawing.Point(10, 50);
            this.cmdRango.Name = "cmdRango";
            this.cmdRango.Size = new System.Drawing.Size(100, 23);
            this.cmdRango.TabIndex = 33;
            this.cmdRango.Text = "Definir Rango";
            this.cmdRango.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Seleccione Dia a Cancelar:";
            // 
            // CancelarDiasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 244);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.fechaFinCancelacion);
            this.Controls.Add(this.lbl26);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.cmbCancelacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.fechaInicioCancelacion);
            this.Controls.Add(this.cmdRango);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CancelarDiasForm";
            this.Text = "CancelarDiasForm";
            this.Load += new System.EventHandler(this.CancelarDiasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.DateTimePicker fechaFinCancelacion;
        private System.Windows.Forms.Label lbl26;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.ComboBox cmbCancelacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.DateTimePicker fechaInicioCancelacion;
        private System.Windows.Forms.Button cmdRango;
        private System.Windows.Forms.Label label5;
    }
}