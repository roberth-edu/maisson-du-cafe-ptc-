using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelos.entidades
{
    public class DatosEmpresa
    {
        private string nombre;
        private string direccion;
        private string telefono;
        private string email;
        private byte[] logo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public byte[] Logo { get => logo; set => logo = value; }

        public bool GuardarEmpresa()
        {
            string querty;
            SqlConnection sql = conexion.conexion.conectaDatabase();
            string comando = "select count(*) from configuracion_empresa";
            SqlCommand cmd = new SqlCommand(comando, sql);
            int existe = (int)cmd.ExecuteScalar();
            if (existe > 0)
            
            {
                // Si ya hay empresa -> hacemos UPDATE
                querty = @"update configuracion_empresa
                              set nombreEmpresa = @nombre,
                                  direccion = @direccion,
                                  telefono = @telefono,
                                  email = @correo,
                                  logo = @logo
                              where idEmpresa = (select top 1 idEmpresa from configuracion_empresa)";
            }
            else
            {
                 querty = @"insert into configuracion_empresa (nombreEmpresa, direccion, telefono, email, logo)
                                 values (@nombre, @direccion, @telefono, @correo, @logo)";
            }
            SqlCommand sqlCommand = new SqlCommand(querty, sql);
            sqlCommand.Parameters.AddWithValue("@nombre", Nombre);
            sqlCommand.Parameters.AddWithValue("@direccion", Direccion);
            sqlCommand.Parameters.AddWithValue("@telefono", Telefono);
            sqlCommand.Parameters.AddWithValue("@correo", Email);
            if ( Logo != null)
                sqlCommand.Parameters.AddWithValue("@logo", Logo);
            else
                sqlCommand.Parameters.AddWithValue("@logo", DBNull.Value);

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
