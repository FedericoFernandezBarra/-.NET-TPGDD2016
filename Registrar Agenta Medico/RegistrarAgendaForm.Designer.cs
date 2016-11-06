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
            this.timeHoraHasta = new System.Windows.Forms.DateTimePicker();
            this.timeHoraDesde = new System.Windows.Forms.DateTimePicker();
            this.listBoxEspecialidades = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.listBoxDias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.timerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dgHorarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lbHorasTotales = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // botonGuardarCambios
            // 
            this.botonGuardarCambios.Location = new System.Drawing.Point(149, 514);
            this.botonGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonGuardarCambios.Name = "botonGuardarCambios";
            this.botonGuardarCambios.Size = new System.Drawing.Size(133, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(20, 302);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(599, 176);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Horarios";
            // 
            // timeHoraHasta
            // 
            this.timeHoraHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoraHasta.Location = new System.Drawing.Point(239, 127);
            this.timeHoraHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeHoraHasta.Name = "timeHoraHasta";
            this.timeHoraHasta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeHoraHasta.ShowUpDown = true;
            this.timeHoraHasta.Size = new System.Drawing.Size(145, 22);
            this.timeHoraHasta.TabIndex = 18;
            // 
            // timeHoraDesde
            // 
            this.timeHoraDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoraDesde.Location = new System.Drawing.Point(19, 127);
            this.timeHoraDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeHoraDesde.Name = "timeHoraDesde";
            this.timeHoraDesde.ShowUpDown = true;
            this.timeHoraDesde.Size = new System.Drawing.Size(145, 22);
            this.timeHoraDesde.TabIndex = 17;
            // 
            // listBoxEspecialidades
            // 
            this.listBoxEspecialidades.FormattingEnabled = true;
            this.listBoxEspecialidades.Location = new System.Drawing.Point(15, 62);
            this.listBoxEspecialidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxEspecialidades.Name = "listBoxEspecialidades";
            this.listBoxEspecialidades.Size = new System.Drawing.Size(560, 24);
            this.listBoxEspecialidades.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Especialidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hora Desde:";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(443, 123);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(133, 28);
            this.botonAgregar.TabIndex = 0;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // listBoxDias
            // 
            this.listBoxDias.FormattingEnabled = true;
            this.listBoxDias.Location = new System.Drawing.Point(20, 31);
            this.listBoxDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxDias.Name = "listBoxDias";
            this.listBoxDias.Size = new System.Drawing.Size(160, 24);
            this.listBoxDias.TabIndex = 8;
            this.listBoxDias.SelectedValueChanged += new System.EventHandler(this.listBoxDias_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Día:";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(367, 514);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(133, 28);
            this.botonVolver.TabIndex = 16;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha Hasta:";
            // 
            // timerFechaDesde
            // 
            this.timerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timerFechaDesde.Location = new System.Drawing.Point(245, 32);
            this.timerFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timerFechaDesde.Name = "timerFechaDesde";
            this.timerFechaDesde.Size = new System.Drawing.Size(145, 22);
            this.timerFechaDesde.TabIndex = 23;
            // 
            // timerFechaHasta
            // 
            this.timerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timerFechaHasta.Location = new System.Drawing.Point(449, 31);
            this.timerFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timerFechaHasta.Name = "timerFechaHasta";
            this.timerFechaHasta.Size = new System.Drawing.Size(145, 22);
            this.timerFechaHasta.TabIndex = 24;
            // 
            // dgHorarios
            // 
            this.dgHorarios.AllowUserToDeleteRows = false;
            this.dgHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgHorarios.Location = new System.Drawing.Point(20, 64);
            this.dgHorarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgHorarios.MultiSelect = false;
            this.dgHorarios.Name = "dgHorarios";
            this.dgHorarios.ReadOnly = true;
            this.dgHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHorarios.Size = new System.Drawing.Size(599, 198);
            this.dgHorarios.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Especialidad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Desde las";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hasta las";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Horas Trabajadas en Total:";
            // 
            // lbHorasTotales
            // 
            this.lbHorasTotales.AutoSize = true;
            this.lbHorasTotales.Location = new System.Drawing.Point(205, 277);
            this.lbHorasTotales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHorasTotales.Name = "lbHorasTotales";
            this.lbHorasTotales.Size = new System.Drawing.Size(67, 17);
            this.lbHorasTotales.TabIndex = 27;
            this.lbHorasTotales.Text = "00:00 hs.";
            // 
            // RegistrarAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 578);
            this.Controls.Add(this.lbHorasTotales);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgHorarios);
            this.Controls.Add(this.timerFechaHasta);
            this.Controls.Add(this.timerFechaDesde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonGuardarCambios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxDias);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrarAgendaForm";
            this.Text = "RegistrarAgendForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).EndInit();
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
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DateTimePicker timeHoraDesde;
        private System.Windows.Forms.DateTimePicker timeHoraHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timerFechaDesde;
        private System.Windows.Forms.DateTimePicker timerFechaHasta;
        private System.Windows.Forms.DataGridView dgHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbHorasTotales;
    }
}