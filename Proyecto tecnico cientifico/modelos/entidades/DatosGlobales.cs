
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace modelos.entidades
{
    public class DatosGlobales
    {
        public static double TotalVendidoAcumulado { get; set; } = 0;
        public static int clientes { get; set; } = 0;
        public static double ganancias { get; set; } = 0;
        public static double subtotalCafe = 0;
        public static double subtotalComplementos = 0;
        public static string nombreEmpresa { get; set; } = "";
        public static byte[] imagen { get; set; }


        public static double gastos
        {
            get
            {
                return subtotalCafe + subtotalComplementos;
            }
        }
        public static string ProductoFavorito { get; set; } = "No hay datos aun";
    }
}
