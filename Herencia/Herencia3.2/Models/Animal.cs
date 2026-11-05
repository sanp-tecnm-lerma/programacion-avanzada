namespace _03Herencia.Models;

public class Animal
{
    // ── Atributos con distintos niveles de acceso ──
    public string Nombre { get; set; }        // público: cualquiera lo ve
    public int Edad;                      // protegido: solo Animal y derivadas
    protected string Especie;                 // protegido
    private string numeroChip;               // privado: solo Animal

    // Constructor
    public Animal()
    {
        Nombre = "";
        Edad = 0;
        Especie = "";
        numeroChip = "";
    }

    // Comportamiento común a todos los animales
    public virtual void Respirar()
    {
        Console.WriteLine($"{Nombre} está respirando...");
    }

    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }

    // Método público para acceder al atributo privado de forma controlada
    public void AsignarChip(string chip)
    {
        this.numeroChip = chip;
    }
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