using System;
using System.Collections.Generic;
using MonitorSensoresMecatronicos.Models;


// 3. Programa Principal (Polimorfismo y Excepciones)
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== SISTEMA MECATRÓNICO DE MONITOREO ===");
        Console.WriteLine("Iniciando lectura de sensores...\n");

        // Lista polimórfica: puede contener cualquier tipo de Sensor
        List<Sensor> sensores = new List<Sensor>
        {
            new SensorTemperatura("Termómetro del Motor"),
            new SensorDistancia("Sensor de Proximidad (Brazo Robótico)"),
            new SensorTemperatura("Termómetro del Ambiente")
        };

        // Iteramos sobre los sensores
        foreach (var sensor in sensores)
        {
            try
            {
                // POLIMORFISMO: Llamamos al mismo método, pero cada sensor lo hace a su manera
                double valor = sensor.LeerValor();
                
                // Formateamos la salida para que se vea bien en consola
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✔ {sensor.Nombre,-40} | Lectura: {valor:F2}");
            }
            catch (Exception ex)
            {
                // MANEJO DE EXCEPCIONES: Si un sensor falla, el programa no se cierra
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"✖ {sensor.Nombre,-40} | Error: {ex.Message}");
            }
            finally
            {
                // El bloque finally se ejecuta siempre, haya error o no.
                Console.ResetColor();
            }
        }

        Console.WriteLine("\n=== FIN DEL MONITOREO ===");
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}