namespace ClinicaFrba.Abm_Grupo_Afiliado_Viejo
{
    partial class GrupoAfiliadoViejo
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
            this.dataGridAfiliados = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bAsignarPrincipal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPrincipal = new System.Windows.Forms.Label();
            this.lbConyuge = new System.Windows.Forms.Label();
            this.bAsignarConyuge = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bEliminarHijo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bAgregarHijo = new System.Windows.Forms.Button();
            this.listBoxHijos = new System.Windows.Forms.ListBox();
            this.bGuardarCambios = new System.Windows.Forms.Button();
            this.bVolverAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfiliados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAfiliados
            // 
            this.dataGridAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.NOMBRE,
            this.APELLIDO});
            this.dataGridAfiliados.Location = new System.Drawing.Point(16, 36);
            this.dataGridAfiliados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridAfiliados.MultiSelect = false;
            this.dataGridAfiliados.Name = "dataGridAfiliados";
            this.dataGridAfiliados.ReadOnly = true;
            this.dataGridAfiliados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAfiliados.Size = new System.Drawing.Size(760, 348);
            this.dataGridAfiliados.TabIndex = 0;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // APELLIDO
            // 
            this.APELLIDO.HeaderText = "APELLIDO";
            this.APELLIDO.Name = "APELLIDO";
            this.APELLIDO.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Afiliados sin numero de Afiliado:";
            // 
            // bAsignarPrincipal
            // 
            this.bAsignarPrincipal.Location = new System.Drawing.Point(268, 48);
            this.bAsignarPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAsignarPrincipal.Name = "bAsignarPrincipal";
            this.bAsignarPrincipal.Size = new System.Drawing.Size(100, 28);
            this.bAsignarPrincipal.TabIndex = 2;
            this.bAsignarPrincipal.Text = "Asignar";
            this.bAsignarPrincipal.UseVisualStyleBackColor = true;
            this.bAsignarPrincipal.Click += new System.EventHandler(this.bAsignarPrincipal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPrincipal);
            this.groupBox1.Controls.Add(this.bAsignarPrincipal);
            this.groupBox1.Location = new System.Drawing.Point(16, 391);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(376, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Afiliado Principal";
            // 
            // lbPrincipal
            // 
            this.lbPrincipal.AutoSize = true;
            this.lbPrincipal.Location = new System.Drawing.Point(8, 20);
            this.lbPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrincipal.Name = "lbPrincipal";
            this.lbPrincipal.Size = new System.Drawing.Size(80, 17);
            this.lbPrincipal.TabIndex = 5;
            this.lbPrincipal.Text = "Sin Asignar";
            // 
            // lbConyuge
            // 
            this.lbConyuge.AutoSize = true;
            this.lbConyuge.Location = new System.Drawing.Point(8, 20);
            this.lbConyuge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConyuge.Name = "lbConyuge";
            this.lbConyuge.Size = new System.Drawing.Size(80, 17);
            this.lbConyuge.TabIndex = 5;
            this.lbConyuge.Text = "Sin Asignar";
            // 
            // bAsignarConyuge
            // 
            this.bAsignarConyuge.Location = new System.Drawing.Point(268, 48);
            this.bAsignarConyuge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAsignarConyuge.Name = "bAsignarConyuge";
            this.bAsignarConyuge.Size = new System.Drawing.Size(100, 28);
            this.bAsignarConyuge.TabIndex = 2;
            this.bAsignarConyuge.Text = "Asignar";
            this.bAsignarConyuge.UseVisualStyleBackColor = true;
            this.bAsignarConyuge.Click += new System.EventHandler(this.bAsignarConyuge_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbConyuge);
            this.groupBox3.Controls.Add(this.bAsignarConyuge);
            this.groupBox3.Location = new System.Drawing.Point(400, 391);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(376, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Esposo/a, Conyuge";
            // 
            // bEliminarHijo
            // 
            this.bEliminarHijo.Location = new System.Drawing.Point(465, 150);
            this.bEliminarHijo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEliminarHijo.Name = "bEliminarHijo";
            this.bEliminarHijo.Size = new System.Drawing.Size(100, 28);
            this.bEliminarHijo.TabIndex = 2;
            this.bEliminarHijo.Text = "Eliminar";
            this.bEliminarHijo.UseVisualStyleBackColor = true;
            this.bEliminarHijo.Click += new System.EventHandler(this.bEliminarHijo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAgregarHijo);
            this.groupBox2.Controls.Add(this.listBoxHijos);
            this.groupBox2.Controls.Add(this.bEliminarHijo);
            this.groupBox2.Location = new System.Drawing.Point(16, 484);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(573, 267);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hijos/as y familiares";
            // 
            // bAgregarHijo
            // 
            this.bAgregarHijo.Location = new System.Drawing.Point(465, 59);
            this.bAgregarHijo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAgregarHijo.Name = "bAgregarHijo";
            this.bAgregarHijo.Size = new System.Drawing.Size(100, 28);
            this.bAgregarHijo.TabIndex = 7;
            this.bAgregarHijo.Text = "Agregar";
            this.bAgregarHijo.UseVisualStyleBackColor = true;
            this.bAgregarHijo.Click += new System.EventHandler(this.bAgregarHijo_Click);
            // 
            // listBoxHijos
            // 
            this.listBoxHijos.FormattingEnabled = true;
            this.listBoxHijos.ItemHeight = 16;
            this.listBoxHijos.Location = new System.Drawing.Point(12, 23);
            this.listBoxHijos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxHijos.Name = "listBoxHijos";
            this.listBoxHijos.Size = new System.Drawing.Size(444, 228);
            this.listBoxHijos.TabIndex = 6;
            // 
            // bGuardarCambios
            // 
            this.bGuardarCambios.Location = new System.Drawing.Point(615, 543);
            this.bGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bGuardarCambios.Name = "bGuardarCambios";
            this.bGuardarCambios.Size = new System.Drawing.Size(153, 28);
            this.bGuardarCambios.TabIndex = 8;
            this.bGuardarCambios.Text = "Guardar cambios";
            this.bGuardarCambios.UseVisualStyleBackColor = true;
            this.bGuardarCambios.Click += new System.EventHandler(this.bGuardarCambios_Click);
            // 
            // bVolverAtras
            // 
            this.bVolverAtras.Location = new System.Drawing.Point(615, 634);
            this.bVolverAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bVolverAtras.Name = "bVolverAtras";
            this.bVolverAtras.Size = new System.Drawing.Size(153, 28);
            this.bVolverAtras.TabIndex = 9;
            this.bVolverAtras.Text = "Volver atras";
            this.bVolverAtras.UseVisualStyleBackColor = true;
            this.bVolverAtras.Click += new System.EventHandler(this.bVolverAtras_Click);
            // 
            // GrupoAfiliadoViejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 763);
            this.Controls.Add(this.bVolverAtras);
            this.Controls.Add(this.bGuardarCambios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridAfiliados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GrupoAfiliadoViejo";
            this.Text = "GrupoAfiliadoViejo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfiliados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAfiliados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAsignarPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPrincipal;
        private System.Windows.Forms.Label lbConyuge;
        private System.Windows.Forms.Button bAsignarConyuge;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bEliminarHijo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bAgregarHijo;
        private System.Windows.Forms.ListBox listBoxHijos;
        private System.Windows.Forms.Button bGuardarCambios;
        private System.Windows.Forms.Button bVolverAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
    }
}