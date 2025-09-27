using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelos.entidades;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
namespace vistas.formularios
{
    public partial class frmGastos: Form
    {
        public frmGastos()
        {
            InitializeComponent();
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
        private void frmGastos_Load(object sender, EventArgs e)
        {

            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            txtIngresos.Text = DatosGlobales.TotalVendidoAcumulado.ToString("");
            txtImporte.Text = DatosGlobales.gastos.ToString("");
            pbImagen.Image = BytesToImage(DatosGlobales.imagen);
            this.FormClosing += (cerrar, a) => Application.Exit();
            ConfigurarImagen();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal paginaPrincipal = new frmPaginaPrincipal();
            paginaPrincipal.Show();
            this.Hide();
        }

        private void btnPaginaInventario_Click(object sender, EventArgs e)
        {
            frmInventarioOpciones frmInventario = new frmInventarioOpciones();
            frmInventario.Show();
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string conexion = "Server=ROBERTH;Database=Maisoon_du_cafe;Integrated Security=True;";
            string consulta = "SELECT producto, cantidad FROM detalleVentas";

            gastos.GraficoResultados.MostrarGananciaPerdida(ctGrafico, double.Parse(txtIngresos.Text), double.Parse(txtImporte.Text));
            double primer = double.Parse(txtImporte.Text);
            double segundo = double.Parse(txtIngresos.Text);
            txtBeneficio.Text = (segundo - primer ).ToString();

            if (primer <=0)
            {
                MessageBox.Show("por favor registrar los gastos");

            }
        }

        private void btnPaginaMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void ctGrafico_Click(object sender, EventArgs e)
        {

        }

        private void btnPaginaEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
            this.Hide();
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIngresos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            pnlCerrarSesion.Visible = !pnlCerrarSesion.Visible;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmIngresar frmIngresar = new frmIngresar();
            frmIngresar.Show();
            this.Hide();
        }
    }
}
