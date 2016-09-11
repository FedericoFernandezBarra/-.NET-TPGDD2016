namespace ClinicaFrba.Abm_Profesional
{
    partial class BuscarProfesionalForm
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
            this.btnAction = new System.Windows.Forms.Button();
            this.grillaProfesionales = new System.Windows.Forms.DataGridView();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumMatricula = new System.Windows.Forms.TextBox();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesionales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(438, 391);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(100, 42);
            this.btnAction.TabIndex = 15;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // grillaProfesionales
            // 
            this.grillaProfesionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grillaProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProfesionales.Location = new System.Drawing.Point(25, 185);
            this.grillaProfesionales.Margin = new System.Windows.Forms.Padding(4);
            this.grillaProfesionales.Name = "grillaProfesionales";
            this.grillaProfesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProfesionales.Size = new System.Drawing.Size(569, 198);
            this.grillaProfesionales.TabIndex = 14;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(438, 148);
            this.cmdBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(100, 28);
            this.cmdBuscar.TabIndex = 13;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(25, 149);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(100, 28);
            this.cmdLimpiar.TabIndex = 12;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtNumMatricula);
            this.groupBox1.Controls.Add(this.cmbEspecialidades);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(581, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(385, 58);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(132, 22);
            this.txtDni.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(145, 60);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 22);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(385, 21);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtNumMatricula
            // 
            this.txtNumMatricula.Location = new System.Drawing.Point(149, 31);
            this.txtNumMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumMatricula.Name = "txtNumMatricula";
            this.txtNumMatricula.Size = new System.Drawing.Size(132, 22);
            this.txtNumMatricula.TabIndex = 5;
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(141, 89);
            this.cmbEspecialidades.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(160, 24);
            this.cmbEspecialidades.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Especialidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Matricula:";
            // 
            // BuscarProfesionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 445);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.grillaProfesionales);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarProfesionalForm";
            this.Text = "BuscarProfesionalForm";
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesionales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.DataGridView grillaProfesionales;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumMatricula;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}