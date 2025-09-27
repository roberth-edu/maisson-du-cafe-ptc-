namespace vistas.formularios
{
    partial class frmPaginaPrincipal
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
            this.pnlBarraLateral = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnGasto = new System.Windows.Forms.Button();
            this.btnPaginaPrincipal = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlBarraSuperioPP = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlGanadoHoy = new System.Windows.Forms.Panel();
            this.txtVendido = new System.Windows.Forms.TextBox();
            this.pnlSuperiorGanadoHoy = new System.Windows.Forms.Panel();
            this.lblVendidoHoy = new System.Windows.Forms.Label();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.pnlSuperiorClientes = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pnlProductoFavorito = new System.Windows.Forms.Panel();
            this.txtFav = new System.Windows.Forms.TextBox();
            this.pnlSuperiorProducto = new System.Windows.Forms.Panel();
            this.lblProductoFav = new System.Windows.Forms.Label();
            this.ctGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlBarraLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlBarraSuperioPP.SuspendLayout();
            this.pnlGanadoHoy.SuspendLayout();
            this.pnlSuperiorGanadoHoy.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlSuperiorClientes.SuspendLayout();
            this.pnlProductoFavorito.SuspendLayout();
            this.pnlSuperiorProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrafico)).BeginInit();
            this.pnlCerrarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraLateral
            // 
            this.pnlBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.pnlBarraLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraLateral.Controls.Add(this.btnEmpleados);
            this.pnlBarraLateral.Controls.Add(this.btnMenu);
            this.pnlBarraLateral.Controls.Add(this.btnInventario);
            this.pnlBarraLateral.Controls.Add(this.btnGasto);
            this.pnlBarraLateral.Controls.Add(this.btnPaginaPrincipal);
            this.pnlBarraLateral.Controls.Add(this.pbLogo);
            this.pnlBarraLateral.Location = new System.Drawing.Point(-3, 1);
            this.pnlBarraLateral.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlBarraLateral.Name = "pnlBarraLateral";
            this.pnlBarraLateral.Size = new System.Drawing.Size(363, 998);
            this.pnlBarraLateral.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Moccasin;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnEmpleados.Location = new System.Drawing.Point(39, 832);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(288, 108);
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Moccasin;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnMenu.Location = new System.Drawing.Point(39, 675);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(288, 108);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Moccasin;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnInventario.Location = new System.Drawing.Point(39, 523);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(288, 108);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click_1);
            // 
            // btnGasto
            // 
            this.btnGasto.BackColor = System.Drawing.Color.Moccasin;
            this.btnGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGasto.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnGasto.Location = new System.Drawing.Point(39, 365);
            this.btnGasto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGasto.Name = "btnGasto";
            this.btnGasto.Size = new System.Drawing.Size(288, 108);
            this.btnGasto.TabIndex = 2;
            this.btnGasto.Text = "Gastos";
            this.btnGasto.UseVisualStyleBackColor = false;
            this.btnGasto.Click += new System.EventHandler(this.btnGasto_Click);
            // 
            // btnPaginaPrincipal
            // 
            this.btnPaginaPrincipal.BackColor = System.Drawing.Color.Beige;
            this.btnPaginaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaPrincipal.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnPaginaPrincipal.Location = new System.Drawing.Point(39, 216);
            this.btnPaginaPrincipal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPaginaPrincipal.Name = "btnPaginaPrincipal";
            this.btnPaginaPrincipal.Size = new System.Drawing.Size(288, 104);
            this.btnPaginaPrincipal.TabIndex = 1;
            this.btnPaginaPrincipal.Text = "Pagina principal";
            this.btnPaginaPrincipal.UseVisualStyleBackColor = false;
            this.btnPaginaPrincipal.Click += new System.EventHandler(this.btnPaginaPrincipal_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.Image = global::vistas.Properties.Resources.image_removebg_preview;
            this.pbLogo.Location = new System.Drawing.Point(0, -1);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(362, 158);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlBarraSuperioPP
            // 
            this.pnlBarraSuperioPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.pnlBarraSuperioPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraSuperioPP.Controls.Add(this.iconButton1);
            this.pnlBarraSuperioPP.Controls.Add(this.btnSalir);
            this.pnlBarraSuperioPP.Controls.Add(this.lblTitulo);
            this.pnlBarraSuperioPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBarraSuperioPP.Location = new System.Drawing.Point(359, 1);
            this.pnlBarraSuperioPP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlBarraSuperioPP.Name = "pnlBarraSuperioPP";
            this.pnlBarraSuperioPP.Size = new System.Drawing.Size(1563, 158);
            this.pnlBarraSuperioPP.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1383, 30);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(99, 94);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(1605, 48);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 107);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.lblTitulo.Location = new System.Drawing.Point(676, 63);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(248, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pagina principal";
            // 
            // pnlGanadoHoy
            // 
            this.pnlGanadoHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(188)))), ((int)(((byte)(149)))));
            this.pnlGanadoHoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGanadoHoy.Controls.Add(this.txtVendido);
            this.pnlGanadoHoy.Controls.Add(this.pnlSuperiorGanadoHoy);
            this.pnlGanadoHoy.Location = new System.Drawing.Point(454, 185);
            this.pnlGanadoHoy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlGanadoHoy.Name = "pnlGanadoHoy";
            this.pnlGanadoHoy.Size = new System.Drawing.Size(351, 236);
            this.pnlGanadoHoy.TabIndex = 2;
            // 
            // txtVendido
            // 
            this.txtVendido.BackColor = System.Drawing.Color.Moccasin;
            this.txtVendido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendido.Location = new System.Drawing.Point(23, 128);
            this.txtVendido.Name = "txtVendido";
            this.txtVendido.ReadOnly = true;
            this.txtVendido.Size = new System.Drawing.Size(297, 38);
            this.txtVendido.TabIndex = 3;
            this.txtVendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVendido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlSuperiorGanadoHoy
            // 
            this.pnlSuperiorGanadoHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.pnlSuperiorGanadoHoy.Controls.Add(this.lblVendidoHoy);
            this.pnlSuperiorGanadoHoy.Location = new System.Drawing.Point(-1, -1);
            this.pnlSuperiorGanadoHoy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlSuperiorGanadoHoy.Name = "pnlSuperiorGanadoHoy";
            this.pnlSuperiorGanadoHoy.Size = new System.Drawing.Size(351, 82);
            this.pnlSuperiorGanadoHoy.TabIndex = 2;
            this.pnlSuperiorGanadoHoy.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblVendidoHoy
            // 
            this.lblVendidoHoy.AutoSize = true;
            this.lblVendidoHoy.BackColor = System.Drawing.Color.Transparent;
            this.lblVendidoHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendidoHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.lblVendidoHoy.Location = new System.Drawing.Point(81, 33);
            this.lblVendidoHoy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVendidoHoy.Name = "lblVendidoHoy";
            this.lblVendidoHoy.Size = new System.Drawing.Size(184, 36);
            this.lblVendidoHoy.TabIndex = 0;
            this.lblVendidoHoy.Text = "Vendido hoy";
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(188)))), ((int)(((byte)(149)))));
            this.pnlClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientes.Controls.Add(this.txtClientes);
            this.pnlClientes.Controls.Add(this.pnlSuperiorClientes);
            this.pnlClientes.Location = new System.Drawing.Point(971, 185);
            this.pnlClientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(353, 236);
            this.pnlClientes.TabIndex = 3;
            // 
            // txtClientes
            // 
            this.txtClientes.BackColor = System.Drawing.Color.Moccasin;
            this.txtClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientes.Location = new System.Drawing.Point(27, 129);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.ReadOnly = true;
            this.txtClientes.Size = new System.Drawing.Size(297, 38);
            this.txtClientes.TabIndex = 4;
            this.txtClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlSuperiorClientes
            // 
            this.pnlSuperiorClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.pnlSuperiorClientes.Controls.Add(this.lblClientes);
            this.pnlSuperiorClientes.Location = new System.Drawing.Point(-3, -1);
            this.pnlSuperiorClientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlSuperiorClientes.Name = "pnlSuperiorClientes";
            this.pnlSuperiorClientes.Size = new System.Drawing.Size(355, 82);
            this.pnlSuperiorClientes.TabIndex = 3;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.lblClientes.Location = new System.Drawing.Point(120, 33);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(135, 38);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "Clientes";
            // 
            // pnlProductoFavorito
            // 
            this.pnlProductoFavorito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(188)))), ((int)(((byte)(149)))));
            this.pnlProductoFavorito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductoFavorito.Controls.Add(this.txtFav);
            this.pnlProductoFavorito.Controls.Add(this.pnlSuperiorProducto);
            this.pnlProductoFavorito.Location = new System.Drawing.Point(1474, 185);
            this.pnlProductoFavorito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlProductoFavorito.Name = "pnlProductoFavorito";
            this.pnlProductoFavorito.Size = new System.Drawing.Size(356, 236);
            this.pnlProductoFavorito.TabIndex = 3;
            // 
            // txtFav
            // 
            this.txtFav.BackColor = System.Drawing.Color.Moccasin;
            this.txtFav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFav.Location = new System.Drawing.Point(21, 129);
            this.txtFav.Name = "txtFav";
            this.txtFav.ReadOnly = true;
            this.txtFav.Size = new System.Drawing.Size(312, 38);
            this.txtFav.TabIndex = 5;
            this.txtFav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlSuperiorProducto
            // 
            this.pnlSuperiorProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.pnlSuperiorProducto.Controls.Add(this.lblProductoFav);
            this.pnlSuperiorProducto.Location = new System.Drawing.Point(-1, -1);
            this.pnlSuperiorProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlSuperiorProducto.Name = "pnlSuperiorProducto";
            this.pnlSuperiorProducto.Size = new System.Drawing.Size(356, 82);
            this.pnlSuperiorProducto.TabIndex = 4;
            // 
            // lblProductoFav
            // 
            this.lblProductoFav.AutoSize = true;
            this.lblProductoFav.BackColor = System.Drawing.Color.Transparent;
            this.lblProductoFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoFav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.lblProductoFav.Location = new System.Drawing.Point(94, 19);
            this.lblProductoFav.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductoFav.Name = "lblProductoFav";
            this.lblProductoFav.Size = new System.Drawing.Size(212, 38);
            this.lblProductoFav.TabIndex = 2;
            this.lblProductoFav.Text = "Producto Fav";
            // 
            // ctGrafico
            // 
            this.ctGrafico.BackColor = System.Drawing.Color.AntiqueWhite;
            chartArea1.Name = "ChartArea1";
            this.ctGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ctGrafico.Legends.Add(legend1);
            this.ctGrafico.Location = new System.Drawing.Point(796, 509);
            this.ctGrafico.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctGrafico.Name = "ctGrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ctGrafico.Series.Add(series1);
            this.ctGrafico.Size = new System.Drawing.Size(773, 423);
            this.ctGrafico.TabIndex = 4;
            this.ctGrafico.Text = "chart1";
            this.ctGrafico.Click += new System.EventHandler(this.ctGrafico_Click);
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.pnlCerrarSesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCerrarSesion.Controls.Add(this.btnCerrarSesion);
            this.pnlCerrarSesion.Location = new System.Drawing.Point(1603, 167);
            this.pnlCerrarSesion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Size = new System.Drawing.Size(319, 140);
            this.pnlCerrarSesion.TabIndex = 4;
            this.pnlCerrarSesion.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(43, 37);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(235, 61);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1924, 999);
            this.Controls.Add(this.pnlCerrarSesion);
            this.Controls.Add(this.ctGrafico);
            this.Controls.Add(this.pnlProductoFavorito);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.pnlGanadoHoy);
            this.Controls.Add(this.pnlBarraLateral);
            this.Controls.Add(this.pnlBarraSuperioPP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "frmPaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paginaPrincipal";
            this.Load += new System.EventHandler(this.paginaPrincipal_Load);
            this.pnlBarraLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlBarraSuperioPP.ResumeLayout(false);
            this.pnlBarraSuperioPP.PerformLayout();
            this.pnlGanadoHoy.ResumeLayout(false);
            this.pnlGanadoHoy.PerformLayout();
            this.pnlSuperiorGanadoHoy.ResumeLayout(false);
            this.pnlSuperiorGanadoHoy.PerformLayout();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            this.pnlSuperiorClientes.ResumeLayout(false);
            this.pnlSuperiorClientes.PerformLayout();
            this.pnlProductoFavorito.ResumeLayout(false);
            this.pnlProductoFavorito.PerformLayout();
            this.pnlSuperiorProducto.ResumeLayout(false);
            this.pnlSuperiorProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrafico)).EndInit();
            this.pnlCerrarSesion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraLateral;
        private System.Windows.Forms.Panel pnlBarraSuperioPP;
        private System.Windows.Forms.Panel pnlGanadoHoy;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Panel pnlProductoFavorito;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctGrafico;
        private System.Windows.Forms.Button btnPaginaPrincipal;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnGasto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVendidoHoy;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblProductoFav;
        private System.Windows.Forms.Panel pnlSuperiorGanadoHoy;
        private System.Windows.Forms.Panel pnlSuperiorClientes;
        private System.Windows.Forms.Panel pnlSuperiorProducto;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtVendido;
        private System.Windows.Forms.TextBox txtClientes;
        private System.Windows.Forms.TextBox txtFav;
    }
}