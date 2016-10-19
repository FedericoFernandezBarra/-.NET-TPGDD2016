namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarTurnoForm
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.cmbCancelacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.grillaTurnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(10, 333);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 34;
            this.lbl1.Text = "Afiliado:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(110, 301);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(246, 20);
            this.txtMotivo.TabIndex = 33;
            // 
            // cmbCancelacion
            // 
            this.cmbCancelacion.FormattingEnabled = true;
            this.cmbCancelacion.Location = new System.Drawing.Point(110, 273);
            this.cmbCancelacion.Name = "cmbCancelacion";
            this.cmbCancelacion.Size = new System.Drawing.Size(121, 21);
            this.cmbCancelacion.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tipo Cancelacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Motivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Seleccione Turno a Cancelar:";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(362, 312);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 34);
            this.btnAction.TabIndex = 28;
            this.btnAction.Text = "Confirmar";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // grillaTurnos
            // 
            this.grillaTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grillaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTurnos.Location = new System.Drawing.Point(10, 24);
            this.grillaTurnos.Name = "grillaTurnos";
            this.grillaTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaTurnos.Size = new System.Drawing.Size(427, 237);
            this.grillaTurnos.TabIndex = 27;
            this.grillaTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTurnos_CellClick);
            // 
            // CancelarTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 359);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.cmbCancelacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.grillaTurnos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CancelarTurnoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CancelarTurnoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.ComboBox cmbCancelacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.DataGridView grillaTurnos;
    }
}