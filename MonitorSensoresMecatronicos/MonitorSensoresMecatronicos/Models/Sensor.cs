using System;

namespace MonitorSensoresMecatronicos.Models;

public abstract class Sensor
{
    public string Nombre { get; set; }

    protected Sensor(string nombre)
    {
        Nombre = nombre;
    }

    // Método abstracto que las clases hijas DEBEN implementar
    public abstract double LeerValor(); 
}