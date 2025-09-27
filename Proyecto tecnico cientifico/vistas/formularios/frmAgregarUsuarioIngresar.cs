using modelos.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas.formularios
{
    public partial class frmAgregarUsuarioIngresar: Form
    {
        public frmAgregarUsuarioIngresar()
        {
            InitializeComponent();
        }

        private void frmAgregarUsuarioIngresar_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += (cerrar, a) => Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del empleado");
                return;
            }


            if (string.IsNullOrWhiteSpace(txtContra.Text))
            {
                MessageBox.Show("Ingrese una contraseña");
                return;
            }

            if (string.IsNullOrEmpty(txtGmail.Text))
            {
                MessageBox.Show("ingresar un email de empleado");
                return;

            }

            if (string.IsNullOrEmpty(txtConfirmar.Text))
            {
                MessageBox.Show("por favor confirma la contraseña");
                return;
            }

            try
            {
                Empleados nuevo = new Empleados()
                {
                    NombreEmpleado = txtnombre.Text,
                    EmailEmpleado = txtGmail.Text,
                    Contraseña1 = txtContra.Text

                    
                    
                };
                if (txtContra.Text != txtConfirmar.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, vuelva a escribirlas.");
                    return;

                }

                if (nuevo.primerUsuario())
                {
                    MessageBox.Show("Empleado registrado exitosamente");
                    frmIngresar frmIngresar = new frmIngresar();
                    frmIngresar.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Error al registrar empleado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
