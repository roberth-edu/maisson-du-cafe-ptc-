using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using modelos;
using modelos.entidades;




namespace vistas.formularios
{
    public partial class frmPaginaPrincipal: Form
    {
        public frmPaginaPrincipal()
        {
            this.FormClosing += (sender, e) => Application.Exit();
            InitializeComponent();

        }
        public void ActualizarTextBox(string datos)
        {
            txtVendido.Text = datos;
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
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
        }
        public static string serverName = Environment.MachineName;

        private void paginaPrincipal_Load(object sender, EventArgs e)
        {

            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            txtVendido.Text = DatosGlobales.TotalVendidoAcumulado.ToString("C2");
            pbLogo.Image = BytesToImage(DatosGlobales.imagen);
            txtClientes.Text = DatosGlobales.clientes.ToString();
            txtFav.Text = DatosGlobales.ProductoFavorito.ToString();

            string conexion = $"Server={serverName};Database=Maisoon_du_cafe;Integrated Security=True;";

            string consulta = "SELECT productoVenta, subtotal FROM detalleVentas";

            // Mostrar gráfico
            ctGrafico.Titles.Add("Grafico de precios");
            Pagina_Principal.GraficoSimple.MostrarPie(ctGrafico, conexion, consulta);
            ConfigurarImagen();

        }
        private void frmPaginaPrincipal_Activated(object sender, EventArgs e)
        {
            txtVendido.Text = DatosGlobales.TotalVendidoAcumulado.ToString("C2");
            txtClientes.Text = DatosGlobales.clientes.ToString() ;
            txtFav.Text = DatosGlobales.ProductoFavorito.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctGrafico_Click(object sender, EventArgs e)
        {

        }

        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal paginaPrincipal = new frmPaginaPrincipal();
            paginaPrincipal.Show();
            this.Hide();
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            frmGastos frmGastos = new frmGastos();
            frmGastos.Show();
            this.Hide();
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            frmInventarioOpciones frmInventario = new frmInventarioOpciones();
            frmInventario.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            pnlCerrarSesion.Visible = !pnlCerrarSesion.Visible;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmIngresar frmIngresar = new frmIngresar();
            frmIngresar.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            pnlCerrarSesion.Visible = !pnlCerrarSesion.Visible;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
