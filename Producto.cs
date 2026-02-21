using System;

public class Producto
{
    // Atributos privados (Encapsulamiento)
    private int id;
    private string nombre;
    private string descripcion;
    private double precio;
    private int stock;

    // Constructor
    public Producto(int id, string nombre, string descripcion, double precio, int stock)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio = precio;
        this.stock = stock;
    }

    // Métodos GET y SET
    public int GetId() { return id; }
    public string GetNombre() { return nombre; }
    public string GetDescripcion() { return descripcion; }
    public double GetPrecio() { return precio; }
    public int GetStock() { return stock; }

    public void SetNombre(string nombre) { this.nombre = nombre; }
    public void SetDescripcion(string descripcion) { this.descripcion = descripcion; }
    public void SetPrecio(double precio) { this.precio = precio; }
    public void SetStock(int stock) { this.stock = stock; }

    public void MostrarProducto()
    {
        Console.WriteLine($"{id} - {nombre} - {descripcion} - ${precio} - Stock: {stock}");
    }
}