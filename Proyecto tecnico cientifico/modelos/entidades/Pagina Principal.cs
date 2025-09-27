using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Data;

namespace modelos.entidades
{
    public class Pagina_Principal
    {
        private string producto;
        private int cantidad;

        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public class GraficoSimple
        {
            public static void MostrarPie(Chart chart, string conexionSQL, string consultaSQL)
            {
                chart.Series.Clear();

                DataTable datos = new DataTable();
                using (SqlConnection con = new SqlConnection(conexionSQL))
                {
                    SqlDataAdapter da = new SqlDataAdapter(consultaSQL, con);
                    da.Fill(datos);
                }

                Series serie = new Series();
                serie.ChartType = SeriesChartType.Pie;

                foreach (DataRow fila in datos.Rows)
                {
                    serie.Points.AddXY(fila[0].ToString(), fila[1]);
                }

                chart.Series.Add(serie);
            }
        }


    }
}
