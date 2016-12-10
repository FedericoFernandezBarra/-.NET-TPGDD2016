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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupoAfiliadoViejo));
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
            this.bEliminarPrincipal = new System.Windows.Forms.Button();
            this.bEliminarConyugue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfiliados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAfiliados
            // 
            this.dataGridAfiliados.AllowUserToDeleteRows = false;
            this.dataGridAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.NOMBRE,
            this.APELLIDO});
            this.dataGridAfiliados.Location = new System.Drawing.Point(12, 29);
            this.dataGridAfiliados.MultiSelect = false;
            this.dataGridAfiliados.Name = "dataGridAfiliados";
            this.dataGridAfiliados.ReadOnly = true;
            this.dataGridAfiliados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAfiliados.Size = new System.Drawing.Size(570, 283);
            this.dataGridAfiliados.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Afiliados sin numero de Afiliado:";
            // 
            // bAsignarPrincipal
            // 
            this.bAsignarPrincipal.Location = new System.Drawing.Point(201, 39);
            this.bAsignarPrincipal.Name = "bAsignarPrincipal";
            this.bAsignarPrincipal.Size = new System.Drawing.Size(75, 23);
            this.bAsignarPrincipal.TabIndex = 1;
            this.bAsignarPrincipal.Text = "Asignar";
            this.bAsignarPrincipal.UseVisualStyleBackColor = true;
            this.bAsignarPrincipal.Click += new System.EventHandler(this.bAsignarPrincipal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bEliminarPrincipal);
            this.groupBox1.Controls.Add(this.lbPrincipal);
            this.groupBox1.Controls.Add(this.bAsignarPrincipal);
            this.groupBox1.Location = new System.Drawing.Point(12, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Afiliado Principal";
            // 
            // lbPrincipal
            // 
            this.lbPrincipal.AutoSize = true;
            this.lbPrincipal.Location = new System.Drawing.Point(6, 16);
            this.lbPrincipal.Name = "lbPrincipal";
            this.lbPrincipal.Size = new System.Drawing.Size(60, 13);
            this.lbPrincipal.TabIndex = 5;
            this.lbPrincipal.Text = "Sin Asignar";
            // 
            // lbConyuge
            // 
            this.lbConyuge.AutoSize = true;
            this.lbConyuge.Location = new System.Drawing.Point(6, 16);
            this.lbConyuge.Name = "lbConyuge";
            this.lbConyuge.Size = new System.Drawing.Size(60, 13);
            this.lbConyuge.TabIndex = 5;
            this.lbConyuge.Text = "Sin Asignar";
            // 
            // bAsignarConyuge
            // 
            this.bAsignarConyuge.Location = new System.Drawing.Point(201, 39);
            this.bAsignarConyuge.Name = "bAsignarConyuge";
            this.bAsignarConyuge.Size = new System.Drawing.Size(75, 23);
            this.bAsignarConyuge.TabIndex = 3;
            this.bAsignarConyuge.Text = "Asignar";
            this.bAsignarConyuge.UseVisualStyleBackColor = true;
            this.bAsignarConyuge.Click += new System.EventHandler(this.bAsignarConyuge_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bEliminarConyugue);
            this.groupBox3.Controls.Add(this.lbConyuge);
            this.groupBox3.Controls.Add(this.bAsignarConyuge);
            this.groupBox3.Location = new System.Drawing.Point(300, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 69);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Esposo/a, Conyuge";
            // 
            // bEliminarHijo
            // 
            this.bEliminarHijo.Location = new System.Drawing.Point(349, 122);
            this.bEliminarHijo.Name = "bEliminarHijo";
            this.bEliminarHijo.Size = new System.Drawing.Size(75, 23);
            this.bEliminarHijo.TabIndex = 6;
            this.bEliminarHijo.Text = "Eliminar";
            this.bEliminarHijo.UseVisualStyleBackColor = true;
            this.bEliminarHijo.Click += new System.EventHandler(this.bEliminarHijo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAgregarHijo);
            this.groupBox2.Controls.Add(this.listBoxHijos);
            this.groupBox2.Controls.Add(this.bEliminarHijo);
            this.groupBox2.Location = new System.Drawing.Point(12, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 217);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hijos/as y familiares";
            // 
            // bAgregarHijo
            // 
            this.bAgregarHijo.Location = new System.Drawing.Point(349, 48);
            this.bAgregarHijo.Name = "bAgregarHijo";
            this.bAgregarHijo.Size = new System.Drawing.Size(75, 23);
            this.bAgregarHijo.TabIndex = 5;
            this.bAgregarHijo.Text = "Agregar";
            this.bAgregarHijo.UseVisualStyleBackColor = true;
            this.bAgregarHijo.Click += new System.EventHandler(this.bAgregarHijo_Click);
            // 
            // listBoxHijos
            // 
            this.listBoxHijos.FormattingEnabled = true;
            this.listBoxHijos.Location = new System.Drawing.Point(9, 19);
            this.listBoxHijos.Name = "listBoxHijos";
            this.listBoxHijos.Size = new System.Drawing.Size(334, 186);
            this.listBoxHijos.TabIndex = 4;
            // 
            // bGuardarCambios
            // 
            this.bGuardarCambios.Location = new System.Drawing.Point(461, 441);
            this.bGuardarCambios.Name = "bGuardarCambios";
            this.bGuardarCambios.Size = new System.Drawing.Size(115, 23);
            this.bGuardarCambios.TabIndex = 7;
            this.bGuardarCambios.Text = "Guardar cambios";
            this.bGuardarCambios.UseVisualStyleBackColor = true;
            this.bGuardarCambios.Click += new System.EventHandler(this.bGuardarCambios_Click);
            // 
            // bVolverAtras
            // 
            this.bVolverAtras.Location = new System.Drawing.Point(461, 515);
            this.bVolverAtras.Name = "bVolverAtras";
            this.bVolverAtras.Size = new System.Drawing.Size(115, 23);
            this.bVolverAtras.TabIndex = 8;
            this.bVolverAtras.Text = "Volver atras";
            this.bVolverAtras.UseVisualStyleBackColor = true;
            this.bVolverAtras.Click += new System.EventHandler(this.bVolverAtras_Click);
            // 
            // bEliminarPrincipal
            // 
            this.bEliminarPrincipal.Location = new System.Drawing.Point(120, 39);
            this.bEliminarPrincipal.Name = "bEliminarPrincipal";
            this.bEliminarPrincipal.Size = new System.Drawing.Size(75, 23);
            this.bEliminarPrincipal.TabIndex = 6;
            this.bEliminarPrincipal.Text = "Eliminar";
            this.bEliminarPrincipal.UseVisualStyleBackColor = true;
            this.bEliminarPrincipal.Click += new System.EventHandler(this.bEliminarPrincipal_Click);
            // 
            // bEliminarConyugue
            // 
            this.bEliminarConyugue.Location = new System.Drawing.Point(120, 39);
            this.bEliminarConyugue.Name = "bEliminarConyugue";
            this.bEliminarConyugue.Size = new System.Drawing.Size(75, 23);
            this.bEliminarConyugue.TabIndex = 7;
            this.bEliminarConyugue.Text = "Eliminar";
            this.bEliminarConyugue.UseVisualStyleBackColor = true;
            this.bEliminarConyugue.Click += new System.EventHandler(this.bEliminarConyugue_Click);
            // 
            // GrupoAfiliadoViejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 620);
            this.Controls.Add(this.bVolverAtras);
            this.Controls.Add(this.bGuardarCambios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridAfiliados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GrupoAfiliadoViejo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de números de afiliados";
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
        private System.Windows.Forms.Button bEliminarPrincipal;
        private System.Windows.Forms.Button bEliminarConyugue;
    }
}