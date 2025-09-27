using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Windows.Forms;

namespace modelos.entidades

{
    

     public class gastos
    {

        private double Ingresos;
        private double Gastos;
        private Chart chartControl;


        public double Ingresos1 { get => Ingresos; set => Ingresos = value; }
        public double Gastos1 { get => Gastos; set => Gastos = value; }
        public Chart ChartControl { get => chartControl; set => chartControl = value; }

        public static class GraficoResultados
        {
            public static void MostrarGananciaPerdida(Chart chartControl, double ingresos, double gastos)
            {

                chartControl.Series.Clear();

                
                Series serie = new Series("Resultado");
                serie.ChartType = SeriesChartType.Bar;

                
                double resultado = ingresos - gastos;
                serie.Points.AddY(resultado);

                
                chartControl.Series.Add(serie);

                
                chartControl.ChartAreas[0].AxisX.Enabled = AxisEnabled.False; // Ocultar eje X
                chartControl.Titles.Clear();
                chartControl.Titles.Add($"{(resultado >= 0 ? "GANANCIA" : "PERDIDA")}: ${Math.Abs(resultado)}");

            }

        }
    }
}
