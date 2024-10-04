using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GirarDerechaState : IRobotState
    {
        public void Move(Robot robot)
        {
            robot.MotorIzquierdo.MoverAdelante(50);
            robot.MotorDerecho.MoverAtras(50);
            Console.WriteLine($"Girando a la derecha: Potencia Motor Derecho (girando hacia atras) = {robot.MotorDerecho.Potencia}, Potencia Motor Izquierdo = {robot.MotorIzquierdo.Potencia}");
        }
    }
}
