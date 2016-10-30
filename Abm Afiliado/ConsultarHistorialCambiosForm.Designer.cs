namespace ClinicaFrba.Abm_Afiliado
{
    partial class ConsultarHistorialCambiosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.grillaCambiosDePlan = new System.Windows.Forms.DataGridView();
            this.Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCambiosDePlan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambios de Plan de ";
            // 
            // grillaCambiosDePlan
            // 
            this.grillaCambiosDePlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCambiosDePlan.Location = new System.Drawing.Point(12, 36);
            this.grillaCambiosDePlan.Name = "grillaCambiosDePlan";
            this.grillaCambiosDePlan.Size = new System.Drawing.Size(441, 198);
            this.grillaCambiosDePlan.TabIndex = 1;
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(360, 240);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // ConsultarHistorialCambiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 271);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.grillaCambiosDePlan);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarHistorialCambiosForm";
            this.Text = "ConsultarHistorialCambiosForm";
            this.Load += new System.EventHandler(this.ConsultarHistorialCambiosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCambiosDePlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaCambiosDePlan;
        private System.Windows.Forms.Button Volver;
    }
}