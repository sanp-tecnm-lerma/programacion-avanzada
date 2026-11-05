using System.IO.Ports;
namespace MonitorSensoresMecatronicos.Models; 
 public class Sensor
    {
        // 1. PRIVADO: Blindado.
        private string PuertoCom; 
        private SerialPort _serialPort;

        // 2. PROTEGIDO: Visible para las derivadas.
        protected double Distancia; 

        // 3. PÚBLICO: Visible para todos.
        public string Nombre; 

        // Constructor vacío (por si acaso)
        public Sensor()
        {
            Distancia = 0;
            Nombre = "Sensor Genérico";
        }

        // Método público para configurar el puerto (Reemplaza al constructor)
        public void ConfigurarPuerto(string puertoCom)
        {
            PuertoCom = puertoCom;
        }

        // Método público para abrir la conexión
        public void Conectar()
        {
            if (string.IsNullOrEmpty(PuertoCom))
            {
                Console.WriteLine($"[{Nombre}] Error: Primero debes configurar el puerto.");
                return;
            }

            _serialPort = new SerialPort(PuertoCom, 115200);
            try
            {
                _serialPort.Open();
                Console.WriteLine($"[{Nombre}] Conectado al puerto {PuertoCom}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{Nombre}] Error al conectar: {ex.Message}");
            }
        }

        // Método para leer el ESP32
        public void ActualizarLectura()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                try
                {
                    string dato = _serialPort.ReadLine();
                    if (double.TryParse(dato, out double valor))
                    {
                        Distancia = valor; // ✅ Asignación al atributo protected
                    }
                }
                catch { /* Ignorar errores de lectura */ }
            }
        }

        public void Desconectar()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
                Console.WriteLine($"[{Nombre}] Desconectado.");
            }
        }
    }