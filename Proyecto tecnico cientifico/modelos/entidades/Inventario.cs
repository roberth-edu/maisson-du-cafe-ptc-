using modelos.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelos.conexion
{
    public class Inventario
    {
        private string nombreProducto;
        private int Cantidad;
        private double PrecioUnitario;
        private double Costo;
        private int idInventario;
        private string categoria;
        private DateTime fecha;


        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public double PrecioUnitario1 { get => PrecioUnitario; set => PrecioUnitario = value; }
        public double Costo1 { get => Costo; set => Costo = value; }
        public int IdInventario { get => idInventario; set => idInventario = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

      
        public bool InsertarProducto()
        {
            try
            {
                SqlConnection sqlConnection = conexion.conectaDatabase();
                // declarar las llaves foraneas y principales para insertar
                string comando = @"declare @idProducto int; --llave primaria
                            declare @idCategoria int;
       
                            -- Insertar producto primero (porque es el principal, y no quiero problemas con las llaves foraneas)
                            insert into productos (nombreProducto,precioUnitario,CostoUnitario) values (@nombreProducto,@precio,@costo);
                            set @idProducto = scope_identity();
                            
                            -- Insertar categoría y obtener ID (porque no quiero problemas con las llaves foraneas, y porque me gusta complicarme la vida)
                            insert into categoria_productos (nombreCategoria) values (@categoria);
                            set @idCategoria = scope_identity();
                            
                            -- Actualizar producto con las relaciones (casi me salen canas por esto)
                            update productos set 
                                idCategoria = @idCategoria
                            where idProducto = @idProducto;
                            
                            -- Insertar en inventario (aquí es donde todo cobra sentido)
                            insert into inventarios (idProducto, cantidadInventario, FechaIngreso) 
                            values (@idProducto, @cantidad, @FechaIngreso);";


                SqlCommand cmd = new SqlCommand(comando, sqlConnection);

                cmd.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                cmd.Parameters.AddWithValue("@precio", PrecioUnitario);
                cmd.Parameters.AddWithValue("@costo", Costo);
                cmd.Parameters.AddWithValue("@categoria", Categoria);
                cmd.Parameters.AddWithValue("@cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@FechaIngreso", fecha);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {

                    return false;
                }

            }
            catch (Exception es)
            {

                MessageBox.Show("el error es" + es.Message);
                return false;
            }

        }
        public bool EliminarProducto()
        {
            using (SqlConnection sqlConnection = conexion.conectaDatabase())
            {
                string comando = @"delete from productos where idProducto = @id";

                SqlCommand cmd = new SqlCommand(comando, sqlConnection);
                cmd.Parameters.AddWithValue("@id", IdInventario);

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
        public static DataTable clasificar(string categoria)
        {
            try
            {
                SqlConnection connection = conexion.conectaDatabase();

                string comando = @"select p.idProducto, p.nombreProducto, nombreCategoria, 
                           precioUnitario, costoUnitario, cantidadInventario,FechaIngreso
                           from productos p
                           inner join categoria_productos cp ON p.idCategoria = cp.idCategoria
                           inner join inventarios i ON p.idProducto = i.idProducto
                           where cp.nombreCategoria = @Categoria";

                SqlDataAdapter ad = new SqlDataAdapter(comando, connection);
                ad.SelectCommand.Parameters.AddWithValue("@Categoria", categoria);
                DataTable table = new DataTable();
                ad.Fill(table);
                return table;

            }
            catch (Exception es)
            {

                MessageBox.Show("el error es" + es.Message);
                return null;
            }


        }


        
        public static DataTable Buscar(string termino, string categoria)
        {
            SqlConnection sql = conexion.conectaDatabase();
            string comando = $"select nombreProducto,nombreCategoria,precioUnitario, costoUnitario, cantidadInventario " +
                             $"from productos " +
                             $"inner join categoria_productos on categoria_productos.idCategoria = productos.idCategoria " +
                             $"inner join inventarios on productos.idProducto = inventarios.idProducto " +
                             $"where productos.nombreProducto like '%{termino}%' " +
                             $"and categoria_productos.nombreCategoria = @categoria";
            SqlDataAdapter adapter = new SqlDataAdapter(comando, sql);
            adapter.SelectCommand.Parameters.AddWithValue("@termino", "%" + termino + "%");
            adapter.SelectCommand.Parameters.AddWithValue("@categoria", categoria);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }




    }
}
