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
    public partial class frmIngresar: Form
    {
        public frmIngresar()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtIngresarEmail.Text;
                string contrasena = txtIngresarContraseña.Text;

                Empleados p = new Empleados();
                bool loginExitoso = p.inicioDeSesion(usuario, contrasena);

                if (loginExitoso)
                {
                    if (p.Rol == "empleado")
                    {
                        frmPaginaPrincipalEmpleado a = new frmPaginaPrincipalEmpleado();
                        a.Show();
                        this.Hide();
                    }
                    else if (p.Rol == "jefe")
                    {
                        frmPaginaPrincipal q = new frmPaginaPrincipal();
                        q.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmIngresar_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIngresarUsuario_TextChanged(object sender, EventArgs e)
        {
            txtIngresarEmail.MaxLength = 254;
            if (txtIngresarEmail.Text.Length == txtIngresarEmail.MaxLength)
            {
                MessageBox.Show("limite de caracteres alcanzado");
            }
        }

        private void lblOlvidaste_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOlvidasteLaContra frmOlvidasteLaContra = new frmOlvidasteLaContra();
            frmOlvidasteLaContra.Show();
            this.Hide();
        }

        private void txtIngresarContraseña_TextChanged(object sender, EventArgs e)
        {
            txtIngresarContraseña.MaxLength = 32;
            if (txtIngresarContraseña.Text.Length == txtIngresarContraseña.MaxLength)
            {
                MessageBox.Show("limite de caracteres alcanzado");

            }
        }
    }
}
