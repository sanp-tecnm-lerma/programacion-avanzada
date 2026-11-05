namespace Herencia3._1.Models;

// CLASE DERIVADA: hereda de Animal
public class Perro : Animal
{
    // Atributo específico del perro
    public string Raza;

    // Comportamiento específico del perro
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} dice: ¡Guau guau!");
    }
}