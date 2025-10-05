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
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            this.FormClosing += (sender, e) => Application.Exit();
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 20;
            if (txtNombre.Text.Length == txtNombre.MaxLength)
            {
                MessageBox.Show("Máximo de caracteres alcanzado");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
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
        private void frmMenu_Load(object sender, EventArgs e)
        {
            pbImagen.Image = BytesToImage(DatosGlobales.imagen);
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            dtpFecha.Value = DateTime.Today;
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.MaxDate = DateTime.Today;
            dtpFecha.Enabled = false;
            MostrarMenu();
            ConfigurarImagen();
        }

        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal paginaPrincipal = new frmPaginaPrincipal(); 
            paginaPrincipal.Show();
            this.Hide(); 
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            frmGastos frmGastos = new frmGastos();
            frmGastos.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventarioOpciones frmInventario = new frmInventarioOpciones();
            frmInventario.Show();
            this.Hide();

        }
        private void MostrarMenu()
        {
            DataTable dataTable = menu.CargarMenu();
            dgvMenu.DataSource = dataTable;
            if (dgvMenu.Columns.Contains("idDetalleVenta"))
            {
                dgvMenu.Columns["idDetalleVenta"].Visible = false;
            }

            if (dgvProductos.Columns.Contains("idDetalleVenta"))
            {
                dgvProductos.Columns["idDetalleVenta"].Visible = false;
            }

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty (txtNombre.Text))
            {
                MessageBox.Show("ingresar un nombre");
                return;
            }
            if (!double.TryParse(txtPrecio.Text, out double pre))
            {
                MessageBox.Show("ingresar un precio valido");
                return;
            }
            if (double.TryParse(txtPrecio.Text, out double precio))
            {
                
                if (precio <= 0)
                {
                    MessageBox.Show(" El precio debe ser mayor a 0",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return; 
                }
            }


            


            menu nuevoMenu = new menu();
            nuevoMenu.Nombre = txtNombre.Text;
            nuevoMenu.Precio1 = precio;
            nuevoMenu.FechaCreacion = DateTime.Today;
            nuevoMenu.InsertarMenu();
            MostrarMenu();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                int idVenta = Convert.ToInt32(dgvMenu.SelectedRows[0].Cells["idDetalleVenta"].Value);
                var menu = new menu() { IdItemMenu = idVenta };
                if (menu.eliminarMenu())
                {
                    dgvMenu.DataSource = menu.CargarMenu() ;
                }
            }
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
            this.Hide();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnNumero2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            pnlCerrar.Visible = ! pnlCerrar.Visible;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmIngresar frmIngresar = new frmIngresar();
            frmIngresar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIngresar frmIngresar = new frmIngresar();
            frmIngresar.Show();
            this.Hide();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("por favor seleccionar un producto");
                    return;
                }

                DataGridViewRow fila = dgvMenu.SelectedRows[0];

                if (fila.IsNewRow) return;

                object[] valores = new object[fila.Cells.Count];
                
                for (int i = 0; i < fila.Cells.Count; i++)
                {
                    valores[i] = fila.Cells[i].Value;
                }

                dgvProductos.Rows.Add(valores);
            }
            catch (Exception es)
            {

                MessageBox.Show("Error al agregar producto: " + es.Message);
            }


        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el producto.");
                return;

            }
            if (!double.TryParse(txtPrecio.Text, out double precio) || precio <= 0)
            {
                if (precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor a 0",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return; // Detener la ejecución
                }
                MessageBox.Show("Por favor, ingrese un precio para el producto.");
                return;
            }

            //restringciones
            menu m = new menu();
            m.Nombre = txtNombre.Text;
            m.Precio1 = double.Parse(txtPrecio.Text);
            if (dtpFecha.Value < DateTime.Today)
            {
                m.FechaCreacion = dtpFecha.MinDate = DateTime.Today;
                MessageBox.Show("No se pueden seleccionar fechas pasadas");
                return;
            }
            if (dtpFecha.Value > DateTime.Now)
            {
                m.FechaCreacion = dtpFecha.MaxDate = DateTime.Today;
                MessageBox.Show("no ingresar fechas futuras");
                return;
            }
            else
            {
                m.FechaCreacion = dtpFecha.MinDate = DateTime.Today;
            }



            m.IdItemMenu = int.Parse(dgvMenu.CurrentRow.Cells[0].Value.ToString());

            if (m.actualizarMenu() == true)
            {
                MessageBox.Show("producto actualizado correctamente");
                MostrarMenu();

            }
        }

        private void dgvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvMenu.SelectedRows[0];
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtPrecio.Text = fila.Cells["precio"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.");

            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();
            

            if (dgvProductos.Rows.Count == 1)
            {
                MessageBox.Show("No hay productos para pagar.");
                return;
            }

            double total = 0;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                //sacar el precio y el nombre y la cantidad de veces que el nombre es usado, es nuestra mausqueramienta
                if (row.Cells["Precio"].Value != null || row.Cells["nombre"].Value != null)
                {
                    string nombre = row.Cells["nombre"].Value.ToString();
                    double precio = Convert.ToDouble(row.Cells["Precio"].Value);
                    total += precio;

                    if (contador.ContainsKey(nombre))
                    {
                        contador[nombre]++;
                    }
                    else
                    {
                        contador.Add(nombre, 1);
                    }
                        
                }
            }
            //sacar favorito para esto es la mausqueramienta
            string favorito = "Ninguno";
            int maxVeces = 0;
            //foreach sirve para repasar todas las filas del datagrimview
            foreach (var producto in contador)
            {
                if (producto.Value > maxVeces)
                {
                    favorito = producto.Key;
                    maxVeces = producto.Value;
                }
            }


            txtPrecioTotal.Text = total.ToString("C2"); 
            MessageBox.Show("Total a pagar: " + total.ToString("C2"));

            dgvProductos.Rows.Clear();
            DatosGlobales.ProductoFavorito = favorito;
            DatosGlobales.clientes++;
            DatosGlobales.TotalVendidoAcumulado += total;

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.MaxLength = 5;
            if (txtPrecio.Text.Length == txtPrecio.MaxLength)
            {
                MessageBox.Show("Máximo de caracteres alcanzado");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla
            }
        }
    }
}
