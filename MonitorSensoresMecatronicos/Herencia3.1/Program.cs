namespace Herencia3._1.Models;

class Program
{
    static void Main(string[] args)
    {
        // Instanciamos un objeto de la clase derivada Perro
        Perro perroGuardian = new Perro();
        perroGuardian.Nombre = "Dante";
        perroGuardian.Edad = 3;
        perroGuardian.Raza = "Labrador";

        // Instanciamos un objeto de la clase derivada Gato
        Gato gatoCasa = new Gato();
        gatoCasa.Nombre = "tom";
        gatoCasa.Edad = 2;
        gatoCasa.ColorPelaje = "Naranja";

        Console.WriteLine("=== PERRO ===");
        perroGuardian.Respirar();   // Heredado de Animal
        perroGuardian.Comer();      // Heredado de Animal
        perroGuardian.Ladrar();     // Propio de Perro
        Console.WriteLine($"Raza: {perroGuardian.Raza}");

        Console.WriteLine("\n=== GATO ===");
        gatoCasa.Respirar();      // Heredado de Animal
        gatoCasa.Comer();         // Heredado de Animal
        gatoCasa.Maullar();       // Propio de Gato
        Console.WriteLine($"Color de pelaje: {gatoCasa.ColorPelaje}");
    }
}
