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
    public partial class frmInventarioOpcionesEmple: Form
    {
        public frmInventarioOpcionesEmple()
        {
            this.FormClosing += (sender, e) => Application.Exit();
            InitializeComponent();
        }



        private void btnPaginaPrincipal_Click_1(object sender, EventArgs e)
        {
            frmPaginaPrincipalEmpleado paginaPrincipal = new frmPaginaPrincipalEmpleado();
            paginaPrincipal.Show();
            this.Hide();
        }

        private void btnPaginaGastos_Click(object sender, EventArgs e)
        {
            frmGastos frmGastos = new frmGastos();
            frmGastos.Show();
            this.Hide();
        }

        private void btnPaginaInventario_Click(object sender, EventArgs e)
        {
        }

        private void btnPaginaMenu_Click(object sender, EventArgs e)
        {
            frmMenuEmple frmMenu = new frmMenuEmple();
            frmMenu.Show();
            this.Hide();

        }

        private void btnPaginaEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmmostrarInventarioCafeEmple frmmostrarInventarioCafe = new frmmostrarInventarioCafeEmple();
            frmmostrarInventarioCafe.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmMostrarInventarioComplementoEmple frmMostrarInventarioComplemento = new frmMostrarInventarioComplementoEmple();
            frmMostrarInventarioComplemento.Show();
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
            pbLogoPaginaGastos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogoPaginaGastos.BorderStyle = BorderStyle.FixedSingle;
        }
        private void frmInventarioOpciones_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            pbLogoPaginaGastos.Image = BytesToImage(DatosGlobales.imagen);

            ConfigurarImagen();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInventarioAgregar frmInventarioAgregar = new frmInventarioAgregar();
            frmInventarioAgregar.Show();
            this.Hide();
        }
    }
}
