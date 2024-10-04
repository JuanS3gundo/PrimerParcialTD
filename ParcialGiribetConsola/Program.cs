using DAL;
using DAL.Contracts;
using DAL.Factory;
using DAL.Implementations.Memory;
using DAL.Implementations.SQLServer;
using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParcialGiribetConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robotService = new RobotService();
            Robot robot = new Robot(new Sensor(false), new Sensor(false), new Motor(), new Motor(), new Parlante());

            string comando = "";
            do
            {
                try
                {
                    Console.WriteLine("Ingrese un comando: [sensores, buscar, mostrar todas, salir]");
                    comando = Console.ReadLine().ToLower();

                    switch (comando)
                    {
                        case "sensores":
                            try
                            {
                                Console.WriteLine("Ingrese los valores de los sensores (true/false para cada uno):");
                                Console.Write("Sensor izquierdo (Sensor1): ");
                                robot.Sensor1 = new Sensor(bool.Parse(Console.ReadLine()));

                                Console.Write("Sensor derecho (Sensor2): ");
                                robot.Sensor2 = new Sensor(bool.Parse(Console.ReadLine()));
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error: Los valores de los sensores deben ser 'true' o 'false'.");
                                break;
                            }

                            robotService.EvaluarSensores(robot);
                            robotService.GuardarCambioDeEstado(robot);

                            Console.WriteLine($"Estado guardado: FechaHora = {DateTime.Now}, Sensor1 = {robot.Sensor1.IsActive}, Sensor2 = {robot.Sensor2.IsActive}");
                            break;

                        case "buscar":
                            try
                            {
                                Console.WriteLine("Ingrese la fecha desde (YYYY-MM-DD):");
                                DateTime fechaDesde = DateTime.Parse(Console.ReadLine());

                                Console.WriteLine("Ingrese la fecha hasta (YYYY-MM-DD):");
                                DateTime fechaHasta = DateTime.Parse(Console.ReadLine());

                                robotService.MostrarMisionesPorFecha(fechaDesde, fechaHasta);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error: Las fechas deben estar en el formato correcto (YYYY-MM-DD).");
                            }
                            break;

                        case "mostrar todas":
                            robotService.MostrarTodasLasMisiones();
                            break;

                        case "salir":
                            Console.WriteLine("Saliendo...");
                            break;

                        default:
                            Console.WriteLine("Comando no reconocido.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrió un error: {ex.Message}");
                }

            } while (comando != "salir");
        }
    }
}
