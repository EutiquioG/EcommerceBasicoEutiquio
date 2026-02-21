using System;
using System.Collections.Generic;

public class Carrito
{
    private List<Producto> productos;
    private double total;

    // Constructor
    public Carrito()
    {
        productos = new List<Producto>();
        total = 0;
    }

    public void AgregarProducto(Producto producto)
    {
        if (producto.GetStock() > 0)
        {
            productos.Add(producto);
            producto.SetStock(producto.GetStock() - 1);
            CalcularTotal();
            Console.WriteLine("Producto agregado al carrito.");
        }
        else
        {
            Console.WriteLine("No hay stock disponible.");
        }
    }

    public void RemoverProducto(Producto producto)
    {
        if (productos.Remove(producto))
        {
            producto.SetStock(producto.GetStock() + 1);
            CalcularTotal();
            Console.WriteLine("Producto eliminado del carrito.");
        }
    }

    public void CalcularTotal()
    {
        total = 0;
        foreach (var producto in productos)
        {
            total += producto.GetPrecio();
        }
    }

    public double GetTotal()
    {
        return total;
    }

    public void MostrarCarrito()
    {
        Console.WriteLine("\n--- CARRITO ---");
        foreach (var producto in productos)
        {
            Console.WriteLine($"{producto.GetNombre()} - ${producto.GetPrecio()}");
        }
        Console.WriteLine($"Total: ${total}");
    }
}