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
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(8, 242);
            this.lblProfesional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(83, 17);
            this.lblProfesional.TabIndex = 42;
            this.lblProfesional.Text = "Profesional:";
            // 
            // fechaFinCancelacion
            // 
            this.fechaFinCancelacion.Location = new System.Drawing.Point(10, 91);
            this.fechaFinCancelacion.Margin = new System.Windows.Forms.Padding(4);
            this.fechaFinCancelacion.Name = "fechaFinCancelacion";
            this.fechaFinCancelacion.Size = new System.Drawing.Size(285, 22);
            this.fechaFinCancelacion.TabIndex = 41;
            // 
            // lbl26
            // 
            this.lbl26.AutoSize = true;
            this.lbl26.Location = new System.Drawing.Point(10, 70);
            this.lbl26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl26.Name = "lbl26";
            this.lbl26.Size = new System.Drawing.Size(175, 17);
            this.lbl26.TabIndex = 40;
            this.lbl26.Text = "Seleccione Dia Fin Rango:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(144, 167);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(327, 22);
            this.txtMotivo.TabIndex = 39;
            // 
            // cmbCancelacion
            // 
            this.cmbCancelacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCancelacion.FormattingEnabled = true;
            this.cmbCancelacion.Location = new System.Drawing.Point(144, 135);
            this.cmbCancelacion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCancelacion.Name = "cmbCancelacion";
            this.cmbCancelacion.Size = new System.Drawing.Size(160, 24);
            this.cmbCancelacion.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tipo Cancelacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Motivo";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(371, 230);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(100, 42);
            this.btnAction.TabIndex = 35;
            this.btnAction.Text = "Confirmar";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // fechaInicioCancelacion
            // 
            this.fechaInicioCancelacion.Location = new System.Drawing.Point(13, 30);
            this.fechaInicioCancelacion.Margin = new System.Windows.Forms.Padding(4);
            this.fechaInicioCancelacion.Name = "fechaInicioCancelacion";
            this.fechaInicioCancelacion.Size = new System.Drawing.Size(285, 22);
            this.fechaInicioCancelacion.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Seleccione Dia Inicio Rango:";
            // 
            // CancelarDiasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 285);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.fechaFinCancelacion);
            this.Controls.Add(this.lbl26);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.cmbCancelacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.fechaInicioCancelacion);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label5;
    }
}