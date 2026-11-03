using _03Herencia.Models;

class Program
{
    static void Main(string[] args)
    {
        Perro perro = new Perro("Dante", 3, "CHIP-001", "Labrador");
        Gato gato = new Gato("Michi", 2, "CHIP-002", true);

        Console.WriteLine("=== PERRO ===");
        perro.Respirar();      // heredado
        perro.Comer();         // sobrescrito
        perro.Ladrar();        // propio
        perro.MostrarInformacion();

        Console.WriteLine("\n=== GATO ===");
        gato.Respirar();       // heredado
        gato.Comer();          // sobrescrito
        gato.Maullar();        // propio
        gato.MostrarInformacion();
    }
}