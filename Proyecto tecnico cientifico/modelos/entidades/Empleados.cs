using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace modelos.entidades
{
    public class Empleados
    {
        private string nombreEmpleado;
        private string rol;
        private int telefono;
        private string emailEmpleado;
        private string Contraseña;
        private DateTime inicio;
        private int idPersona;

        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string EmailEmpleado { get => emailEmpleado; set => emailEmpleado = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public DateTime Inicio { get => inicio; set => inicio = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Rol { get => rol; set => rol = value; }

        public static DataTable mostraEmpleado()
        {


            SqlConnection sqlConnection = conexion.conexion.conectaDatabase();
            string comando = @"select usuarios.idUsuario,nombreUsuario as nombre,nombreRol as rol, telefono, email, CONVERT(VARCHAR(20), contraseña) as contraseña, fechaInicioContrato as contrato from usuarios
                             inner join 
                             roles on roles.idRol = usuarios.idRol";

            SqlDataAdapter adapter = new SqlDataAdapter(comando, sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertarEmpleado()
        {
            SqlConnection sqlConnection = conexion.conexion.conectaDatabase();
            string insertRol = @"insert into roles(nombreRol) 
                                output inserted.idRol
                                values (@nombreRol)";
            int idRol;
            SqlCommand sql = new SqlCommand(insertRol, sqlConnection);
            sql.Parameters.AddWithValue("@nombreRol", rol);
            idRol = (int)sql.ExecuteScalar();


            string insertPersona = @"insert into usuarios (nombreUsuario, telefono, email,contraseña,fechaInicioContrato, idRol) 
                                          output inserted.idUsuario 
                                          values (@nombre, @telefono, @email,@contra,@fecha, @idRol)";

            using (SqlCommand cmd = new SqlCommand(insertPersona, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@nombre", NombreEmpleado);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@email", EmailEmpleado);
                cmd.Parameters.AddWithValue("@fecha", inicio);
                cmd.Parameters.AddWithValue("@idRol", idRol);

                byte[] contrasenaBytes = EncriptarSHA256Bytes(Contraseña1 ?? "");
                cmd.Parameters.Add("@contra", SqlDbType.VarBinary, 32).Value = contrasenaBytes;

                idPersona = (int)cmd.ExecuteScalar();

                return true;
            }
            
        }
        private byte[] EncriptarSHA256Bytes(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(texto);
                return sha256.ComputeHash(inputBytes);
            }
        }
        public bool eliminarEmpleado()
        {
            SqlConnection sqlConnection = conexion.conexion.conectaDatabase();
            string comando = @"delete from usuarios where idUsuario = @idUsuario;
                               delete from roles where idRol = @idUsuario;";

            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@idUsuario", idPersona);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool inicioDeSesion(string email, string contrasenaIngresada)
        {
            using (SqlConnection sqlConnection = conexion.conexion.conectaDatabase())
            {
                string comando = @"SELECT u.contraseña, r.nombreRol
                           FROM usuarios u
                           INNER JOIN roles r ON u.idRol = r.idRol
                           WHERE u.email = @correo";

                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@correo", email);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (!reader.Read())
                        return false; // usuario no encontrado

                    byte[] contrasenaEncriptadaBD = (byte[])reader["contraseña"];
                    string rol = reader["nombreRol"].ToString();

                    byte[] contrasenaIngresadaBytes = EncriptarSHA256Bytes(contrasenaIngresada ?? "");

                    if (contrasenaEncriptadaBD.SequenceEqual(contrasenaIngresadaBytes))
                    {
                        this.Rol = rol; 
                        return true;    // login exitoso
                    }
                    else
                        return false;   // contraseña incorrecta
                }
            }
        }
        

        public bool primerUsuario()
        {
            SqlConnection sql = conexion.conexion.conectaDatabase();

            string countQuery = "select count(*) from usuarios";
            SqlCommand countCmd = new SqlCommand(countQuery, sql);
            int cantidad = (int)countCmd.ExecuteScalar();

            int idRol;

            if (cantidad == 0)
            {
                // Verificar si ya existe rol "Jefe"
                string selectRol = "select top 1 idRol from roles where nombreRol = 'Jefe'";
                SqlCommand checkRolCmd = new SqlCommand(selectRol, sql);
                object result = checkRolCmd.ExecuteScalar();

                if (result == null) // si el rol jefe no existe
                {
                    string insertRol = @"INSERT INTO roles(nombreRol)
                                     OUTPUT inserted.idRol
                                     VALUES ('jefe')";
                    SqlCommand cmdInsertRol = new SqlCommand(insertRol, sql);
                    idRol = (int)cmdInsertRol.ExecuteScalar();
                }
                else
                {
                    idRol = (int)result;
                }
            }
            else
            {
                
                string selectRol = "select top 1 idRol from roles where nombreRol = 'empleado'";
                SqlCommand cmdRol = new SqlCommand(selectRol, sql);
                idRol = (int)cmdRol.ExecuteScalar();
            }

            // Insertar el usuario
            string insertUsuario = @"insert into usuarios (nombreUsuario, email, contraseña, idRol)
                                 output inserted.idUsuario
                                 values (@nombre, @correo, @contra, @idRol)";
            using (SqlCommand comando = new SqlCommand(insertUsuario, sql))
            {
                comando.Parameters.AddWithValue("@nombre", NombreEmpleado);
                comando.Parameters.AddWithValue("@correo", EmailEmpleado);
                comando.Parameters.AddWithValue("@idRol", idRol);

                byte[] contrasenaBytes = EncriptarSHA256Bytes(Contraseña1 ?? "");
                comando.Parameters.Add("@contra", SqlDbType.VarBinary, 32).Value = contrasenaBytes;

                idPersona = (int)comando.ExecuteScalar();
            }

            return true;
        }

        public bool actualizarEmpleado()
        {
            SqlConnection sql = conexion.conexion.conectaDatabase();
            string comando = @"update usuarios set nombreUsuario = @nombre, telefono=@telefono, email = @email, contraseña = @contra, idRol = (SELECT TOP 1 idRol FROM roles WHERE nombreRol = @rol)
            where idUsuario = @id";

            SqlCommand sqlCommand = new SqlCommand(comando, sql);
            sqlCommand.Parameters.AddWithValue("@nombre", NombreEmpleado);
            sqlCommand.Parameters.AddWithValue("@telefono", Telefono);
            sqlCommand.Parameters.AddWithValue("@email", EmailEmpleado);
            sqlCommand.Parameters.AddWithValue("@rol", Rol);
            sqlCommand.Parameters.AddWithValue("@id", idPersona);
            sqlCommand.Parameters.Add("@Contra", SqlDbType.VarBinary, 32).Value =
                EncriptarSHA256Bytes(Contraseña1 ?? "");

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
