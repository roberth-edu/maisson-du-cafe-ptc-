namespace vistas.formularios
{
    partial class frmEmpleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnPaginaPrincipal = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTresPuntos = new FontAwesome.Sharp.IconButton();
            this.lnlTitulo = new System.Windows.Forms.Label();
            this.dgvGraficoEmpleado = new System.Windows.Forms.DataGridView();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmailEmpleado = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaEmpleado = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraficoEmpleado)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.btnGastos);
            this.panel1.Controls.Add(this.btnPaginaPrincipal);
            this.panel1.Controls.Add(this.pbImagen);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 1119);
            this.panel1.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Beige;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Calibri", 16.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnEmpleados.Location = new System.Drawing.Point(20, 833);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(288, 104);
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
            this.btnMenu.Location = new System.Drawing.Point(20, 682);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(288, 104);
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
            this.btnInventario.Location = new System.Drawing.Point(20, 526);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(288, 104);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.BackColor = System.Drawing.Color.Moccasin;
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnGastos.Location = new System.Drawing.Point(20, 379);
            this.btnGastos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(288, 104);
            this.btnGastos.TabIndex = 2;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnPaginaPrincipal
            // 
            this.btnPaginaPrincipal.BackColor = System.Drawing.Color.Moccasin;
            this.btnPaginaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaPrincipal.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPaginaPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnPaginaPrincipal.Location = new System.Drawing.Point(20, 223);
            this.btnPaginaPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaginaPrincipal.Name = "btnPaginaPrincipal";
            this.btnPaginaPrincipal.Size = new System.Drawing.Size(288, 104);
            this.btnPaginaPrincipal.TabIndex = 1;
            this.btnPaginaPrincipal.Text = "Pagina Principal";
            this.btnPaginaPrincipal.UseVisualStyleBackColor = false;
            this.btnPaginaPrincipal.Click += new System.EventHandler(this.btnPaginaPrincipal_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::vistas.Properties.Resources.image_removebg_preview;
            this.pbImagen.Location = new System.Drawing.Point(-1, -1);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(334, 159);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(136)))), ((int)(((byte)(103)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTresPuntos);
            this.panel2.Controls.Add(this.lnlTitulo);
            this.panel2.Location = new System.Drawing.Point(336, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 157);
            this.panel2.TabIndex = 1;
            // 
            // btnTresPuntos
            // 
            this.btnTresPuntos.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnTresPuntos.IconColor = System.Drawing.Color.Black;
            this.btnTresPuntos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTresPuntos.Location = new System.Drawing.Point(1424, 31);
            this.btnTresPuntos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnTresPuntos.Name = "btnTresPuntos";
            this.btnTresPuntos.Size = new System.Drawing.Size(105, 109);
            this.btnTresPuntos.TabIndex = 8;
            this.btnTresPuntos.UseVisualStyleBackColor = true;
            this.btnTresPuntos.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lnlTitulo
            // 
            this.lnlTitulo.AutoSize = true;
            this.lnlTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lnlTitulo.Location = new System.Drawing.Point(582, 65);
            this.lnlTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnlTitulo.Name = "lnlTitulo";
            this.lnlTitulo.Size = new System.Drawing.Size(335, 38);
            this.lnlTitulo.TabIndex = 0;
            this.lnlTitulo.Text = "Pagina de Empleados";
            // 
            // dgvGraficoEmpleado
            // 
            this.dgvGraficoEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGraficoEmpleado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGraficoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGraficoEmpleado.Location = new System.Drawing.Point(402, 629);
            this.dgvGraficoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGraficoEmpleado.Name = "dgvGraficoEmpleado";
            this.dgvGraficoEmpleado.ReadOnly = true;
            this.dgvGraficoEmpleado.RowHeadersWidth = 51;
            this.dgvGraficoEmpleado.RowTemplate.Height = 24;
            this.dgvGraficoEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGraficoEmpleado.Size = new System.Drawing.Size(1475, 339);
            this.dgvGraficoEmpleado.TabIndex = 2;
            this.dgvGraficoEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGraficoEmpleado_CellContentClick);
            this.dgvGraficoEmpleado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGraficoEmpleado_CellFormatting);
            this.dgvGraficoEmpleado.DoubleClick += new System.EventHandler(this.dgvGraficoEmpleado_DoubleClick);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.Moccasin;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(98, 91);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ShortcutsEnabled = false;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(275, 41);
            this.txtNombreEmpleado.TabIndex = 3;
            this.txtNombreEmpleado.TextChanged += new System.EventHandler(this.txtNombreEmpleado_TextChanged);
            this.txtNombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmpleado_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Moccasin;
            this.txtTelefono.Location = new System.Drawing.Point(532, 91);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(277, 41);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.BackColor = System.Drawing.Color.Moccasin;
            this.txtEmailEmpleado.Location = new System.Drawing.Point(1071, 91);
            this.txtEmailEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.ShortcutsEnabled = false;
            this.txtEmailEmpleado.Size = new System.Drawing.Size(277, 41);
            this.txtEmailEmpleado.TabIndex = 5;
            this.txtEmailEmpleado.TextChanged += new System.EventHandler(this.txtEmailEmpleado_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Moccasin;
            this.txtContraseña.Location = new System.Drawing.Point(98, 222);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(275, 41);
            this.txtContraseña.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnActualizar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbRol);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnAgregarEmpleado);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtpFechaEmpleado);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.txtContraseña);
            this.panel3.Controls.Add(this.txtNombreEmpleado);
            this.panel3.Controls.Add(this.txtEmailEmpleado);
            this.panel3.Location = new System.Drawing.Point(402, 213);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1475, 407);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Moccasin;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnActualizar.IconColor = System.Drawing.Color.Black;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.Location = new System.Drawing.Point(523, 317);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(405, 84);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1107, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rol";
            // 
            // cbRol
            // 
            this.cbRol.BackColor = System.Drawing.Color.Moccasin;
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "jefe",
            "empleado"});
            this.cbRol.Location = new System.Drawing.Point(1096, 219);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(299, 44);
            this.cbRol.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Moccasin;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(1045, 317);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(404, 84);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "EliminarEmpledo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.Moccasin;
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.IconChar = FontAwesome.Sharp.IconChar.PersonRays;
            this.btnAgregarEmpleado.IconColor = System.Drawing.Color.Black;
            this.btnAgregarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(24, 317);
            this.btnAgregarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(405, 84);
            this.btnAgregarEmpleado.TabIndex = 13;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de inicio de contrato";
            // 
            // dtpFechaEmpleado
            // 
            this.dtpFechaEmpleado.Location = new System.Drawing.Point(532, 222);
            this.dtpFechaEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEmpleado.Name = "dtpFechaEmpleado";
            this.dtpFechaEmpleado.Size = new System.Drawing.Size(509, 41);
            this.dtpFechaEmpleado.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1064, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(98, 37);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(257, 36);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre empleado";
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCerrarSesion.Controls.Add(this.btnCerrarSesion);
            this.pnlCerrarSesion.Location = new System.Drawing.Point(1606, 169);
            this.pnlCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Size = new System.Drawing.Size(282, 143);
            this.pnlCerrarSesion.TabIndex = 9;
            this.pnlCerrarSesion.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(38, 37);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(207, 62);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1924, 1021);
            this.Controls.Add(this.pnlCerrarSesion);
            this.Controls.Add(this.dgvGraficoEmpleado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraficoEmpleado)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlCerrarSesion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnPaginaPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lnlTitulo;
        private System.Windows.Forms.DataGridView dgvGraficoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmailEmpleado;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton btnAgregarEmpleado;
        private FontAwesome.Sharp.IconButton btnTresPuntos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRol;
        private FontAwesome.Sharp.IconButton btnActualizar;
    }
}