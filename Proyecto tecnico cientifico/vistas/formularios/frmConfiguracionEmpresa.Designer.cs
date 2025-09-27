namespace vistas.formularios
{
    partial class frmConfiguracionEmpresa
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
            this.pnlRegistrar = new System.Windows.Forms.Panel();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.txtDirreccionEmpresa = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistrar
            // 
            this.pnlRegistrar.BackColor = System.Drawing.Color.Wheat;
            this.pnlRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegistrar.Controls.Add(this.btnGuardarImagen);
            this.pnlRegistrar.Controls.Add(this.pbImagen);
            this.pnlRegistrar.Controls.Add(this.txtNombreEmpresa);
            this.pnlRegistrar.Controls.Add(this.txtDirreccionEmpresa);
            this.pnlRegistrar.Controls.Add(this.txtTelefono);
            this.pnlRegistrar.Controls.Add(this.txtEmail);
            this.pnlRegistrar.Controls.Add(this.btnRegistrar);
            this.pnlRegistrar.Controls.Add(this.label5);
            this.pnlRegistrar.Controls.Add(this.label4);
            this.pnlRegistrar.Controls.Add(this.label3);
            this.pnlRegistrar.Controls.Add(this.lblNombre);
            this.pnlRegistrar.Controls.Add(this.label1);
            this.pnlRegistrar.Location = new System.Drawing.Point(472, 1);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.Size = new System.Drawing.Size(576, 821);
            this.pnlRegistrar.TabIndex = 0;
            this.pnlRegistrar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistrar_Paint);
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.Location = new System.Drawing.Point(151, 253);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(270, 38);
            this.btnGuardarImagen.TabIndex = 11;
            this.btnGuardarImagen.Text = "CargarImagen";
            this.btnGuardarImagen.UseVisualStyleBackColor = true;
            this.btnGuardarImagen.Click += new System.EventHandler(this.btnGuardarImagen_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(137, 66);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(294, 170);
            this.pbImagen.TabIndex = 10;
            this.pbImagen.TabStop = false;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(28, 367);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.ShortcutsEnabled = false;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(504, 34);
            this.txtNombreEmpresa.TabIndex = 9;
            // 
            // txtDirreccionEmpresa
            // 
            this.txtDirreccionEmpresa.Location = new System.Drawing.Point(28, 433);
            this.txtDirreccionEmpresa.Name = "txtDirreccionEmpresa";
            this.txtDirreccionEmpresa.ShortcutsEnabled = false;
            this.txtDirreccionEmpresa.Size = new System.Drawing.Size(504, 34);
            this.txtDirreccionEmpresa.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(28, 500);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(504, 34);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(28, 567);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(504, 34);
            this.txtEmail.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(57, 688);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(466, 70);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email de la empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "telefono de la empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion de la empresa";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 335);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(261, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre de la empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuracion de empresa";
            // 
            // frmConfiguracionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::vistas.Properties.Resources.fondo_de_cafe;
            this.ClientSize = new System.Drawing.Size(1585, 822);
            this.Controls.Add(this.pnlRegistrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmConfiguracionEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiguracionEmpresa";
            this.Load += new System.EventHandler(this.frmConfiguracionEmpresa_Load);
            this.pnlRegistrar.ResumeLayout(false);
            this.pnlRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.TextBox txtDirreccionEmpresa;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnGuardarImagen;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}