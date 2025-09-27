using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace modelos.entidades
{
    public class servicioDeRecuperacionContra
    {
        private byte[] encriptar(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(texto);
                return sha256.ComputeHash(inputBytes);
            }
        }
        public string RecuperarContra(string userRequesting)
        {
            try
            {
                
                string nombre = "";
                string email = "";
                string nuevaContra = "";
                bool usuarioEncontrado = false;

                // Bloque separado solo para leer datos
                using (SqlConnection sql = conexion.conexion.conectaDatabase())
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = sql;
                        command.CommandText = "SELECT nombreUsuario, email, contraseña FROM usuarios WHERE nombreUsuario = @user OR email = @email";
                        command.Parameters.AddWithValue("@user", userRequesting);
                        command.Parameters.AddWithValue("@email", userRequesting);
                        command.CommandType = CommandType.Text;

                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombre = reader["nombreUsuario"].ToString();
                                email = reader["email"].ToString();
                                usuarioEncontrado = true;
                            }
                        }

                    }
                }

                if (usuarioEncontrado)
                {
                    // Generar una contraseña temporal de 8 caracteres
                     nuevaContra = Guid.NewGuid().ToString("N").Substring(0, 8);

                    // Aquí deberías guardar nuevaContra en la BD hasheada
                    using (SqlConnection sql = conexion.conexion.conectaDatabase())
                    {
                        using (var updateCmd = new SqlCommand("UPDATE usuarios SET contraseña = @nuevaContra WHERE email = @correo", sql))
                        {
                            // Si normalmente usas hash, aplica tu método de encriptación aquí
                            byte[] nuevaContraBytes = encriptar(nuevaContra);
                            updateCmd.Parameters.AddWithValue("@nuevaContra", nuevaContraBytes);
                            updateCmd.Parameters.AddWithValue("@correo", email);
                            updateCmd.ExecuteNonQuery();
                        }
                    }

                }
                else
                {
                    return "Lo lamentamos, no existe un usuario con este nombre de usuario o email.";
                }
                using (var mailService = new soporteDeContrasena())
                {
                    bool emailEnviado = mailService.EnviarMail(
                        subject: "SYSTEM: recuperacion de contraseña",
                        body: $"Hola, {nombre}\n\nHemos generado una nueva contraseña temporal para ti.\n" +
                              $"Tu nueva contraseña es: {nuevaContra}\n\n" +
                              "Por favor cámbiala después de iniciar sesión.",
                        recipientMail: new List<string> { email });

                    if (emailEnviado)
                    {
                        return $"Hola, {nombre}\nRevisa tu email: {email}";
                    }
                    else
                    {
                        return $"Error enviando email a {email}";
                    }
                }



            }



            catch (Exception ex)
            {
                return $"Error en la recuperación de contraseña: {ex.Message}";
            }

        }

    }
}
        
    

