namespace _03Herencia.Models;

public class Gato : Animal
{
    private bool esIndependiente;

    public Gato(string nombre, int edad, string chip, bool independiente)
        : base(nombre, edad, "Felis silvestris catus", chip)
    {
        esIndependiente = independiente;
    }

    public override void Comer()
    {
        Console.WriteLine($"{Nombre} come pescado con elegancia.");
    }

    public void Maullar()
    {
        Console.WriteLine($"{Nombre} dice: ¡Miau!");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Edad: {Edad} | Especie: {Especie} | Independiente: {esIndependiente}");
    }
}