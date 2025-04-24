using System;
using PruebaDesarrolladorNet.Controller;
using PruebaDesarrolladorNet.Model;

class Program
{
    static void Main()
    {
        var service = new ProductController();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==MENU INTERACCIÓN CRUD - PRUEBA DESARROLLO==");
            Console.WriteLine("1. Lista de Productos");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            switch (Console.ReadLine()){
                case "1":
                    ListarProductos(service);
                    break;
                case "2":
                    AgregarProducto(service);
                    break;
                case "3":
                    EditarProducto(service); 
                    break;
                case "4":
                    EliminarProducto(service);
                    break;
                case "5":
                    return;

            }


            static void ListarProductos(ProductController service)
            {
                Console.WriteLine("/==Lista==\\");
                service.GetAll().ForEach(x => 
                        Console.WriteLine($"{x.id} : {x.Nombre} - ${x.Precio}, {x.Descripcion} // {x.FechaCreacion}"));
                        Console.ReadKey();

            }

            static void AgregarProducto(ProductController service)
            {
                Console.Write("\nNombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("\nPrecio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nDescripción: ");
                string descripcion = Console.ReadLine();

                service.Agregar(new Product { Nombre = nombre, Precio = precio, Descripcion = descripcion, FechaCreacion = DateTime.Now });
            }

            static void EditarProducto(ProductController service)
            {
                Console.Write("\nID a editar: ");
                int id = int.Parse(Console.ReadLine());

                service.Update(id, x =>
                {
                    Console.WriteLine($"Nuevo nombre ({x.Nombre})");
                    x.Nombre = Console.ReadLine();

                    Console.WriteLine($"Nuevo precio ({x.Precio})");
                    x.Precio = decimal.Parse(Console.ReadLine());

                });
            }

            static void EliminarProducto(ProductController service)
            {
                Console.Write("\nID a eliminar: ");
                int id = int.Parse(Console.ReadLine());
                service.Delete(id);
            }

        }
    }

}