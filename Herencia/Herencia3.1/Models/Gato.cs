namespace Herencia3._1.Models;

// CLASE DERIVADA: hereda de Animal
public class Gato : Animal
{
    // Atributo específico del gato
    public string ColorPelaje;

    // Comportamiento específico del gato
    public void Maullar()
    {
        Console.WriteLine($"{Nombre} dice: ¡Miau!");
    }
}
