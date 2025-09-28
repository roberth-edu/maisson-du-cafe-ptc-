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
    public partial class frmConfiguracionEmpresa: Form
    {
        public frmConfiguracionEmpresa()
        {
            InitializeComponent();
        }

        private void ConfigurarImagen()
        {
            // Configurar PictureBox para que la imagen se adapte
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.BorderStyle = BorderStyle.FixedSingle;
        }
        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Seleccionar Imagen";
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(openFile.FileName);
            }
        }

        private byte[] imagenArray(Image imagen)
        {
            if (imagen == null) return null;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                imagen.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DatosEmpresa d = new DatosEmpresa();
            d.Nombre = txtNombreEmpresa.Text;
            d.Email = txtEmail.Text;
            d.Telefono = txtTelefono.Text;
            d.Direccion = txtDirreccionEmpresa.Text;
            if (pbImagen.Image != null)
            {
                d.Logo = imagenArray(pbImagen.Image);
            }
            else
            {
                d.Logo = null;
            }
            if (d.GuardarEmpresa())
            {
                MessageBox.Show("empresa agregada correctamente");
                DatosGlobales.nombreEmpresa = txtNombreEmpresa.Text;
                DatosGlobales.imagen = imagenArray(pbImagen.Image);
                frmMaisson m = new frmMaisson();
                m.Show();
                this.Hide();

            }
           
            
        }

        private void frmConfiguracionEmpresa_Load(object sender, EventArgs e)
        {
            ConfigurarImagen();
        }

        private void pnlRegistrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla
            }
        }

        private void txtNombreEmpresa_TextChanged(object sender, EventArgs e)
        {
            txtNombreEmpresa.MaxLength = 100;
            if (txtNombreEmpresa.Text.Length == txtNombreEmpresa.MaxLength)
            {
                MessageBox.Show("limite de caracteres alcanzado");
            }
        }

        private void txtDirreccionEmpresa_TextChanged(object sender, EventArgs e)
        {
            txtDirreccionEmpresa.MaxLength = 200;
            if (txtDirreccionEmpresa.Text.Length == txtDirreccionEmpresa.MaxLength)
            {
                MessageBox.Show("limite de caracteres alcanzado");

            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 9;
            if (txtTelefono.Text.Length == txtTelefono.MaxLength)
            {
                MessageBox.Show("limite de caracteres alcanzado");

            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; 
                return;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 254;
            if (txtEmail.Text.Length == txtEmail.MaxLength)
            {
                MessageBox.Show("limite de caracteres alcanzado");
            }
        }
    }
}
