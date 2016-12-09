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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarAgendaForm));
            this.botonGuardarCambios = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEliminarEspe = new System.Windows.Forms.Button();
            this.btAgregarEspe = new System.Windows.Forms.Button();
            this.lbEspe = new System.Windows.Forms.ListBox();
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
            this.ESPECIALIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESDE_LAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASTA_LAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lbHorasTotales = new System.Windows.Forms.Label();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonGuardarCambios
            // 
            this.botonGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardarCambios.Location = new System.Drawing.Point(320, 88);
            this.botonGuardarCambios.Name = "botonGuardarCambios";
            this.botonGuardarCambios.Size = new System.Drawing.Size(112, 23);
            this.botonGuardarCambios.TabIndex = 13;
            this.botonGuardarCambios.Text = "Guardar Cambios";
            this.botonGuardarCambios.UseVisualStyleBackColor = true;
            this.botonGuardarCambios.Click += new System.EventHandler(this.botonGuardarCambios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btEliminarEspe);
            this.groupBox1.Controls.Add(this.btAgregarEspe);
            this.groupBox1.Controls.Add(this.lbEspe);
            this.groupBox1.Controls.Add(this.timeHoraHasta);
            this.groupBox1.Controls.Add(this.timeHoraDesde);
            this.groupBox1.Controls.Add(this.listBoxEspecialidades);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.botonAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 233);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar horarios al día de la semana";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Rango de horarios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Especialidades para este rango:";
            // 
            // btEliminarEspe
            // 
            this.btEliminarEspe.Location = new System.Drawing.Point(6, 200);
            this.btEliminarEspe.Name = "btEliminarEspe";
            this.btEliminarEspe.Size = new System.Drawing.Size(216, 23);
            this.btEliminarEspe.TabIndex = 21;
            this.btEliminarEspe.Text = "Eliminar especialidad seleccionada";
            this.btEliminarEspe.UseVisualStyleBackColor = true;
            this.btEliminarEspe.Click += new System.EventHandler(this.btEliminarEspe_Click);
            // 
            // btAgregarEspe
            // 
            this.btAgregarEspe.Location = new System.Drawing.Point(9, 70);
            this.btAgregarEspe.Name = "btAgregarEspe";
            this.btAgregarEspe.Size = new System.Drawing.Size(163, 23);
            this.btAgregarEspe.TabIndex = 20;
            this.btAgregarEspe.Text = "Agregar especialidad a atender";
            this.btAgregarEspe.UseVisualStyleBackColor = true;
            this.btAgregarEspe.Click += new System.EventHandler(this.btAgregarEspe_Click);
            // 
            // lbEspe
            // 
            this.lbEspe.FormattingEnabled = true;
            this.lbEspe.Location = new System.Drawing.Point(6, 125);
            this.lbEspe.Name = "lbEspe";
            this.lbEspe.Size = new System.Drawing.Size(216, 69);
            this.lbEspe.TabIndex = 19;
            // 
            // timeHoraHasta
            // 
            this.timeHoraHasta.CustomFormat = "HH:mm";
            this.timeHoraHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeHoraHasta.Location = new System.Drawing.Point(322, 173);
            this.timeHoraHasta.Name = "timeHoraHasta";
            this.timeHoraHasta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeHoraHasta.ShowUpDown = true;
            this.timeHoraHasta.Size = new System.Drawing.Size(110, 20);
            this.timeHoraHasta.TabIndex = 18;
            // 
            // timeHoraDesde
            // 
            this.timeHoraDesde.CustomFormat = "HH:mm";
            this.timeHoraDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeHoraDesde.Location = new System.Drawing.Point(322, 138);
            this.timeHoraDesde.Name = "timeHoraDesde";
            this.timeHoraDesde.ShowUpDown = true;
            this.timeHoraDesde.Size = new System.Drawing.Size(110, 20);
            this.timeHoraDesde.TabIndex = 17;
            // 
            // listBoxEspecialidades
            // 
            this.listBoxEspecialidades.FormattingEnabled = true;
            this.listBoxEspecialidades.Location = new System.Drawing.Point(9, 43);
            this.listBoxEspecialidades.Name = "listBoxEspecialidades";
            this.listBoxEspecialidades.Size = new System.Drawing.Size(426, 21);
            this.listBoxEspecialidades.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Especialidades del profesional:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hora Desde:";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(263, 200);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(172, 23);
            this.botonAgregar.TabIndex = 0;
            this.botonAgregar.Text = "Agregar rango de horarios";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // listBoxDias
            // 
            this.listBoxDias.FormattingEnabled = true;
            this.listBoxDias.Location = new System.Drawing.Point(12, 25);
            this.listBoxDias.Name = "listBoxDias";
            this.listBoxDias.Size = new System.Drawing.Size(121, 21);
            this.listBoxDias.TabIndex = 8;
            this.listBoxDias.SelectedValueChanged += new System.EventHandler(this.listBoxDias_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Día de la semana:";
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(6, 88);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(74, 23);
            this.botonVolver.TabIndex = 16;
            this.botonVolver.Text = "Cancelar";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha Hasta:";
            // 
            // timerFechaDesde
            // 
            this.timerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timerFechaDesde.Location = new System.Drawing.Point(86, 55);
            this.timerFechaDesde.Name = "timerFechaDesde";
            this.timerFechaDesde.Size = new System.Drawing.Size(110, 20);
            this.timerFechaDesde.TabIndex = 23;
            // 
            // timerFechaHasta
            // 
            this.timerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timerFechaHasta.Location = new System.Drawing.Point(322, 54);
            this.timerFechaHasta.Name = "timerFechaHasta";
            this.timerFechaHasta.Size = new System.Drawing.Size(110, 20);
            this.timerFechaHasta.TabIndex = 24;
            // 
            // dgHorarios
            // 
            this.dgHorarios.AllowUserToDeleteRows = false;
            this.dgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESPECIALIDADES,
            this.DESDE_LAS,
            this.HASTA_LAS});
            this.dgHorarios.Location = new System.Drawing.Point(12, 69);
            this.dgHorarios.MultiSelect = false;
            this.dgHorarios.Name = "dgHorarios";
            this.dgHorarios.ReadOnly = true;
            this.dgHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHorarios.Size = new System.Drawing.Size(449, 101);
            this.dgHorarios.TabIndex = 25;
            // 
            // ESPECIALIDADES
            // 
            this.ESPECIALIDADES.HeaderText = "ESPECIALIDADES";
            this.ESPECIALIDADES.Name = "ESPECIALIDADES";
            this.ESPECIALIDADES.ReadOnly = true;
            // 
            // DESDE_LAS
            // 
            this.DESDE_LAS.HeaderText = "DESDE_LAS";
            this.DESDE_LAS.Name = "DESDE_LAS";
            this.DESDE_LAS.ReadOnly = true;
            // 
            // HASTA_LAS
            // 
            this.HASTA_LAS.HeaderText = "HASTA_LAS";
            this.HASTA_LAS.Name = "HASTA_LAS";
            this.HASTA_LAS.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Horas Trabajadas en Total:";
            // 
            // lbHorasTotales
            // 
            this.lbHorasTotales.AutoSize = true;
            this.lbHorasTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorasTotales.Location = new System.Drawing.Point(385, 26);
            this.lbHorasTotales.Name = "lbHorasTotales";
            this.lbHorasTotales.Size = new System.Drawing.Size(76, 17);
            this.lbHorasTotales.TabIndex = 27;
            this.lbHorasTotales.Text = "00:00 hs.";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(302, 176);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(159, 23);
            this.botonEliminar.TabIndex = 28;
            this.botonEliminar.Text = "Eliminar fila seleccionada";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.botonGuardarCambios);
            this.groupBox2.Controls.Add(this.botonVolver);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.timerFechaDesde);
            this.groupBox2.Controls.Add(this.timerFechaHasta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(18, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 120);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Cambios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Rango de validez de la agenda:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Rango de horarios del día seleccionado:";
            // 
            // RegistrarAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 551);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.lbHorasTotales);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgHorarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxDias);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RegistrarAgendaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbHorasTotales;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button btEliminarEspe;
        private System.Windows.Forms.Button btAgregarEspe;
        private System.Windows.Forms.ListBox lbEspe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESPECIALIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESDE_LAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HASTA_LAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}