namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class ConsultarTurnosForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.mcDesde = new System.Windows.Forms.MonthCalendar();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.btnBuscarProfesional = new System.Windows.Forms.Button();
            this.tbProfesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(314, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(643, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "Busque un día en el calendario y con el botón \"Turnos disponibles\" podrá consulta" +
    "r los turnos para esa fecha";
            // 
            // mcDesde
            // 
            this.mcDesde.Enabled = false;
            this.mcDesde.Location = new System.Drawing.Point(29, 54);
            this.mcDesde.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcDesde.MaxSelectionCount = 1;
            this.mcDesde.Name = "mcDesde";
            this.mcDesde.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(823, 549);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnTurnos
            // 
            this.btnTurnos.Enabled = false;
            this.btnTurnos.Location = new System.Drawing.Point(317, 173);
            this.btnTurnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(139, 28);
            this.btnTurnos.TabIndex = 12;
            this.btnTurnos.Text = "Turnos disponibles";
            this.btnTurnos.UseVisualStyleBackColor = true;
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(29, 262);
            this.dgvTurnos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(901, 279);
            this.dgvTurnos.TabIndex = 13;
            // 
            // btnBuscarProfesional
            // 
            this.btnBuscarProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProfesional.Location = new System.Drawing.Point(823, 12);
            this.btnBuscarProfesional.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProfesional.Name = "btnBuscarProfesional";
            this.btnBuscarProfesional.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarProfesional.TabIndex = 10;
            this.btnBuscarProfesional.Text = "Buscar";
            this.btnBuscarProfesional.UseVisualStyleBackColor = true;
            // 
            // tbProfesional
            // 
            this.tbProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfesional.Location = new System.Drawing.Point(130, 15);
            this.tbProfesional.Margin = new System.Windows.Forms.Padding(4);
            this.tbProfesional.Name = "tbProfesional";
            this.tbProfesional.ReadOnly = true;
            this.tbProfesional.Size = new System.Drawing.Size(683, 22);
            this.tbProfesional.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Profesional";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcDesde);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnTurnos);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.btnBuscarProfesional);
            this.Controls.Add(this.tbProfesional);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mcDesde;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Button btnBuscarProfesional;
        private System.Windows.Forms.TextBox tbProfesional;
        private System.Windows.Forms.Label label1;
    }
}