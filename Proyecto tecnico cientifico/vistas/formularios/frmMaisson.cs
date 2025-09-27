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
    public partial class frmMaisson: Form
    {
        public frmMaisson()
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
        private void frmMaisson_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            lblNombreEmpresa.Text = DatosGlobales.nombreEmpresa.ToString();
            pbImagen.Image = BytesToImage(DatosGlobales.imagen);
            
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            Ingresar ingre = new Ingresar();
            if (ingre.HayUsuariosRegistrados())
            {
                
                frmIngresar login = new frmIngresar();
                login.Show();
                this.Hide();
            }
            else
            {
                
                frmAgregarUsuarioIngresar agregarUsuario = new frmAgregarUsuarioIngresar();
                agregarUsuario.Show();
                this.Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
