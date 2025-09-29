using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelos.conexion;
using modelos.entidades;


namespace vistas.formularios
{
    public partial class frmInventarioAgregar: Form
    {
        
        public frmInventarioAgregar()
        {
            InitializeComponent();
            this.FormClosing += (cerrar, a) => Application.Exit();
            CargarCategorias();

        }

        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal paginaPrincipal = new frmPaginaPrincipal();
            paginaPrincipal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGastos frmGastos = new frmGastos();
            frmGastos.Show();
            this.Hide();
        }


        public static Image BytesToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void ConfigurarImagen()
        {
            // Configurar PictureBox para que la imagen se adapte
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.BorderStyle = BorderStyle.FixedSingle;
        }
        private void frmInventario_Load(object sender, EventArgs e)
        {
            ConfigurarImagen();
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            pbImagen.Image = BytesToImage(DatosGlobales.imagen);


        }
        private void CargarCategorias()
        {
            cbCategoria.Items.Add("Café");
            cbCategoria.Items.Add("Complementos");
            cbCategoria.SelectedIndex = 0;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value < DateTime.Today)
            {
                MessageBox.Show("No se pueden seleccionar fechas pasadas");
                return;
            }


            if (string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                MessageBox.Show("ingresar nombre");
                return;
            }
            if (string.IsNullOrEmpty(cbCategoria.Text))
            {
                MessageBox.Show("ingresar categoria");
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("ingresar una cantidad valida");
                return;
            }
            if (decimal.TryParse(txtCantidad.Text, out decimal canti))
            {
                // Verificar si el precio es 0 o negativo
                if (canti <= 0)
                {
                    MessageBox.Show(" la cantidad debe ser mayor a 0",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return; // Detener la ejecución
                }
            }
            if (!double.TryParse(txtCosto.Text, out double costo))
            {

                MessageBox.Show("ingresar un costo valido porfavor");
                return;
            }
            if (decimal.TryParse(txtCosto.Text, out decimal cos))
            {
                // Verificar si el precio es 0 o negativo
                if (cos <= 0)
                {
                    MessageBox.Show(" El coso debe ser mayor a 0",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return; // Detener la ejecución
                }
            }
            if (!double.TryParse(txtPrecioUnitario.Text, out double precio))
            {
                MessageBox.Show("ingresar un precio valido");
                return;
            }
            if (decimal.TryParse(txtPrecioUnitario.Text, out decimal preci))
            {
               
                if (preci <= 0)
                {
                    MessageBox.Show(" El precio debe ser mayor a 0",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return; 
                }
            }
            //fin de restricciones 
            try
            {
                //restricciones
                Inventario P = new Inventario();
                P.NombreProducto = txtNombreProducto.Text;
                P.Costo1 = double.Parse(txtCosto.Text);
                P.PrecioUnitario1 = double.Parse(txtPrecioUnitario.Text);
                P.Cantidad1 = int.Parse(txtCantidad.Text);
                P.Categoria = cbCategoria.Text;
                P.Fecha = dtpFecha.Value;
                if (dtpFecha.Value > DateTime.Now)
                {
                    P.Fecha = dtpFecha.MaxDate = DateTime.Today;
                    MessageBox.Show("no ingresar fechas futuras");
                    return;
                }
                P.InsertarProducto();
                MessageBox.Show("producto agregado correctamente");


            }
            catch (Exception)
            {
                
                
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


        private void dvgInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
            this.Hide();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            pnlCerrarSesion.Visible = !pnlCerrarSesion.Visible;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmIngresar frmIngresar = new frmIngresar();
            frmIngresar.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string categoria = cbCategoria.Text;

            if (categoria == "Café")
            {
                var frmCafes = new frmmostrarInventarioCafe();
                frmCafes.Show();
                this.Hide();
            }
            else if (categoria == "Complementos")
            {
                var frmComplementos = new frmMostrarInventarioComplemento();
                frmComplementos.Show();
                this.Hide();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInventarioOpciones frmInventario = new frmInventarioOpciones();
            frmInventario.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            txtPrecioUnitario.MaxLength = 5;
            if (txtPrecioUnitario.Text.Length == txtPrecioUnitario.MaxLength)
            {
                MessageBox.Show("Máximo de caracteres alcanzado");
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla
            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            txtNombreProducto.MaxLength = 15;
            if (txtNombreProducto.Text.Length == txtNombreProducto.MaxLength)
            {
                MessageBox.Show("Máximo de caracteres alcanzado");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            txtCosto.MaxLength = 5;
            if (txtCosto.Text.Length == txtCosto.MaxLength)
            {
                MessageBox.Show("Máximo de caracteres alcanzado");
            }

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
