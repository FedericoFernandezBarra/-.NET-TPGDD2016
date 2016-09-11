namespace ClinicaFrba.Compra_Bono
{
    partial class ImprimirBonoForm
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstBonosFarmacia = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstBonosConsulta = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.tbNroAfiliado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 535);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(716, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Recuerde que deberá presentar estos números para continuar con los procedimientos" +
    " en la clínica.";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(741, 539);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstBonosFarmacia);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 359);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(837, 172);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bonos de farmacia";
            // 
            // lstBonosFarmacia
            // 
            this.lstBonosFarmacia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBonosFarmacia.FormattingEnabled = true;
            this.lstBonosFarmacia.ItemHeight = 18;
            this.lstBonosFarmacia.Location = new System.Drawing.Point(8, 23);
            this.lstBonosFarmacia.Margin = new System.Windows.Forms.Padding(4);
            this.lstBonosFarmacia.Name = "lstBonosFarmacia";
            this.lstBonosFarmacia.Size = new System.Drawing.Size(821, 108);
            this.lstBonosFarmacia.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstBonosConsulta);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(837, 172);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bonos de consulta";
            // 
            // lstBonosConsulta
            // 
            this.lstBonosConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBonosConsulta.FormattingEnabled = true;
            this.lstBonosConsulta.ItemHeight = 21;
            this.lstBonosConsulta.Location = new System.Drawing.Point(8, 23);
            this.lstBonosConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.lstBonosConsulta.Name = "lstBonosConsulta";
            this.lstBonosConsulta.Size = new System.Drawing.Size(821, 126);
            this.lstBonosConsulta.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNombreCompleto);
            this.groupBox1.Controls.Add(this.tbNroAfiliado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(837, 114);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del afiliado";
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombreCompleto.Location = new System.Drawing.Point(331, 74);
            this.tbNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Size = new System.Drawing.Size(497, 30);
            this.tbNombreCompleto.TabIndex = 3;
            // 
            // tbNroAfiliado
            // 
            this.tbNroAfiliado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNroAfiliado.Location = new System.Drawing.Point(331, 28);
            this.tbNroAfiliado.Margin = new System.Windows.Forms.Padding(4);
            this.tbNroAfiliado.Name = "tbNroAfiliado";
            this.tbNroAfiliado.Size = new System.Drawing.Size(497, 30);
            this.tbNroAfiliado.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nº de afiliado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clinica FRBA - Impresión de bonos";
            // 
            // ImprimirBonoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(878, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ImprimirBonoForm";
            this.Text = "ImprimirBonoForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstBonosFarmacia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstBonosConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.TextBox tbNroAfiliado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}