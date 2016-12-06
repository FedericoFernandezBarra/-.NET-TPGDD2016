namespace ClinicaFrba.Pedir_Turno
{
    partial class PedirTurnoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedirTurnoForm));
            this.mcFechaDeTurno = new System.Windows.Forms.MonthCalendar();
            this.btnBuscarProfesional = new System.Windows.Forms.Button();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarDisponibilidad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarTurno = new System.Windows.Forms.Button();
            this.cmbHorariosDisponibles = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechaElegida = new System.Windows.Forms.Label();
            this.txtAfiliado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarAfiliado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mcFechaDeTurno
            // 
            this.mcFechaDeTurno.Location = new System.Drawing.Point(12, 162);
            this.mcFechaDeTurno.MaxSelectionCount = 1;
            this.mcFechaDeTurno.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.mcFechaDeTurno.Name = "mcFechaDeTurno";
            this.mcFechaDeTurno.ShowTodayCircle = false;
            this.mcFechaDeTurno.TabIndex = 3;
            this.mcFechaDeTurno.TodayDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.mcFechaDeTurno.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFechaDeTurno_DateChanged);
            // 
            // btnBuscarProfesional
            // 
            this.btnBuscarProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProfesional.Enabled = false;
            this.btnBuscarProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProfesional.Location = new System.Drawing.Point(470, 79);
            this.btnBuscarProfesional.Name = "btnBuscarProfesional";
            this.btnBuscarProfesional.Size = new System.Drawing.Size(87, 39);
            this.btnBuscarProfesional.TabIndex = 2;
            this.btnBuscarProfesional.Text = "BUSCAR";
            this.btnBuscarProfesional.UseVisualStyleBackColor = true;
            this.btnBuscarProfesional.Click += new System.EventHandler(this.btnBuscarProfesional_Click);
            // 
            // txtProfesional
            // 
            this.txtProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfesional.Enabled = false;
            this.txtProfesional.Location = new System.Drawing.Point(117, 90);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.ReadOnly = true;
            this.txtProfesional.Size = new System.Drawing.Size(347, 20);
            this.txtProfesional.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "PROFESIONAL";
            // 
            // btnConsultarDisponibilidad
            // 
            this.btnConsultarDisponibilidad.Enabled = false;
            this.btnConsultarDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarDisponibilidad.Location = new System.Drawing.Point(281, 211);
            this.btnConsultarDisponibilidad.Name = "btnConsultarDisponibilidad";
            this.btnConsultarDisponibilidad.Size = new System.Drawing.Size(263, 38);
            this.btnConsultarDisponibilidad.TabIndex = 4;
            this.btnConsultarDisponibilidad.Text = "CONSULTAR DISPONIBILIDAD";
            this.btnConsultarDisponibilidad.UseVisualStyleBackColor = true;
            this.btnConsultarDisponibilidad.Click += new System.EventHandler(this.btnConsultarDisponibilidad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "1) Seleccione el Profesional";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "2) Seleccione la fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "3) Consulte disponibilidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "4) Seleccione un horario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "5) Confirme el turno";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(12, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 38);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarTurno
            // 
            this.btnConfirmarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarTurno.Enabled = false;
            this.btnConfirmarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarTurno.Location = new System.Drawing.Point(438, 342);
            this.btnConfirmarTurno.Name = "btnConfirmarTurno";
            this.btnConfirmarTurno.Size = new System.Drawing.Size(118, 52);
            this.btnConfirmarTurno.TabIndex = 6;
            this.btnConfirmarTurno.Text = "CONFIRMAR TURNO";
            this.btnConfirmarTurno.UseVisualStyleBackColor = true;
            this.btnConfirmarTurno.Click += new System.EventHandler(this.btnConfirmarTurno_Click);
            // 
            // cmbHorariosDisponibles
            // 
            this.cmbHorariosDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorariosDisponibles.Enabled = false;
            this.cmbHorariosDisponibles.FormattingEnabled = true;
            this.cmbHorariosDisponibles.Location = new System.Drawing.Point(323, 303);
            this.cmbHorariosDisponibles.Name = "cmbHorariosDisponibles";
            this.cmbHorariosDisponibles.Size = new System.Drawing.Size(172, 21);
            this.cmbHorariosDisponibles.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha elegida: ";
            // 
            // lblFechaElegida
            // 
            this.lblFechaElegida.AutoSize = true;
            this.lblFechaElegida.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaElegida.Location = new System.Drawing.Point(408, 140);
            this.lblFechaElegida.Name = "lblFechaElegida";
            this.lblFechaElegida.Size = new System.Drawing.Size(117, 19);
            this.lblFechaElegida.TabIndex = 26;
            this.lblFechaElegida.Text = "dd/mm/aaaa";
            // 
            // txtAfiliado
            // 
            this.txtAfiliado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAfiliado.Enabled = false;
            this.txtAfiliado.Location = new System.Drawing.Point(117, 23);
            this.txtAfiliado.Name = "txtAfiliado";
            this.txtAfiliado.ReadOnly = true;
            this.txtAfiliado.Size = new System.Drawing.Size(347, 20);
            this.txtAfiliado.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "AFILIADO";
            // 
            // btnBuscarAfiliado
            // 
            this.btnBuscarAfiliado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAfiliado.Location = new System.Drawing.Point(470, 12);
            this.btnBuscarAfiliado.Name = "btnBuscarAfiliado";
            this.btnBuscarAfiliado.Size = new System.Drawing.Size(87, 39);
            this.btnBuscarAfiliado.TabIndex = 1;
            this.btnBuscarAfiliado.Text = "BUSCAR";
            this.btnBuscarAfiliado.UseVisualStyleBackColor = true;
            this.btnBuscarAfiliado.Visible = false;
            this.btnBuscarAfiliado.Click += new System.EventHandler(this.btnBuscarAfiliado_Click);
            // 
            // PedirTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 399);
            this.Controls.Add(this.btnBuscarAfiliado);
            this.Controls.Add(this.txtAfiliado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFechaElegida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbHorariosDisponibles);
            this.Controls.Add(this.btnConfirmarTurno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultarDisponibilidad);
            this.Controls.Add(this.mcFechaDeTurno);
            this.Controls.Add(this.btnBuscarProfesional);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PedirTurnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedir Turno";
            this.Load += new System.EventHandler(this.ConsultarTurnosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcFechaDeTurno;
        private System.Windows.Forms.Button btnBuscarProfesional;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarDisponibilidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarTurno;
        private System.Windows.Forms.ComboBox cmbHorariosDisponibles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFechaElegida;
        private System.Windows.Forms.TextBox txtAfiliado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarAfiliado;
    }
}