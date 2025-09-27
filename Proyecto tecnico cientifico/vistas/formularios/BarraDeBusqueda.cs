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
    public partial class BarraDeBusqueda: Form
    {
        public BarraDeBusqueda()
        {
            InitializeComponent();
        }

        private void BarraDeBusqueda_Load(object sender, EventArgs e)
        {
            Tiempo.Start();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if (pbProgreso.Value < 100)
            {
                pbProgreso.Value += 2;

                lblCarga.Text = pbProgreso.Value.ToString() + "%";
            }
            else
            {
                Tiempo.Stop();
                frmMaisson m = new frmMaisson();
                m.Show();
                this.Hide();
            }
        }
    }
}
