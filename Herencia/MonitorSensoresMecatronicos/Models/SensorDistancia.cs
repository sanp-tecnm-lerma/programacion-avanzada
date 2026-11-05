using System;

namespace MonitorSensoresMecatronicos.Models;

// Clase derivada (Tema 3.1)
public class SensorDistancia : Sensor
{
    // Constructor vacío (NO usa base)
    public SensorDistancia() 
    {
        Nombre = "Sensor de Nivel"; // ✅ Acceso a public
    }

    // Método de inicialización
    public void Iniciar(string puerto)
    {
        ConfigurarPuerto(puerto); // ✅ Llamada a método público
    }

    public void MostrarNivel()
    {
        // ✅ Puede usar 'Distancia' porque es protected
        Console.WriteLine($"Nivel del tanque: {Distancia} cm");
            
        // ❌ ERROR DE COMPILACIÓN si descomentas esto:
        // Console.WriteLine($"Puerto: {PuertoCom}"); 
    }
}