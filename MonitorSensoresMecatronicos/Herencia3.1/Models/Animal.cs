namespace Herencia3._1.Models;


// CLASE BASE: representa la categoría general "Animal"
public class Animal
{
    // Atributos comunes a TODOS los animales
    public string Nombre;
    public int Edad;

    // Comportamientos comunes a TODOS los animales
    public void Respirar()
    {
        Console.WriteLine($"{Nombre} está respirando...");
    }

    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }
}
