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
    public partial class frmEmpleados: Form
    {
        public frmEmpleados()
        {
            this.FormClosing += (cerrar, a) => Application.Exit();
            InitializeComponent();
        }

        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal paginaPrincipal = new frmPaginaPrincipal();
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

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
            this.Hide();
        }

        private void mostrarEmpleados()
        {
            dgvGraficoEmpleado.DataSource = Empleados.mostraEmpleado();
            if (dgvGraficoEmpleado.Columns.Contains("idUsuario"))
            {
                dgvGraficoEmpleado.Columns["idUsuario"].Visible = false;
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                MessageBox.Show("Ingrese el nombre del empleado");
                return;
            }

            if (!int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("Teléfono debe ser un número válido");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese una contraseña");
                return;
            }

            if (string.IsNullOrEmpty(txtEmailEmpleado.Text))
            {
                MessageBox.Show("ingresar un email de empleado");
                return;

            }
            if (string.IsNullOrEmpty(cbRol.Text))
            {
                MessageBox.Show("ingresar un rol para empleado");
                return;
            }

            try
            {
                Empleados nuevo = new Empleados()
                {
                    NombreEmpleado = txtNombreEmpleado.Text,
                    Telefono = telefono,
                    EmailEmpleado = txtEmailEmpleado.Text,
                    Contraseña1 = txtContraseña.Text,
                    Inicio = dtpFechaEmpleado.MinDate = DateTime.Today,
                    Rol = cbRol.Text
                    
                };

                if (dtpFechaEmpleado.MinDate< DateTime.Today)
                {
                    nuevo.Inicio = dtpFechaEmpleado.MinDate = DateTime.Today;
                    MessageBox.Show("no ingresar fechas pasadas");
                    return;
                }
                if (dtpFechaEmpleado.Value > DateTime.Now)
                {
                    nuevo.Inicio = dtpFechaEmpleado.MaxDate = DateTime.Today;
                    MessageBox.Show("no ingresar fechas futuras");
                    return;
                }

                if (nuevo.insertarEmpleado())
                {
                    MessageBox.Show("Empleado registrado exitosamente");
                    mostrarEmpleados();

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

            txtNombreEmpleado.Text = "";
            txtContraseña.Text = "";
            txtTelefono.Text = "";
            cbRol.Text = "";
            txtEmailEmpleado.Text = "";
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
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            pbImagen.Image = BytesToImage(DatosGlobales.imagen);
            mostrarEmpleados();
            ConfigurarImagen();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            pnlCerrarSesion.Visible = !pnlCerrarSesion.Visible;
        }
        private void opción1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            if (dgvGraficoEmpleado.SelectedRows.Count > 0)
            {
                int idPersona = Convert.ToInt32(dgvGraficoEmpleado.SelectedRows[0].Cells["idUsuario"].Value);
                empleados.IdPersona = idPersona;

                DialogResult mensaje = MessageBox.Show("Seguro que quiere eliminar el empleado", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                mostrarEmpleados();
                if (mensaje == DialogResult.Yes)
                {
                    if (empleados.eliminarEmpleado())
                    {
                        MessageBox.Show("Empleado eliminado adecuadamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarEmpleados();
                    }

                }
                else
                {
                    MessageBox.Show("eliminacion cancelada", "aviso", MessageBoxButtons.OK);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar");
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 9;
            if (txtTelefono.Text.Length == txtTelefono.MaxLength)
            {
                MessageBox.Show("Máximo de caracteres alcanzado");
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmIngresar frmIngresar = new frmIngresar();
            frmIngresar.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvGraficoEmpleado_DoubleClick(object sender, EventArgs e)
        {
            if (dgvGraficoEmpleado.SelectedRows.Count > 0)
            {
                txtNombreEmpleado.Text = dgvGraficoEmpleado.SelectedRows[0].Cells["nombre"].Value.ToString();
                cbRol.Text = dgvGraficoEmpleado.SelectedRows[0].Cells["rol"].Value.ToString();
                txtTelefono.Text = dgvGraficoEmpleado.SelectedRows[0].Cells["telefono"].Value.ToString();
                txtEmailEmpleado.Text = dgvGraficoEmpleado.SelectedRows[0].Cells["email"].Value.ToString();
                txtContraseña.Text = dgvGraficoEmpleado.SelectedRows[0].Cells["contraseña"].Value.ToString();
            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                MessageBox.Show("Ingrese el nombre del empleado");
                return;
            }

            if (!int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("Teléfono debe ser un número válido");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese una contraseña");
                return;
            }

            if (string.IsNullOrEmpty(txtEmailEmpleado.Text))
            {
                MessageBox.Show("ingresar un email de empleado");
                return;

            }
            if (string.IsNullOrEmpty(cbRol.Text))
            {
                MessageBox.Show("ingresar un rol para empleado");
                return;
            }
            if (dgvGraficoEmpleado.SelectedRows.Count > 0)
            {
                int idPersona = Convert.ToInt32(dgvGraficoEmpleado.SelectedRows[0].Cells["idUsuario"].Value);
                Empleados empleado = new Empleados()
                {
                    IdPersona = idPersona,
                    NombreEmpleado = txtNombreEmpleado.Text,
                    Telefono = int.Parse(txtTelefono.Text),
                    EmailEmpleado = txtEmailEmpleado.Text,
                    Contraseña1 = txtContraseña.Text,
                    Inicio = dtpFechaEmpleado.Value,
                    Rol = cbRol.Text

                };
                if (dtpFechaEmpleado.Value < DateTime.Today)
                {
                    empleado.Inicio = dtpFechaEmpleado.MinDate = DateTime.Today;
                    MessageBox.Show("no ingresar fechas pasadas");
                    return;
                }
                if (dtpFechaEmpleado.Value > DateTime.Now)
                {
                    empleado.Inicio = dtpFechaEmpleado.MaxDate = DateTime.Today;
                    MessageBox.Show("no ingresar fechas futuras");
                    return;
                }
                if (empleado.actualizarEmpleado())
                {
                    MessageBox.Show("Empleado actualizado exitosamente");
                    mostrarEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al actualizar empleado");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para actualizar");
            }

        }

        private void txtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla
            }
        }

        private void dgvGraficoEmpleado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGraficoEmpleado.Columns[e.ColumnIndex].Name == "contraseña" && e.Value != null)
            {
                // Reemplazar el valor por asteriscos con la misma longitud
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void txtEmailEmpleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            txtNombreEmpleado.MaxLength = 30;
            if (txtNombreEmpleado.Text.Length == txtNombreEmpleado.MaxLength)
            {
                MessageBox.Show("Máximo de caracteres alcanzado");
            }
        }
    }
}
