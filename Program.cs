using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Usuario usuario = new Usuario(1, "Carlos", "carlos@gmail.com", "1234");

        List<Producto> listaProductos = new List<Producto>()
        {
            new Producto(1, "Laptop", "Laptop Gamer", 3500, 5),
            new Producto(2, "Mouse", "Mouse Inalambrico", 50, 10)
        };

        Carrito carrito = new Carrito();

        int opcion;

        do
        {
            Console.WriteLine("\n--- E-COMMERCE ---");
            Console.WriteLine("1. Ver productos");
            Console.WriteLine("2. Agregar producto");
            Console.WriteLine("3. Ver carrito");
            Console.WriteLine("4. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    foreach (var Producto in listaProductos)
                        Producto.MostrarProducto();
                    break;

                case 2:
                    Console.Write("Ingrese ID del producto: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var producto = listaProductos.Find(p => p.GetId() == id);

                    if (producto != null)
                        carrito.AgregarProducto(producto);
                    else
                        Console.WriteLine("Producto no encontrado.");
                    break;

                case 3:
                    carrito.MostrarCarrito();
                    break;
            }

        } while (opcion != 4);
    }
}