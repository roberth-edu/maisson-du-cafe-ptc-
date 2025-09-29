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
using System.Windows.Forms;

namespace vistas.formularios
{
    public partial class frmMostrarInventarioComplementoEmple: Form
    {
        public frmMostrarInventarioComplementoEmple()
        {
            InitializeComponent();
            Cargarcomplementos();
            this.FormClosing += (cerrar, a) => Application.Exit();
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

        private void frmMostrarInventarioComplemento_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            if (dgvComplemento.Columns.Contains("idProducto"))
            {
                dgvComplemento.Columns["idProducto"].Visible = false;
            }
            pbImagen.Image = BytesToImage(DatosGlobales.imagen);
            ConfigurarImagen();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cargarcomplementos()
            //sirve para decir que aqui se almacenan los complementos

        {
            dgvComplemento.DataSource = Inventario.clasificar("Complementos");
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmInventarioAgregar frmInventario = new frmInventarioAgregar();
            frmInventario.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvComplemento.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dgvComplemento.SelectedRows[0].Cells["idProducto"].Value);

                var inventario = new Inventario() { IdInventario = idProducto };

                if (inventario.EliminarProducto())
                {
                    
                    dgvComplemento.DataSource = Inventario.clasificar("Complementos");
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmInventarioOpcionesEmple frmInventarioOpciones = new frmInventarioOpcionesEmple();
            frmInventarioOpciones.Show();
            this.Hide();
        }
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }
        //esta parte es para calcular la suma de precios y de cantidades
        private void btnCacular_Click(object sender, EventArgs e)
        {
            
            if (dgvComplemento.Rows.Count == 0)
            {
                MessageBox.Show("el inventario esta vacio");
            }

        }
        //sumar y sumar objetos son diferentes, sumar sirve para mandar informacion a la pagina gastos y la de sumaGastos sirve para
        //sumar los gastos y mostrarlo en inventario
        private void sumar()
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvComplemento.Rows)
            {
                total += Convert.ToDouble(row.Cells["costo"].Value ?? 0) *
                         Convert.ToInt32(row.Cells["cantidad"].Value ?? 0);

            }
            DatosGlobales.subtotalComplementos = total;


        }
        private void sumarGastos()
        {
            

            double total = 0;

            foreach (DataGridViewRow row in dgvComplemento.Rows)
            {
                total += Convert.ToDouble(row.Cells["costo"].Value ?? 0) *
                         Convert.ToInt32(row.Cells["cantidad"].Value ?? 0);

            }

            txtPrecio.Text = total.ToString("C2");

        }
        private void gananciaProducto()
        {
            double precioUnitario = 0;
            foreach (DataGridViewRow data in dgvComplemento.Rows)
            {
                precioUnitario += (Convert.ToDouble(data.Cells["precio"].Value ?? 0) *
                                  Convert.ToInt16(data.Cells["cantidad"].Value ?? 0)) -
                                  Convert.ToDouble(data.Cells["costo"].Value ?? 0) *
                                  Convert.ToInt32(data.Cells["cantidad"].Value ?? 0);


            }
            txtGanancia.Text = precioUnitario.ToString("c2");
        }
        private void sumarObjetos()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvComplemento.Rows)
            {
                total += Convert.ToInt32(row.Cells["cantidad"].Value ?? 0);
            }
            txtProducto.Text = total.ToString("N0");
        }

        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipalEmpleado paginaPrincipal = new frmPaginaPrincipalEmpleado();
            paginaPrincipal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGastos frmGastos = new frmGastos();
            frmGastos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInventarioOpciones opciones = new frmInventarioOpciones();
            opciones.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMenuEmple frmMenu = new frmMenuEmple();
            frmMenu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.MaxLength = 9;
            if (txtBuscar.Text.Length == txtBuscar.MaxLength)
            {
                MessageBox.Show("Máximo de caracteres alcanzado");
            }
            try
            {
                dgvComplemento.DataSource = null;
                dgvComplemento.DataSource = Inventario.Buscar(txtBuscar.Text, "Complementos");



            }
            catch (Exception es)
            {

                MessageBox.Show("no la soca" + es);
            }
        }

        private void dgvComplemento_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvComplemento_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void dgvComplemento_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (dgvComplemento.Rows.Count == 1)
            {
                MessageBox.Show("no se puede calcular nada, inventario vacio");
                return;
            }
            sumar();
            sumarGastos();
            sumarObjetos();
            gananciaProducto();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
