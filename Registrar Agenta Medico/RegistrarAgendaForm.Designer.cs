namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class RegistrarAgendaForm
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
            this.botonGuardarCambios = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxEspecialidades = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.listBoxDias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxHorarios = new System.Windows.Forms.ListBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.timeHoraDesde = new System.Windows.Forms.DateTimePicker();
            this.timeHoraHasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.timerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonGuardarCambios
            // 
            this.botonGuardarCambios.Location = new System.Drawing.Point(115, 385);
            this.botonGuardarCambios.Name = "botonGuardarCambios";
            this.botonGuardarCambios.Size = new System.Drawing.Size(100, 23);
            this.botonGuardarCambios.TabIndex = 13;
            this.botonGuardarCambios.Text = "Guardar Cambios";
            this.botonGuardarCambios.UseVisualStyleBackColor = true;
            this.botonGuardarCambios.Click += new System.EventHandler(this.botonGuardarCambios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeHoraHasta);
            this.groupBox1.Controls.Add(this.timeHoraDesde);
            this.groupBox1.Controls.Add(this.listBoxEspecialidades);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.botonAgregar);
            this.groupBox1.Location = new System.Drawing.Point(21, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 118);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Horarios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBoxEspecialidades
            // 
            this.listBoxEspecialidades.FormattingEnabled = true;
            this.listBoxEspecialidades.Location = new System.Drawing.Point(322, 47);
            this.listBoxEspecialidades.Name = "listBoxEspecialidades";
            this.listBoxEspecialidades.Size = new System.Drawing.Size(110, 21);
            this.listBoxEspecialidades.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Especialidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hora Desde:";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(357, 89);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 0;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // listBoxDias
            // 
            this.listBoxDias.FormattingEnabled = true;
            this.listBoxDias.Location = new System.Drawing.Point(21, 52);
            this.listBoxDias.Name = "listBoxDias";
            this.listBoxDias.Size = new System.Drawing.Size(121, 21);
            this.listBoxDias.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Día:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(138, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del Profesional:";
            // 
            // listBoxHorarios
            // 
            this.listBoxHorarios.FormattingEnabled = true;
            this.listBoxHorarios.Location = new System.Drawing.Point(21, 93);
            this.listBoxHorarios.Name = "listBoxHorarios";
            this.listBoxHorarios.Size = new System.Drawing.Size(449, 147);
            this.listBoxHorarios.TabIndex = 15;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(279, 385);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(100, 23);
            this.botonVolver.TabIndex = 16;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // timeHoraDesde
            // 
            this.timeHoraDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoraDesde.Location = new System.Drawing.Point(6, 48);
            this.timeHoraDesde.Name = "timeHoraDesde";
            this.timeHoraDesde.ShowUpDown = true;
            this.timeHoraDesde.Size = new System.Drawing.Size(110, 20);
            this.timeHoraDesde.TabIndex = 17;
            // 
            // timeHoraHasta
            // 
            this.timeHoraHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoraHasta.Location = new System.Drawing.Point(169, 48);
            this.timeHoraHasta.Name = "timeHoraHasta";
            this.timeHoraHasta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeHoraHasta.ShowUpDown = true;
            this.timeHoraHasta.Size = new System.Drawing.Size(110, 20);
            this.timeHoraHasta.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha Hasta:";
            // 
            // timerFechaDesde
            // 
            this.timerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timerFechaDesde.Location = new System.Drawing.Point(190, 53);
            this.timerFechaDesde.Name = "timerFechaDesde";
            this.timerFechaDesde.Size = new System.Drawing.Size(110, 20);
            this.timerFechaDesde.TabIndex = 23;
            // 
            // timerFechaHasta
            // 
            this.timerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timerFechaHasta.Location = new System.Drawing.Point(343, 52);
            this.timerFechaHasta.Name = "timerFechaHasta";
            this.timerFechaHasta.Size = new System.Drawing.Size(110, 20);
            this.timerFechaHasta.TabIndex = 24;
            // 
            // RegistrarAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 431);
            this.Controls.Add(this.timerFechaHasta);
            this.Controls.Add(this.timerFechaDesde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.listBoxHorarios);
            this.Controls.Add(this.botonGuardarCambios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDias);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarAgendaForm";
            this.Text = "RegistrarAgendForm";
            this.Load += new System.EventHandler(this.RegistrarAgendaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonGuardarCambios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox listBoxEspecialidades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox listBoxDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxHorarios;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DateTimePicker timeHoraDesde;
        private System.Windows.Forms.DateTimePicker timeHoraHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timerFechaDesde;
        private System.Windows.Forms.DateTimePicker timerFechaHasta;
    }
}