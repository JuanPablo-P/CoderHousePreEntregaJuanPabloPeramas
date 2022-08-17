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
            _ = usuarioHandler.TraerUsuarios();




            //lógica de inicio de sesión

            Console.WriteLine("**************************************************************");
            Console.WriteLine("*******  Inicio de sesión!  ******************");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");

            string username, password = null;

            Console.WriteLine("Username :");

            username = Console.ReadLine();

            // vamos a chequer el valor ingresado por el usuario
            if (string.IsNullOrEmpty(username))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********  Invalid Username - Exiting Program *****************");
            }
            else
            {
                Console.WriteLine("Password :");

                
                password = Console.ReadLine();
            }

            // chequeamos en la base de datos

            UsuarioHandler userHandler = new UsuarioHandler();
            List<Usuario> usuarioList = userHandler.TraerUsuarios();
            foreach (var user in usuarioList.ToList())
            {
                if (user.NombreUsuario == username && user.Contraseña == password)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("******** Inicio de sesión exitoso!*****************");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("********  Contraseña incorrecta! *****************");
                }
            }
        }
    }
}