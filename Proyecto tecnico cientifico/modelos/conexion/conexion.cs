using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace modelos.conexion
{
    class conexion
    {
        public static string servidor = "ROBERTH";
        public static string database = "maisoon_du_cafe";

        public static SqlConnection conectaDatabase()
        {
            string cadena = $"Data source={servidor}; initial catalog={database};integrated security=true;";

            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();


            return conexion;

            
        }


        }
    }
        

    
