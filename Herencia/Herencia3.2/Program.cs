using _03Herencia.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CREANDO OBJETOS ===");
            
        // 1. Instanciamos un Perro (usando su constructor)
        Perro perroGuardian = new Perro("Dante", 3, "CHIP-123", "Labrador");
            
        // 2. Instanciamos un Gato
        Gato michi = new Gato("Michi", 2, "CHIP-456", "Naranja");


        Console.WriteLine("\n=== PRUEBAS DE ACCESO DESDE MAIN ===");
            
        // --- ACCESO A 'PUBLIC' ---
        Console.WriteLine($"Nombre del perro: {perroGuardian.Nombre}"); // ✅ Funciona
        perroGuardian.Nombre = "Dante Jr."; // ✅ Funciona

        // --- ACCESO A 'PROTECTED' ---
        // ERROR DE COMPILACIÓN si descomentas la siguiente línea:
        // perroGuardian.Edad = 5; 
        // Main no es una clase derivada, por lo que no puede ver 'Edad'.

        // --- ACCESO A 'PRIVATE' ---
        // ERROR DE COMPILACIÓN si descomentas la siguiente línea:
        // perroGuardian.NumeroChip = "HACKED"; 
        // Main no puede ver 'NumeroChip'.
            
        // ✅ Acceso indirecto al private a través de un método público:
        Console.WriteLine($"Chip del perro: {perroGuardian.ObtenerChip()}");


        Console.WriteLine("\n=== EJECUTANDO COMPORTAMIENTOS ===");
        perroGuardian.Respirar(); // Método heredado de Animal
        perroGuardian.Ladrar();   // Método propio de Perro

        Console.WriteLine();
        michi.Respirar();    // Método heredado
        michi.Maullar();     // Método propio
            
        Console.ReadLine();
    }
}