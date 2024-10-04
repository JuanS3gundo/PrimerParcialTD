using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MoverAtrasState : IRobotState
    {
        public void Move(Robot robot)
        {
            robot.MotorDerecho.MoverAtras(50);
            robot.MotorIzquierdo.MoverAtras(50);
            Console.WriteLine($"Retrocediendo: Potencia Motor Derecho = {robot.MotorDerecho.Potencia}, Potencia Motor Izquierdo = {robot.MotorIzquierdo.Potencia}. ambos motores girando hacia atras");
            robot.Parlante.Sonido();
        }
    }
}
