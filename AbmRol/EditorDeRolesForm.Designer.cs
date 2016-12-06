namespace ClinicaFrba.AbmRol
{
    partial class EditorDeRolesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorDeRolesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.cbxHabilitado = new System.Windows.Forms.CheckBox();
            this.Funcionalidades_Label = new System.Windows.Forms.Label();
            this.Habilitado_Label = new System.Windows.Forms.Label();
            this.Guardar_Button = new System.Windows.Forms.Button();
            this.Cancelar_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nombre_Label);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cbxFuncionalidades);
            this.groupBox1.Controls.Add(this.cbxHabilitado);
            this.groupBox1.Controls.Add(this.Funcionalidades_Label);
            this.groupBox1.Controls.Add(this.Habilitado_Label);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 244);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione las funcionalidades:";
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.AutoSize = true;
            this.Nombre_Label.Location = new System.Drawing.Point(6, 33);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(44, 13);
            this.Nombre_Label.TabIndex = 0;
            this.Nombre_Label.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 33);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(397, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // cbxFuncionalidades
            // 
            this.cbxFuncionalidades.FormattingEnabled = true;
            this.cbxFuncionalidades.Location = new System.Drawing.Point(95, 70);
            this.cbxFuncionalidades.Name = "cbxFuncionalidades";
            this.cbxFuncionalidades.Size = new System.Drawing.Size(403, 109);
            this.cbxFuncionalidades.TabIndex = 2;
            // 
            // cbxHabilitado
            // 
            this.cbxHabilitado.AutoSize = true;
            this.cbxHabilitado.Location = new System.Drawing.Point(95, 205);
            this.cbxHabilitado.Name = "cbxHabilitado";
            this.cbxHabilitado.Size = new System.Drawing.Size(15, 14);
            this.cbxHabilitado.TabIndex = 3;
            this.cbxHabilitado.UseVisualStyleBackColor = true;
            // 
            // Funcionalidades_Label
            // 
            this.Funcionalidades_Label.AutoSize = true;
            this.Funcionalidades_Label.Location = new System.Drawing.Point(6, 70);
            this.Funcionalidades_Label.Name = "Funcionalidades_Label";
            this.Funcionalidades_Label.Size = new System.Drawing.Size(84, 13);
            this.Funcionalidades_Label.TabIndex = 3;
            this.Funcionalidades_Label.Text = "Funcionalidades";
            // 
            // Habilitado_Label
            // 
            this.Habilitado_Label.AutoSize = true;
            this.Habilitado_Label.Location = new System.Drawing.Point(6, 205);
            this.Habilitado_Label.Name = "Habilitado_Label";
            this.Habilitado_Label.Size = new System.Drawing.Size(54, 13);
            this.Habilitado_Label.TabIndex = 4;
            this.Habilitado_Label.Text = "Habilitado";
            // 
            // Guardar_Button
            // 
            this.Guardar_Button.Location = new System.Drawing.Point(427, 259);
            this.Guardar_Button.Name = "Guardar_Button";
            this.Guardar_Button.Size = new System.Drawing.Size(75, 23);
            this.Guardar_Button.TabIndex = 4;
            this.Guardar_Button.Text = "Guardar";
            this.Guardar_Button.UseVisualStyleBackColor = true;
            this.Guardar_Button.Click += new System.EventHandler(this.Guardar_Button_Click);
            // 
            // Cancelar_Button
            // 
            this.Cancelar_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar_Button.Location = new System.Drawing.Point(327, 259);
            this.Cancelar_Button.Name = "Cancelar_Button";
            this.Cancelar_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_Button.TabIndex = 5;
            this.Cancelar_Button.Text = "Cancelar";
            this.Cancelar_Button.UseVisualStyleBackColor = true;
            this.Cancelar_Button.Click += new System.EventHandler(this.Cancelar_Button_Click);
            // 
            // EditorDeRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Guardar_Button);
            this.Controls.Add(this.Cancelar_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EditorDeRolesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.EditorDeRolesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Nombre_Label;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckedListBox cbxFuncionalidades;
        private System.Windows.Forms.CheckBox cbxHabilitado;
        private System.Windows.Forms.Label Funcionalidades_Label;
        private System.Windows.Forms.Label Habilitado_Label;
        private System.Windows.Forms.Button Guardar_Button;
        private System.Windows.Forms.Button Cancelar_Button;
    }
}