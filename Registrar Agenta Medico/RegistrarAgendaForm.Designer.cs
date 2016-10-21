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
            this.botonGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHoraHasta = new System.Windows.Forms.ComboBox();
            this.cmbHoraDesde = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxHorarios = new System.Windows.Forms.ListBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(115, 385);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(100, 23);
            this.botonGuardar.TabIndex = 13;
            this.botonGuardar.Text = "Guardar Cambios";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEspecialidades);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbHoraHasta);
            this.groupBox1.Controls.Add(this.cmbHoraDesde);
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
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(322, 47);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidades.TabIndex = 14;
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
            // cmbHoraHasta
            // 
            this.cmbHoraHasta.FormattingEnabled = true;
            this.cmbHoraHasta.Location = new System.Drawing.Point(169, 47);
            this.cmbHoraHasta.Name = "cmbHoraHasta";
            this.cmbHoraHasta.Size = new System.Drawing.Size(102, 21);
            this.cmbHoraHasta.TabIndex = 12;
            // 
            // cmbHoraDesde
            // 
            this.cmbHoraDesde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cmbHoraDesde.FormattingEnabled = true;
            this.cmbHoraDesde.Location = new System.Drawing.Point(6, 47);
            this.cmbHoraDesde.Name = "cmbHoraDesde";
            this.cmbHoraDesde.Size = new System.Drawing.Size(102, 21);
            this.cmbHoraDesde.TabIndex = 11;
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
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(21, 52);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(121, 21);
            this.cmbDias.TabIndex = 8;
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
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(368, 89);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 0;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
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
            // RegistrarAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 431);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.listBoxHorarios);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDias);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrarAgendaForm";
            this.Text = "RegistrarAgendForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHoraHasta;
        private System.Windows.Forms.ComboBox cmbHoraDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxHorarios;
        private System.Windows.Forms.Button botonVolver;
    }
}