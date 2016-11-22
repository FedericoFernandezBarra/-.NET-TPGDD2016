namespace ClinicaFrba.Listados
{
    partial class ListadoEstadisticoForm
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
            this.limpiarBoton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filtro = new System.Windows.Forms.ComboBox();
            this.mes = new System.Windows.Forms.ComboBox();
            this.mesLabel = new System.Windows.Forms.Label();
            this.filtroEspecial = new System.Windows.Forms.Label();
            this.tablaEstadistica = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.tipoListado = new System.Windows.Forms.ComboBox();
            this.TipoListadoLabel = new System.Windows.Forms.Label();
            this.semestre = new System.Windows.Forms.ComboBox();
            this.TrimestreLabel = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.TextBox();
            this.anioLabel = new System.Windows.Forms.Label();
            this.volverButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstadistica)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // limpiarBoton
            // 
            this.limpiarBoton.Location = new System.Drawing.Point(9, 359);
            this.limpiarBoton.Name = "limpiarBoton";
            this.limpiarBoton.Size = new System.Drawing.Size(134, 27);
            this.limpiarBoton.TabIndex = 26;
            this.limpiarBoton.Text = "Limpiar";
            this.limpiarBoton.UseVisualStyleBackColor = true;
            this.limpiarBoton.Click += new System.EventHandler(this.limpiarBoton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filtro);
            this.groupBox2.Controls.Add(this.mes);
            this.groupBox2.Controls.Add(this.mesLabel);
            this.groupBox2.Controls.Add(this.filtroEspecial);
            this.groupBox2.Controls.Add(this.tablaEstadistica);
            this.groupBox2.Location = new System.Drawing.Point(10, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 183);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOP 5:";
            // 
            // filtro
            // 
            this.filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtro.Enabled = false;
            this.filtro.FormattingEnabled = true;
            this.filtro.Location = new System.Drawing.Point(103, 22);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(156, 21);
            this.filtro.TabIndex = 27;
            this.filtro.SelectedIndexChanged += new System.EventHandler(this.filtro_SelectedIndexChanged);
            // 
            // mes
            // 
            this.mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mes.Enabled = false;
            this.mes.FormattingEnabled = true;
            this.mes.Location = new System.Drawing.Point(343, 22);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(104, 21);
            this.mes.TabIndex = 20;
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Location = new System.Drawing.Point(295, 24);
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(30, 13);
            this.mesLabel.TabIndex = 16;
            this.mesLabel.Text = "Mes:";
            // 
            // filtroEspecial
            // 
            this.filtroEspecial.AutoSize = true;
            this.filtroEspecial.Location = new System.Drawing.Point(6, 24);
            this.filtroEspecial.Name = "filtroEspecial";
            this.filtroEspecial.Size = new System.Drawing.Size(0, 13);
            this.filtroEspecial.TabIndex = 14;
            // 
            // tablaEstadistica
            // 
            this.tablaEstadistica.AllowUserToAddRows = false;
            this.tablaEstadistica.AllowUserToDeleteRows = false;
            this.tablaEstadistica.AllowUserToResizeColumns = false;
            this.tablaEstadistica.AllowUserToResizeRows = false;
            this.tablaEstadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEstadistica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaEstadistica.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEstadistica.GridColor = System.Drawing.SystemColors.Window;
            this.tablaEstadistica.Location = new System.Drawing.Point(6, 48);
            this.tablaEstadistica.Name = "tablaEstadistica";
            this.tablaEstadistica.ReadOnly = true;
            this.tablaEstadistica.RowHeadersVisible = false;
            this.tablaEstadistica.Size = new System.Drawing.Size(494, 123);
            this.tablaEstadistica.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buscarButton);
            this.groupBox1.Controls.Add(this.tipoListado);
            this.groupBox1.Controls.Add(this.TipoListadoLabel);
            this.groupBox1.Controls.Add(this.semestre);
            this.groupBox1.Controls.Add(this.TrimestreLabel);
            this.groupBox1.Controls.Add(this.anio);
            this.groupBox1.Controls.Add(this.anioLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 154);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Los campos marcados con (*) son OBLIGATORIOS";
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(415, 116);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // tipoListado
            // 
            this.tipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoListado.Enabled = false;
            this.tipoListado.FormattingEnabled = true;
            this.tipoListado.Location = new System.Drawing.Point(136, 39);
            this.tipoListado.Name = "tipoListado";
            this.tipoListado.Size = new System.Drawing.Size(354, 21);
            this.tipoListado.TabIndex = 0;
            this.tipoListado.SelectedIndexChanged += new System.EventHandler(this.tipoListado_SelectedIndexChanged);
            // 
            // TipoListadoLabel
            // 
            this.TipoListadoLabel.AutoSize = true;
            this.TipoListadoLabel.Location = new System.Drawing.Point(37, 39);
            this.TipoListadoLabel.Name = "TipoListadoLabel";
            this.TipoListadoLabel.Size = new System.Drawing.Size(96, 13);
            this.TipoListadoLabel.TabIndex = 4;
            this.TipoListadoLabel.Text = "Tipo de Listado (*):";
            // 
            // semestre
            // 
            this.semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestre.Enabled = false;
            this.semestre.FormattingEnabled = true;
            this.semestre.Location = new System.Drawing.Point(343, 77);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(147, 21);
            this.semestre.TabIndex = 2;
            this.semestre.SelectedIndexChanged += new System.EventHandler(this.semestre_SelectedIndexChanged);
            // 
            // TrimestreLabel
            // 
            this.TrimestreLabel.AutoSize = true;
            this.TrimestreLabel.Location = new System.Drawing.Point(274, 80);
            this.TrimestreLabel.Name = "TrimestreLabel";
            this.TrimestreLabel.Size = new System.Drawing.Size(67, 13);
            this.TrimestreLabel.TabIndex = 2;
            this.TrimestreLabel.Text = "Semestre (*):";
            // 
            // anio
            // 
            this.anio.Location = new System.Drawing.Point(136, 77);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(100, 20);
            this.anio.TabIndex = 1;
            this.anio.TextChanged += new System.EventHandler(this.anio_TextChanged);
            this.anio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anio_KeyPress);
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(37, 80);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(42, 13);
            this.anioLabel.TabIndex = 0;
            this.anioLabel.Text = "Año (*):";
            // 
            // volverButton
            // 
            this.volverButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.volverButton.Location = new System.Drawing.Point(382, 359);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(134, 27);
            this.volverButton.TabIndex = 25;
            this.volverButton.Text = "< < Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click_1);
            // 
            // ListadoEstadisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 394);
            this.Controls.Add(this.limpiarBoton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.volverButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListadoEstadisticoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListadoEstadisticoForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstadistica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button limpiarBoton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox mes;
        private System.Windows.Forms.Label mesLabel;
        private System.Windows.Forms.Label filtroEspecial;
        private System.Windows.Forms.DataGridView tablaEstadistica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.ComboBox tipoListado;
        private System.Windows.Forms.Label TipoListadoLabel;
        private System.Windows.Forms.ComboBox semestre;
        private System.Windows.Forms.Label TrimestreLabel;
        private System.Windows.Forms.TextBox anio;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.ComboBox filtro;
    }
}