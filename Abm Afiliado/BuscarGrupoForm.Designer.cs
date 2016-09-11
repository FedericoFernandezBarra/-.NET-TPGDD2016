namespace ClinicaFrba.Abm_Afiliado
{
    partial class BuscarGrupoForm
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
            this.grillaGrupos = new System.Windows.Forms.DataGridView();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaGrupos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(304, 347);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(100, 42);
            this.btnAction.TabIndex = 14;
            this.btnAction.Text = "Aceptar";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // grillaGrupos
            // 
            this.grillaGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grillaGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaGrupos.Location = new System.Drawing.Point(25, 141);
            this.grillaGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.grillaGrupos.Name = "grillaGrupos";
            this.grillaGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaGrupos.Size = new System.Drawing.Size(379, 198);
            this.grillaGrupos.TabIndex = 13;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(304, 105);
            this.cmdBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(100, 28);
            this.cmdBuscar.TabIndex = 12;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(25, 105);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(100, 28);
            this.cmdLimpiar.TabIndex = 11;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumGrupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(391, 80);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // txtNumGrupo
            // 
            this.txtNumGrupo.Location = new System.Drawing.Point(149, 31);
            this.txtNumGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumGrupo.Name = "txtNumGrupo";
            this.txtNumGrupo.Size = new System.Drawing.Size(132, 22);
            this.txtNumGrupo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Grupo:";
            // 
            // BuscarGrupoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 400);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.grillaGrupos);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarGrupoForm";
            this.Text = "BuscarGrupoForm";
            ((System.ComponentModel.ISupportInitialize)(this.grillaGrupos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.DataGridView grillaGrupos;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumGrupo;
        private System.Windows.Forms.Label label1;
    }
}