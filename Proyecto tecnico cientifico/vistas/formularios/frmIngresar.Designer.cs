namespace vistas.formularios
{
    partial class frmIngresar
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtIngresarEmail = new System.Windows.Forms.TextBox();
            this.txtIngresarContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.lblOlvidaste = new System.Windows.Forms.LinkLabel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIngresarEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIngresarContraseña, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblContraseña, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnIngresar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblOlvidaste, 0, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(272, 66);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.54237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.45763F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 769);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(579, 59);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(135, 51);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Gmail";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIngresarEmail
            // 
            this.txtIngresarEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtIngresarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarEmail.Location = new System.Drawing.Point(33, 122);
            this.txtIngresarEmail.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.txtIngresarEmail.Multiline = true;
            this.txtIngresarEmail.Name = "txtIngresarEmail";
            this.txtIngresarEmail.ShortcutsEnabled = false;
            this.txtIngresarEmail.Size = new System.Drawing.Size(1227, 76);
            this.txtIngresarEmail.TabIndex = 3;
            this.txtIngresarEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIngresarEmail.TextChanged += new System.EventHandler(this.txtIngresarUsuario_TextChanged);
            // 
            // txtIngresarContraseña
            // 
            this.txtIngresarContraseña.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtIngresarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarContraseña.Location = new System.Drawing.Point(37, 333);
            this.txtIngresarContraseña.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.txtIngresarContraseña.Multiline = true;
            this.txtIngresarContraseña.Name = "txtIngresarContraseña";
            this.txtIngresarContraseña.PasswordChar = '*';
            this.txtIngresarContraseña.ShortcutsEnabled = false;
            this.txtIngresarContraseña.Size = new System.Drawing.Size(1219, 92);
            this.txtIngresarContraseña.TabIndex = 4;
            this.txtIngresarContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(524, 241);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(245, 51);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(297, 469);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(699, 149);
            this.BtnIngresar.TabIndex = 0;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // lblOlvidaste
            // 
            this.lblOlvidaste.ActiveLinkColor = System.Drawing.Color.White;
            this.lblOlvidaste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOlvidaste.AutoSize = true;
            this.lblOlvidaste.LinkColor = System.Drawing.Color.Black;
            this.lblOlvidaste.Location = new System.Drawing.Point(533, 697);
            this.lblOlvidaste.Name = "lblOlvidaste";
            this.lblOlvidaste.Size = new System.Drawing.Size(228, 25);
            this.lblOlvidaste.TabIndex = 5;
            this.lblOlvidaste.TabStop = true;
            this.lblOlvidaste.Text = "Olvidaste tu contraseña?";
            this.lblOlvidaste.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvidaste_LinkClicked);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(391, 1687);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(513, 233);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::vistas.Properties.Resources.fondo_de_cafe;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1859, 977);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(50, 849);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(311, 96);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "salir";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 977);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Name = "frmIngresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresar";
            this.Load += new System.EventHandler(this.frmIngresar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtIngresarEmail;
        private System.Windows.Forms.TextBox txtIngresarContraseña;
        private System.Windows.Forms.Button btnSalir;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.LinkLabel lblOlvidaste;
    }
}