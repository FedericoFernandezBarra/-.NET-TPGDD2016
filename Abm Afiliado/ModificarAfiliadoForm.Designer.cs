namespace ClinicaFrba.Abm_Afiliado
{
    partial class ModificarAfiliadoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHijo = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnConyuge = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbVolver = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstadoCivil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHijo);
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Controls.Add(this.btnConyuge);
            this.groupBox1.Controls.Add(this.lblMotivo);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.cmbPlanes);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.cmbVolver);
            this.groupBox1.Controls.Add(this.cmdAceptar);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDir);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(814, 339);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(180, 112);
            this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(160, 25);
            this.cmbEstadoCivil.TabIndex = 67;
            this.cmbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoCivil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Estado Civil:";
            // 
            // btnHijo
            // 
            this.btnHijo.Enabled = false;
            this.btnHijo.Location = new System.Drawing.Point(543, 219);
            this.btnHijo.Margin = new System.Windows.Forms.Padding(4);
            this.btnHijo.Name = "btnHijo";
            this.btnHijo.Size = new System.Drawing.Size(100, 28);
            this.btnHijo.TabIndex = 65;
            this.btnHijo.Text = "Hijo";
            this.btnHijo.UseVisualStyleBackColor = true;
            this.btnHijo.Click += new System.EventHandler(this.btnHijo_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(180, 164);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(619, 23);
            this.txtMotivo.TabIndex = 65;
            this.txtMotivo.Visible = false;
            // 
            // btnConyuge
            // 
            this.btnConyuge.Enabled = false;
            this.btnConyuge.Location = new System.Drawing.Point(416, 219);
            this.btnConyuge.Margin = new System.Windows.Forms.Padding(4);
            this.btnConyuge.Name = "btnConyuge";
            this.btnConyuge.Size = new System.Drawing.Size(100, 28);
            this.btnConyuge.TabIndex = 64;
            this.btnConyuge.Text = "Conyuge";
            this.btnConyuge.UseVisualStyleBackColor = true;
            this.btnConyuge.Click += new System.EventHandler(this.btnConyuge_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(12, 167);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(136, 17);
            this.lblMotivo.TabIndex = 64;
            this.lblMotivo.Text = "Motivo Cambio Plan:";
            this.lblMotivo.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(165, 224);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(237, 17);
            this.label25.TabIndex = 63;
            this.label25.Text = "¿Desea dar de alta a algún familiar?";
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Location = new System.Drawing.Point(581, 112);
            this.cmbPlanes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(160, 25);
            this.cmbPlanes.TabIndex = 6;
            this.cmbPlanes.SelectedIndexChanged += new System.EventHandler(this.cmbPlanes_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(413, 112);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 17);
            this.label26.TabIndex = 5;
            this.label26.Text = "Plan Medico:";
            // 
            // cmbVolver
            // 
            this.cmbVolver.Location = new System.Drawing.Point(543, 297);
            this.cmbVolver.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(100, 28);
            this.cmbVolver.TabIndex = 60;
            this.cmbVolver.Text = "Volver";
            this.cmbVolver.UseVisualStyleBackColor = true;
            this.cmbVolver.Click += new System.EventHandler(this.cmbVolver_Click);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(217, 297);
            this.cmdAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(100, 28);
            this.cmdAceptar.TabIndex = 57;
            this.cmdAceptar.Text = "Guardar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(581, 74);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(181, 23);
            this.txtMail.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Correo Electrónico:";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(176, 36);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(326, 23);
            this.txtDir.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dirección:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(180, 71);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(181, 23);
            this.txtTel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono:";
            // 
            // ModificarAfiliadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 363);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModificarAfiliadoForm";
            this.Text = "ModificarAfiliadoForm";
            this.Load += new System.EventHandler(this.ModificarAfiliadoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.ComboBox cmbPlanes;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button cmbVolver;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnHijo;
        private System.Windows.Forms.Button btnConyuge;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label label1;
    }
}