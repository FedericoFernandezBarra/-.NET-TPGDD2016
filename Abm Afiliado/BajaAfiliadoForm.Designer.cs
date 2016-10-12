namespace ClinicaFrba.Abm_Afiliado
{
    partial class BajaAfiliadoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVolver = new System.Windows.Forms.Button();
            this.cmdBaja = new System.Windows.Forms.Button();
            this.txtNroAfliado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbVolver);
            this.groupBox1.Controls.Add(this.cmdBaja);
            this.groupBox1.Controls.Add(this.txtNroAfliado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNick);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dar de Baja Afiliado";
            // 
            // cmbVolver
            // 
            this.cmbVolver.Location = new System.Drawing.Point(187, 133);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(75, 23);
            this.cmbVolver.TabIndex = 60;
            this.cmbVolver.Text = "Volver";
            this.cmbVolver.UseVisualStyleBackColor = true;
            // 
            // cmdBaja
            // 
            this.cmdBaja.Location = new System.Drawing.Point(32, 133);
            this.cmdBaja.Name = "cmdBaja";
            this.cmdBaja.Size = new System.Drawing.Size(75, 23);
            this.cmdBaja.TabIndex = 57;
            this.cmdBaja.Text = "Dar de Baja";
            this.cmdBaja.UseVisualStyleBackColor = true;
            this.cmdBaja.Click += new System.EventHandler(this.cmdBaja_Click);
            // 
            // txtNroAfliado
            // 
            this.txtNroAfliado.Enabled = false;
            this.txtNroAfliado.Location = new System.Drawing.Point(132, 85);
            this.txtNroAfliado.Name = "txtNroAfliado";
            this.txtNroAfliado.Size = new System.Drawing.Size(137, 20);
            this.txtNroAfliado.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nro de Afiliado:";
            // 
            // txtNick
            // 
            this.txtNick.Enabled = false;
            this.txtNick.Location = new System.Drawing.Point(132, 22);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(137, 20);
            this.txtNick.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nick:";
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(132, 55);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(137, 20);
            this.txtPass.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // BajaAfiliadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 191);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaAfiliadoForm";
            this.Text = "BajaAfiliadoForm";
            this.Load += new System.EventHandler(this.BajaAfiliadoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmbVolver;
        private System.Windows.Forms.Button cmdBaja;
        private System.Windows.Forms.TextBox txtNroAfliado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
    }
}