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
    public partial class frmOlvidasteLaContra: Form
    {
        public frmOlvidasteLaContra()
        {
            InitializeComponent();
            this.FormClosing += (cerrar, a) => Application.Exit();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string usuarioEmail = txtRecuperar.Text;

            var servicio = new servicioDeRecuperacionContra();
            string resultado = servicio.RecuperarContra(usuarioEmail);

            MessageBox.Show(resultado); 
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmIngresar f = new frmIngresar();
            f.Show();
            this.Hide();
        }

        private void frmOlvidasteLaContra_Load(object sender, EventArgs e)
        {

        }
    }
}
