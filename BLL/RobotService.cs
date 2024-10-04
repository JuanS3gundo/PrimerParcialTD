using DAL.Contracts;
using DAL.Factory;
using Domain;
using System;
using System.Collections.Generic;

public class RobotService
{
  private readonly IMision _mision;

    public RobotService()
    {
        _mision = FactoryDao.MisionDao;
    }

    public RobotService(IMision mision)
    {
        _mision = mision;
    }
        public void GuardarCambioDeEstado(Robot robot)
    {
        Mision nuevaMision = new Mision
        {
            FechaHora = DateTime.Now,
            ValorSensor1 = robot.Sensor1.IsActive,
            ValorSensor2 = robot.Sensor2.IsActive
        };
        _mision.GuardarMision(nuevaMision);
    }
    public void EvaluarSensores(Robot robot)
    {
        // Caso 1: Ambos sensores sobre la línea (negro-negro)
        if (robot.Sensor1.IsActive && robot.Sensor2.IsActive)
        {
            robot.EstadoActual = new MoverAdelanteState();  
        }
        // Caso 2: Solo el sensor izquierdo está sobre la línea (negro-blanco)
        else if (robot.Sensor1.IsActive && !robot.Sensor2.IsActive)
        {
            robot.EstadoActual = new GirarIzquierdaState();  
        }
        // Caso 3: Solo el sensor derecho está sobre la línea (blanco-negro)
        else if (!robot.Sensor1.IsActive && robot.Sensor2.IsActive)
        {
            robot.EstadoActual = new GirarDerechaState();  
        }
        // Caso 4: Ningún sensor está sobre la línea (blanco-blanco)
        else
        {
            robot.EstadoActual = new MoverAtrasState();  
        }
        robot.Mover();
        GuardarCambioDeEstado(robot);
    }
    public void MostrarTodasLasMisiones()
    {
        List<Mision> misiones = _mision.ObtenerTodasLasMisiones();
        if (misiones.Count > 0)
        {
            Console.WriteLine("Todas las misiones almacenadas:");
            foreach (var mision in misiones)
            {
                Console.WriteLine($"Fecha y hora: {mision.FechaHora}, Sensor1: {mision.ValorSensor1}, Sensor2: {mision.ValorSensor2}");
            }
        }
        else
        {
            Console.WriteLine("No hay misiones almacenadas.");
        }
    }
    public void MostrarMisionesPorFecha(DateTime fechaDesde, DateTime fechaHasta)
    {
        var misiones = _mision.ObtenerMisiones(fechaDesde, fechaHasta);

        if (misiones.Count > 0)
        {
            Console.WriteLine("Misiones encontradas entre {0} y {1}:", fechaDesde, fechaHasta);
            foreach (var mision in misiones)
            {
                Console.WriteLine("Fecha y hora: {0}, Sensor1: {1}, Sensor2: {2}",
                    mision.FechaHora, mision.ValorSensor1, mision.ValorSensor2);
            }
        }
        else
        {
            Console.WriteLine("No se encontraron misiones en el rango de fechas especificado.");
        }
    }
}
