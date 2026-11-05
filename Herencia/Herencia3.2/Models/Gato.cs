namespace _03Herencia.Models;

public class Gato : Animal
{
    // Atributo propio
    public string ColorPelaje;

    public Gato(string nombre, int edad, string chip, string colorPelaje)
    {
        // Acceso permitido
        this.Nombre = nombre; 
        this.Edad = edad;     
            
        // Usamos el método público para el private
        this.AsignarChip(chip); 

        this.ColorPelaje = colorPelaje;
    }

    // Comportamiento propio
    public void Maullar()
    {
        Console.WriteLine($"{Nombre} (Color: {ColorPelaje}, Edad: {Edad} años) dice: ¡Miau!");
    }
}