using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelos.entidades
{
   public class Ingresar
    {
        public bool HayUsuariosRegistrados()
        {
                SqlConnection sqlConnection = conexion.conexion.conectaDatabase();
                string query = "select count(*) from usuarios"; 
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                int cantidad = (int)cmd.ExecuteScalar();
                return cantidad > 0;
        }
    }
}
