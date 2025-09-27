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
    public partial class frmMenuEmple: Form
    {
        public frmMenuEmple()
        {
            this.FormClosing += (sender, e) => Application.Exit();
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            pbImagen.Image = BytesToImage(DatosGlobales.imagen);

            MostrarMenu();
            ConfigurarImagen();
        }

        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipalEmpleado paginaPrincipal = new frmPaginaPrincipalEmpleado(); 
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
            frmInventarioOpcionesEmple frmInventario = new frmInventarioOpcionesEmple();
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



        private void dgvMenu_DoubleClick(object sender, EventArgs e)
        {

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
            DatosGlobales.ProductoFavorito = favorito;
            DatosGlobales.clientes++;
            DatosGlobales.TotalVendidoAcumulado += total;
            dgvProductos.Rows.Clear();

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
