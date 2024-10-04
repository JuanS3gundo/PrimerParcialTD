using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain
{
    public class Robot
    {
        public Sensor Sensor1 { get; set; }
        public Sensor Sensor2 { get; set; }
        public Motor MotorIzquierdo { get; set; }
        public Motor MotorDerecho { get; set; }
        public Parlante Parlante { get; set; }
        public IRobotState EstadoActual { get; set; }  



        public Robot(Sensor sensor1, Sensor sensor2, Motor motorIzquierdo, Motor motorDerecho, Parlante parlante)
        {
            Sensor1 = sensor1;
            Sensor2 = sensor2;
            MotorIzquierdo = motorIzquierdo;
            MotorDerecho = motorDerecho;
            Parlante = parlante;
            EstadoActual = new MoverAdelanteState();  

        }
        public void Mover()
        {
            EstadoActual.Move(this);  
        }
    }
}
