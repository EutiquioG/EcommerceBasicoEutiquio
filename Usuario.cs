using System;

public class Usuario
{
    private int id;
    private string nombre;
    private string correo;
    private string contrasena;

    // Constructor
    public Usuario(int id, string nombre, string correo, string contrasena)
    {
        this.id = id;
        this.nombre = nombre;
        this.correo = correo;
        this.contrasena = contrasena;
    }

    // Getters
    public int GetId() { return id; }
    public string GetNombre() { return nombre; }
    public string GetCorreo() { return correo; }

    // Setters
    public void SetNombre(string nombre) { this.nombre = nombre; }
    public void SetCorreo(string correo) { this.correo = correo; }
    public void SetContrasena(string contrasena) { this.contrasena = contrasena; }

    // Destructor (opcional)
    ~Usuario()
    {
        Console.WriteLine("Usuario eliminado del sistema.");
    }

    public void MostrarUsuario()
    {
        Console.WriteLine($"Usuario: {nombre} - {correo}");
    }
}