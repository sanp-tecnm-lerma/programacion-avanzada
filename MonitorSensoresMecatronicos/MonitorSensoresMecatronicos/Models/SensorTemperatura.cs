using System;

namespace MonitorSensoresMecatronicos.Models;

public class SensorTemperatura : Sensor
{
    public SensorTemperatura(string nombre) : base(nombre) { }

    public override double LeerValor()
    {
        // Simula lectura entre 20 y 30 grados
        return 20.0 + (new Random().NextDouble() * 10); 
    }
}