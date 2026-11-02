namespace _03Herencia.Models;

public class Animal
{
    // ── Atributos con distintos niveles de acceso ──
    public string Nombre { get; set; }        // público: cualquiera lo ve
    protected int Edad;                      // protegido: solo Animal y derivadas
    protected string Especie;                 // protegido
    private string numeroChip;               // privado: solo Animal

    // Constructor
    public Animal(string nombre, int edad, string especie, string chip)
    {
        Nombre = nombre;
        Edad = edad;
        Especie = especie;
        numeroChip = chip;
    }

    // Comportamiento común a todos los animales
    public virtual void Respirar()
    {
        Console.WriteLine($"{Nombre} está respirando...");
    }

    public virtual void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }

    // Método público para acceder al atributo privado de forma controlada
    public string ObtenerChip()
    {
        return numeroChip;
    }

    // Método protegido: disponible para las clases derivadas
    protected void MostrarDatosBase()
    {
        Console.WriteLine($"Nombre: {Nombre} | Edad: {Edad} | Especie: {Especie}");
    }
}