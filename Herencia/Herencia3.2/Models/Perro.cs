namespace _03Herencia.Models;

// Clase derivada: misma especie, pero con rasgos propios
public class Perro : Animal
{
    // Atributo específico de la clase derivada
    private string raza;

    public Perro(string nombre, int edad, string chip, string raza)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Especie = "Canis";
        AsignarChip(chip);
        this.raza = raza;
    }
    
    // Comportamiento propio del perro
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} dice: ¡Guau guau!");
    }

    // Acceso a miembros protegidos de la clase base
    public void MostrarInformacion()
    {
        // Puede acceder a Edad y Especie porque son protected
        Console.WriteLine($"Edad: {Edad} años | Especie: {Especie}");
        // numeroChip NO es accesible aquí (es private)
        // Console.WriteLine(numeroChip); // Error de compilación

        // Se accede mediante el método público
        Console.WriteLine($"Chip: {ObtenerChip()}");
    }
}