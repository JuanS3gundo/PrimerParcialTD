using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MoverAdelanteState : IRobotState
    {
        public void Move(Robot robot)
        {
            robot.MotorDerecho.MoverAdelante(100);
            robot.MotorIzquierdo.MoverAdelante(100);
            Console.WriteLine($"Avanzando: Potencia Motor Derecho = {robot.MotorDerecho.Potencia}, Potencia Motor Izquierdo = {robot.MotorIzquierdo.Potencia}");
        }
    }
}
