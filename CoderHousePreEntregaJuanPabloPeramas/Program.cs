namespace CoderHousePreEntregaJuanPabloPeramas
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("");
            ProductoHandler productoHandler = new ProductoHandler();

            var products = productoHandler.TraerProductos();
           // foreach (var product in products) 
           //{
           //     if (product.Costo < 100) 
           //     { 
           //     products.Remove(product);
           //    }
           // } 
            
           productoHandler.MostrarProductos(products);


            UsuarioHandler usuarioHandler = new UsuarioHandler();
            var user=usuarioHandler.TraerUsuarios();
           
            

        }

    }
}