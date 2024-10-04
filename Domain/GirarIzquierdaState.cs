using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GirarIzquierdaState : IRobotState
    {
        public void Move(Robot robot)
        {
            robot.MotorDerecho.MoverAdelante(50);
            robot.MotorIzquierdo.MoverAtras(50);
            Console.WriteLine($"Girando a la izquierda: Potencia Motor Derecho = {robot.MotorDerecho.Potencia}, Potencia Motor Izquierdo (girando hacia atras) = {robot.MotorIzquierdo.Potencia}");
        }
    }
}
