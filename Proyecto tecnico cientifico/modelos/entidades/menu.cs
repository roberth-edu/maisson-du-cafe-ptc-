using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using System.Reflection;
using System.Windows.Forms;
using modelos.conexion;


namespace modelos.entidades
{
    public class menu
    {
        private string nombre;
        private double precio;
        private DateTime fechaCreacion;
        private int idItemMenu;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int IdItemMenu { get => idItemMenu; set => idItemMenu = value; }
        public double Precio1 { get => precio; set => precio = value; }

        public static DataTable CargarMenu()
        {
            SqlConnection connection = conexion.conexion.conectaDatabase();
            string comando = "select idDetalleVenta, productoVenta as nombre, subtotal as precio, fechaVenta " +
                             "from detalleVentas " +
                             "inner join ventas on ventas.idVenta = detalleVentas.id_venta";
            SqlDataAdapter ad = new SqlDataAdapter(comando, connection);
            DataTable table = new DataTable();
            ad.Fill(table);
            return table;
        }

        public bool InsertarMenu()
        {
            SqlConnection sqlConnection = conexion.conexion.conectaDatabase();
            string comando = @"declare @idVenta int;
                        insert into ventas (fechaVenta) values ( @fechaInicio);
                        SET @idVenta = scope_identity();

                        insert into detalleVentas (productoVenta,subtotal,id_venta) 
                        values ( @nombre,@precio,@idVenta);";
            SqlCommand cmd = new SqlCommand(comando, sqlConnection);
            cmd.Parameters.AddWithValue("@fechaInicio", fechaCreacion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@precio", Precio1);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }

        public bool eliminarMenu()
        {
            using (SqlConnection sqlConnection = conexion.conexion.conectaDatabase())
            {
                string comando = @"delete from detalleVentas where idDetalleVenta = @idMenu;
                                 delete from ventas where idVenta = @idMenu;";

                SqlCommand cmd = new SqlCommand(comando, sqlConnection);
                cmd.Parameters.AddWithValue("@idMenu", idItemMenu);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                    return false;
                }
            }
            

        }
        public bool actualizarMenu()
        {
            using (SqlConnection sqlConnection = conexion.conexion.conectaDatabase())
            {
                string comando = @"update detalleVentas 
                                   set productoVenta = @nombre, subtotal = @precio
                                   where idDetalleVenta = @idMenu;
                                   update ventas 
                                   set fechaVenta = @fechaInicio
                                   where idVenta = (select id_venta from detalleVentas where idDetalleVenta = @idMenu);";
                SqlCommand cmd = new SqlCommand(comando, sqlConnection);
                cmd.Parameters.AddWithValue("@idMenu", idItemMenu);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", Precio1);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaCreacion);
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                    return false;
                }
            }
        }



    }
}
