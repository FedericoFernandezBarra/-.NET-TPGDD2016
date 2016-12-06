namespace ClinicaFrba.AbmRol
{
    partial class AbmRolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbmRolForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevo_Button = new System.Windows.Forms.Button();
            this.tablaRoles = new System.Windows.Forms.DataGridView();
            this.Modificar_Button = new System.Windows.Forms.Button();
            this.Volver_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nuevo_Button);
            this.groupBox1.Controls.Add(this.tablaRoles);
            this.groupBox1.Controls.Add(this.Modificar_Button);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 276);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de Roles";
            // 
            // Nuevo_Button
            // 
            this.Nuevo_Button.Location = new System.Drawing.Point(6, 19);
            this.Nuevo_Button.Name = "Nuevo_Button";
            this.Nuevo_Button.Size = new System.Drawing.Size(75, 23);
            this.Nuevo_Button.TabIndex = 1;
            this.Nuevo_Button.Text = "Nuevo";
            this.Nuevo_Button.UseVisualStyleBackColor = true;
            this.Nuevo_Button.Click += new System.EventHandler(this.Nuevo_Button_Click);
            // 
            // tablaRoles
            // 
            this.tablaRoles.AllowUserToAddRows = false;
            this.tablaRoles.AllowUserToDeleteRows = false;
            this.tablaRoles.AllowUserToOrderColumns = true;
            this.tablaRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaRoles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRoles.Location = new System.Drawing.Point(6, 48);
            this.tablaRoles.MultiSelect = false;
            this.tablaRoles.Name = "tablaRoles";
            this.tablaRoles.ReadOnly = true;
            this.tablaRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaRoles.Size = new System.Drawing.Size(398, 222);
            this.tablaRoles.TabIndex = 3;
            this.tablaRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRoles_CellClick);
            // 
            // Modificar_Button
            // 
            this.Modificar_Button.Location = new System.Drawing.Point(99, 19);
            this.Modificar_Button.Name = "Modificar_Button";
            this.Modificar_Button.Size = new System.Drawing.Size(75, 23);
            this.Modificar_Button.TabIndex = 2;
            this.Modificar_Button.Text = "Modificar";
            this.Modificar_Button.UseVisualStyleBackColor = true;
            this.Modificar_Button.Click += new System.EventHandler(this.Modificar_Button_Click);
            // 
            // Volver_Button
            // 
            this.Volver_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Volver_Button.Location = new System.Drawing.Point(345, 291);
            this.Volver_Button.Name = "Volver_Button";
            this.Volver_Button.Size = new System.Drawing.Size(75, 23);
            this.Volver_Button.TabIndex = 4;
            this.Volver_Button.Text = "Volver";
            this.Volver_Button.UseVisualStyleBackColor = true;
            this.Volver_Button.Click += new System.EventHandler(this.Volver_Button_Click);
            // 
            // AbmRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Volver_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AbmRolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.AbmRolForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nuevo_Button;
        private System.Windows.Forms.DataGridView tablaRoles;
        private System.Windows.Forms.Button Modificar_Button;
        private System.Windows.Forms.Button Volver_Button;
    }
}