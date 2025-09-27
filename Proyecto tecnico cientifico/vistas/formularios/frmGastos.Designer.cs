namespace vistas.formularios
{
    partial class frmGastos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPaginaEmpleado = new System.Windows.Forms.Button();
            this.btnPaginaMenu = new System.Windows.Forms.Button();
            this.btnPaginaInventario = new System.Windows.Forms.Button();
            this.btnPaginaGastos = new System.Windows.Forms.Button();
            this.btnPaginaPrincipal = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.lblPaginaGasto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.ctGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtBeneficio = new System.Windows.Forms.TextBox();
            this.lblBeneficio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrafico)).BeginInit();
            this.panel6.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPaginaEmpleado);
            this.panel1.Controls.Add(this.btnPaginaMenu);
            this.panel1.Controls.Add(this.btnPaginaInventario);
            this.panel1.Controls.Add(this.btnPaginaGastos);
            this.panel1.Controls.Add(this.btnPaginaPrincipal);
            this.panel1.Controls.Add(this.pbImagen);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 998);
            this.panel1.TabIndex = 0;
            // 
            // btnPaginaEmpleado
            // 
            this.btnPaginaEmpleado.BackColor = System.Drawing.Color.Moccasin;
            this.btnPaginaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaEmpleado.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPaginaEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnPaginaEmpleado.Location = new System.Drawing.Point(38, 833);
            this.btnPaginaEmpleado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPaginaEmpleado.Name = "btnPaginaEmpleado";
            this.btnPaginaEmpleado.Size = new System.Drawing.Size(288, 104);
            this.btnPaginaEmpleado.TabIndex = 5;
            this.btnPaginaEmpleado.Text = "Empleado";
            this.btnPaginaEmpleado.UseVisualStyleBackColor = false;
            this.btnPaginaEmpleado.Click += new System.EventHandler(this.btnPaginaEmpleado_Click);
            // 
            // btnPaginaMenu
            // 
            this.btnPaginaMenu.BackColor = System.Drawing.Color.Moccasin;
            this.btnPaginaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaMenu.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPaginaMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnPaginaMenu.Location = new System.Drawing.Point(38, 682);
            this.btnPaginaMenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPaginaMenu.Name = "btnPaginaMenu";
            this.btnPaginaMenu.Size = new System.Drawing.Size(288, 104);
            this.btnPaginaMenu.TabIndex = 4;
            this.btnPaginaMenu.Text = "Menu";
            this.btnPaginaMenu.UseVisualStyleBackColor = false;
            this.btnPaginaMenu.Click += new System.EventHandler(this.btnPaginaMenu_Click);
            // 
            // btnPaginaInventario
            // 
            this.btnPaginaInventario.BackColor = System.Drawing.Color.Moccasin;
            this.btnPaginaInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaInventario.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPaginaInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnPaginaInventario.Location = new System.Drawing.Point(38, 530);
            this.btnPaginaInventario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPaginaInventario.Name = "btnPaginaInventario";
            this.btnPaginaInventario.Size = new System.Drawing.Size(288, 104);
            this.btnPaginaInventario.TabIndex = 3;
            this.btnPaginaInventario.Text = "Inventario";
            this.btnPaginaInventario.UseVisualStyleBackColor = false;
            this.btnPaginaInventario.Click += new System.EventHandler(this.btnPaginaInventario_Click);
            // 
            // btnPaginaGastos
            // 
            this.btnPaginaGastos.BackColor = System.Drawing.Color.Beige;
            this.btnPaginaGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaGastos.Font = new System.Drawing.Font("Calibri", 16.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnPaginaGastos.Location = new System.Drawing.Point(38, 380);
            this.btnPaginaGastos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPaginaGastos.Name = "btnPaginaGastos";
            this.btnPaginaGastos.Size = new System.Drawing.Size(288, 104);
            this.btnPaginaGastos.TabIndex = 2;
            this.btnPaginaGastos.Text = "gastos";
            this.btnPaginaGastos.UseVisualStyleBackColor = false;
            // 
            // btnPaginaPrincipal
            // 
            this.btnPaginaPrincipal.BackColor = System.Drawing.Color.Moccasin;
            this.btnPaginaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaPrincipal.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPaginaPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnPaginaPrincipal.Location = new System.Drawing.Point(38, 224);
            this.btnPaginaPrincipal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPaginaPrincipal.Name = "btnPaginaPrincipal";
            this.btnPaginaPrincipal.Size = new System.Drawing.Size(288, 104);
            this.btnPaginaPrincipal.TabIndex = 1;
            this.btnPaginaPrincipal.Text = "Pagina principal";
            this.btnPaginaPrincipal.UseVisualStyleBackColor = false;
            this.btnPaginaPrincipal.Click += new System.EventHandler(this.btnPaginaPrincipal_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Image = global::vistas.Properties.Resources.image_removebg_preview;
            this.pbImagen.Location = new System.Drawing.Point(0, 0);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(362, 158);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.lblPaginaGasto);
            this.panel2.Location = new System.Drawing.Point(357, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1566, 159);
            this.panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(1409, 30);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 94);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lblPaginaGasto
            // 
            this.lblPaginaGasto.AutoSize = true;
            this.lblPaginaGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.lblPaginaGasto.Location = new System.Drawing.Point(659, 57);
            this.lblPaginaGasto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaginaGasto.Name = "lblPaginaGasto";
            this.lblPaginaGasto.Size = new System.Drawing.Size(232, 38);
            this.lblPaginaGasto.TabIndex = 0;
            this.lblPaginaGasto.Text = "Pagina Gastos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblImporte);
            this.panel3.Controls.Add(this.lblIngresos);
            this.panel3.Controls.Add(this.btnCalcular);
            this.panel3.Location = new System.Drawing.Point(642, 194);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 198);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtIngresos);
            this.panel5.Location = new System.Drawing.Point(671, 82);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 73);
            this.panel5.TabIndex = 4;
            // 
            // txtIngresos
            // 
            this.txtIngresos.BackColor = System.Drawing.Color.Moccasin;
            this.txtIngresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngresos.Location = new System.Drawing.Point(-1, -1);
            this.txtIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngresos.Multiline = true;
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.ReadOnly = true;
            this.txtIngresos.Size = new System.Drawing.Size(208, 72);
            this.txtIngresos.TabIndex = 1;
            this.txtIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIngresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresos_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtImporte);
            this.panel4.Location = new System.Drawing.Point(47, 82);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 73);
            this.panel4.TabIndex = 3;
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.Color.Moccasin;
            this.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImporte.Location = new System.Drawing.Point(-1, -1);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.Multiline = true;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(208, 72);
            this.txtImporte.TabIndex = 0;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(93, 31);
            this.lblImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(109, 32);
            this.lblImporte.TabIndex = 2;
            this.lblImporte.Text = "Importe";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(731, 31);
            this.lblIngresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(122, 32);
            this.lblIngresos.TabIndex = 1;
            this.lblIngresos.Text = "Ingresos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnCalcular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalcular.Location = new System.Drawing.Point(348, 82);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(241, 73);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Location = new System.Drawing.Point(613, 460);
            this.lblGrafico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(106, 32);
            this.lblGrafico.TabIndex = 7;
            this.lblGrafico.Text = "Grafico";
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // ctGrafico
            // 
            this.ctGrafico.BackColor = System.Drawing.Color.AntiqueWhite;
            chartArea1.Name = "ChartArea1";
            this.ctGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ctGrafico.Legends.Add(legend1);
            this.ctGrafico.Location = new System.Drawing.Point(381, 512);
            this.ctGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.ctGrafico.Name = "ctGrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ctGrafico.Series.Add(series1);
            this.ctGrafico.Size = new System.Drawing.Size(678, 409);
            this.ctGrafico.TabIndex = 8;
            this.ctGrafico.Text = "chart1";
            this.ctGrafico.Click += new System.EventHandler(this.ctGrafico_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnlCerrarSesion);
            this.panel6.Location = new System.Drawing.Point(1592, 161);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 124);
            this.panel6.TabIndex = 9;
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.pnlCerrarSesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCerrarSesion.Controls.Add(this.btnCerrarSesion);
            this.pnlCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCerrarSesion.Location = new System.Drawing.Point(0, 0);
            this.pnlCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Size = new System.Drawing.Size(260, 124);
            this.pnlCerrarSesion.TabIndex = 4;
            this.pnlCerrarSesion.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(36, 32);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(195, 53);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.txtBeneficio);
            this.pnlDatos.Controls.Add(this.lblBeneficio);
            this.pnlDatos.Location = new System.Drawing.Point(1122, 570);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(711, 177);
            this.pnlDatos.TabIndex = 10;
            // 
            // txtBeneficio
            // 
            this.txtBeneficio.BackColor = System.Drawing.Color.Moccasin;
            this.txtBeneficio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBeneficio.Location = new System.Drawing.Point(39, 87);
            this.txtBeneficio.Name = "txtBeneficio";
            this.txtBeneficio.ReadOnly = true;
            this.txtBeneficio.Size = new System.Drawing.Size(636, 38);
            this.txtBeneficio.TabIndex = 3;
            // 
            // lblBeneficio
            // 
            this.lblBeneficio.AutoSize = true;
            this.lblBeneficio.Location = new System.Drawing.Point(310, 39);
            this.lblBeneficio.Name = "lblBeneficio";
            this.lblBeneficio.Size = new System.Drawing.Size(133, 32);
            this.lblBeneficio.TabIndex = 0;
            this.lblBeneficio.Text = "Beneficio";
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1924, 999);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.ctGrafico);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frmGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGastos";
            this.Load += new System.EventHandler(this.frmGastos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrafico)).EndInit();
            this.panel6.ResumeLayout(false);
            this.pnlCerrarSesion.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPaginaGasto;
        private System.Windows.Forms.Button btnPaginaPrincipal;
        private System.Windows.Forms.Button btnPaginaMenu;
        private System.Windows.Forms.Button btnPaginaInventario;
        private System.Windows.Forms.Button btnPaginaGastos;
        private System.Windows.Forms.Button btnPaginaEmpleado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblGrafico;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctGrafico;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.TextBox txtImporte;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblBeneficio;
        private System.Windows.Forms.TextBox txtBeneficio;
    }
}