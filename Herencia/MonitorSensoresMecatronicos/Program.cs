using System;
using System.IO.Ports;
namespace MonitorSensoresMecatronicos.Models;

class Program
{
    static void Main(string[] args)
    {
        // 1. Instanciamos (Constructor vacío)
        SensorDistancia sensorTanque = new SensorDistancia();
            
        // 2. Configuramos el puerto (Reemplaza el constructor con parámetros)
        sensorTanque.Iniciar("COM7"); // Cambia por tu puerto real
            
        // 3. Conectamos
        sensorTanque.Conectar();

        Console.WriteLine("\n--- Iniciando lectura (Presiona Enter para salir) ---");
            
        while (!Console.KeyAvailable)
        {
            sensorTanque.ActualizarLectura();
            sensorTanque.MostrarNivel();

            // --- PRUEBAS DE ACCESO ---
            // ❌ ERROR: 'Distancia' es protected (Main no puede verla)
            // sensorTanque.Distancia = 100; 
                
            // ❌ ERROR: 'PuertoCom' es private (Main no puede verlo)
            // sensorTanque.PuertoCom = "COM4"; 

            System.Threading.Thread.Sleep(100);
        }

        sensorTanque.Desconectar();
    }
}