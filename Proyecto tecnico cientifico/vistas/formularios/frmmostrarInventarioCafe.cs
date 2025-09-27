using modelos.conexion;
using modelos.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace vistas.formularios
{
    public partial class frmmostrarInventarioCafe: Form
    {
        public bool EstaDataGridViewVacio()
        {
          
            return dgvcafe.Rows.Count == 0 ||
                   (dgvcafe.Rows.Count == 1 && dgvcafe.Rows[0].IsNewRow);
        }
        public frmmostrarInventarioCafe()
        {
            InitializeComponent();
            this.FormClosing += (cerrar, a) => Application.Exit();
            CargarCafes();
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

        private void mostrarInventario_Load(object sender, EventArgs e)
        {

            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            pbImagen.Image = BytesToImage(DatosGlobales.imagen);
            if (dgvcafe.Columns.Contains("idProducto"))
            {
                dgvcafe.Columns["idProducto"].Visible = false;
            }
            ConfigurarImagen();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvcafe.SelectedRows.Count > 0)
            {
                
                int idProducto = Convert.ToInt32(dgvcafe.SelectedRows[0].Cells["idProducto"].Value);

                var inventario = new Inventario() { IdInventario = idProducto };

                if (inventario.EliminarProducto())
                {

                    dgvcafe.DataSource = Inventario.clasificar("Café");
                    sumarGastos();
                    sumar();
                    sumarObjetos();
                    gananciaProducto();

                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar");
            }

        }

        private void dgvVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmInventarioAgregar frmInventario = new frmInventarioAgregar();
            frmInventario.Show();
            this.Hide();

        }

        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal paginaPrincipal = new frmPaginaPrincipal();
            paginaPrincipal.Show();
            this.Hide();
        }
        private void CargarCafes()
        {
            dgvcafe.DataSource = Inventario.clasificar("Café");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmInventarioOpciones frmInventarioOpciones = new frmInventarioOpciones();
            frmInventarioOpciones.Show();
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (dgvcafe.Rows.Count == 0)
            {
                MessageBox.Show("el inventario esta vacio");
            }


        }
        private void sumar()
        {
                
            
            double total = 0;
            //foreach sirve para recorrer cada fila del DataGridView
            foreach (DataGridViewRow row in dgvcafe.Rows)
            {
                // Convert.ToDouble(row.Cells["costoUnitario"].Value ?? 0) es para obtener el valor de la celda costoUnitario, si es nulo se asigna 0
                
                total += Convert.ToDouble(row.Cells["costoUnitario"].Value ?? 0) *
                         Convert.ToInt32(row.Cells["cantidadInventario"].Value ?? 0);
            }
            //total.tostring es para convertir el total a string y "C2" es para formatear el número como moneda con dos decimales
            DatosGlobales.subtotalCafe = total;



        }
        private void sumarGastos()
        {
           

            double total = 0;
            //foreach sirve para recorrer cada fila del DataGridView
            foreach (DataGridViewRow row in dgvcafe.Rows)
            {
                // Convert.ToDouble(row.Cells["costoUnitario"].Value ?? 0) es para obtener el valor de la celda costoUnitario, si es nulo se asigna 0

                total += Convert.ToDouble(row.Cells["costoUnitario"].Value ?? 0) *
                         Convert.ToInt32(row.Cells["cantidadInventario"].Value ?? 0);
            }
            //total.tostring es para convertir el total a string y "C2" es para formatear el número como moneda con dos decimales
            txtPrecio.Text = total.ToString("C2");
        }
        private void gananciaProducto()
        {
            double precioUnitario = 0;
            foreach (DataGridViewRow data in dgvcafe.Rows)
            {
                precioUnitario += (Convert.ToDouble(data.Cells["precioUnitario"].Value ?? 0) *
                                  Convert.ToInt16(data.Cells["cantidadInventario"].Value ?? 0)) -
                                  Convert.ToDouble(data.Cells["costoUnitario"].Value ?? 0) *
                                  Convert.ToInt32(data.Cells["cantidadInventario"].Value ?? 0);


            }
            txtGanancia.Text = precioUnitario.ToString("c2");
        }


        private void sumarObjetos()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvcafe.Rows)
            {
                total += Convert.ToInt32(row.Cells["cantidadInventario"].Value ?? 0);
            }
            txtCantidad.Text = total.ToString("N0");
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            frmGastos frmGastos = new frmGastos();
            frmGastos.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventarioOpciones frmInventarioOpciones = new frmInventarioOpciones();
            frmInventarioOpciones.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
            this.Hide();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvcafe_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.MaxLength = 40;
            if (txtBuscar.Text.Length == txtBuscar.MaxLength)
            {
                MessageBox.Show("Máximo de caracteres alcanzado");
            }
            try
            {
                dgvcafe.DataSource = null;
                dgvcafe.DataSource = Inventario.Buscar(txtBuscar.Text, "Café");



            }
            catch (Exception es)
            {

                MessageBox.Show("error"+ es);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvcafe.Rows.Count == 1)
            {
                MessageBox.Show("no se puede calcular nada, inventario vacio");
                return;
            }
            sumar();
            sumarGastos();
            sumarObjetos();
            gananciaProducto();
        }
    }
}
