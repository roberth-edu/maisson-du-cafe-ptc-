namespace vistas.formularios
{
    partial class frmOlvidasteLaContra
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
            this.txtRecuperar = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(302, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Correo";
            // 
            // txtRecuperar
            // 
            this.txtRecuperar.Location = new System.Drawing.Point(123, 235);
            this.txtRecuperar.Margin = new System.Windows.Forms.Padding(5);
            this.txtRecuperar.Multiline = true;
            this.txtRecuperar.Name = "txtRecuperar";
            this.txtRecuperar.ShortcutsEnabled = false;
            this.txtRecuperar.Size = new System.Drawing.Size(891, 62);
            this.txtRecuperar.TabIndex = 1;
            this.txtRecuperar.TextChanged += new System.EventHandler(this.txtRecuperar_TextChanged);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.Color.Moccasin;
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Location = new System.Drawing.Point(162, 375);
            this.btnRecuperar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(790, 136);
            this.btnRecuperar.TabIndex = 2;
            this.btnRecuperar.Text = "Recuperar Contraseña";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(37, 595);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(193, 89);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmOlvidasteLaContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::vistas.Properties.Resources.fondo_de_cafe;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.txtRecuperar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmOlvidasteLaContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOlvidasteLaContra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecuperar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnRegresar;
    }
}