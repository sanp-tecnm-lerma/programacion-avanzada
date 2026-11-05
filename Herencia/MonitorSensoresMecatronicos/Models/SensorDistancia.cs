using System;

namespace MonitorSensoresMecatronicos.Models;

public class SensorDistancia : Sensor
{
    public SensorDistancia(string nombre) : base(nombre) { }

    public override double LeerValor()
    {
        // Simula lectura entre 10 y 500 cm
        double valor = new Random().Next(10, 500);
        
        // Simulamos un fallo (ej. obstrucción del sensor)
        if (valor < 50) 
            throw new InvalidOperationException("Fallo de lectura: Obstrucción detectada.");

        return valor;
    }
}