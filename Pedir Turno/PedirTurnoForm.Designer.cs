namespace ClinicaFrba.Pedir_Turno
{
    partial class PedirTurnoForm
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBuscarAfiliado = new System.Windows.Forms.Button();
            this.txtAfiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Seleccione el Afiliado";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(189, 84);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(147, 41);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBuscarAfiliado
            // 
            this.btnBuscarAfiliado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAfiliado.Location = new System.Drawing.Point(415, 33);
            this.btnBuscarAfiliado.Name = "btnBuscarAfiliado";
            this.btnBuscarAfiliado.Size = new System.Drawing.Size(87, 39);
            this.btnBuscarAfiliado.TabIndex = 19;
            this.btnBuscarAfiliado.Text = "BUSCAR";
            this.btnBuscarAfiliado.UseVisualStyleBackColor = true;
            this.btnBuscarAfiliado.Click += new System.EventHandler(this.btnBuscarAfiliado_Click);
            // 
            // txtAfiliado
            // 
            this.txtAfiliado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAfiliado.Location = new System.Drawing.Point(70, 44);
            this.txtAfiliado.Name = "txtAfiliado";
            this.txtAfiliado.ReadOnly = true;
            this.txtAfiliado.Size = new System.Drawing.Size(339, 20);
            this.txtAfiliado.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "AFILIADO";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 93);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 32);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // PedirTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 137);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnBuscarAfiliado);
            this.Controls.Add(this.txtAfiliado);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PedirTurnoForm";
            this.Text = "Pedir Turno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnBuscarAfiliado;
        private System.Windows.Forms.TextBox txtAfiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;

    }
}