

using System.Data.SqlClient;

namespace CoderHousePreEntregaJuanPabloPeramas
{
    public class ProductoHandler : dbHandler
    {
        public List<Producto> TraerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM Producto", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Producto product = new Producto();
                                product.Id = Convert.ToInt32(dataReader["Id"]);
                                product.Descripciones = dataReader["Descripciones"].ToString();
                                product.Costo = Convert.ToInt32(dataReader["Costo"]);
                                product.Stock = Convert.ToInt32(dataReader["Stock"]);
                                product.PrecioVenta = Convert.ToInt32(dataReader["PrecioVenta"]);
                                product.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                productos.Add(product);
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }

            return productos;

        }

        internal static List<Producto> TraerProductos(int id)
        {
            throw new NotImplementedException();
        }

        public void MostrarProductos(List<Producto> productos)
        {
            Console.WriteLine("-- Lista de Productos --");
            foreach (Producto producto in productos.ToList())
            {
                Console.WriteLine(producto.Id);
                Console.WriteLine(producto.Descripciones);
                Console.WriteLine(producto.PrecioVenta);
                Console.WriteLine(producto.Costo);
                Console.WriteLine(producto.IdUsuario);
                Console.WriteLine(producto.Stock);

            }
            Console.WriteLine("--                   --");
        }

  
        }
    }

