using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable] 
    public class Mision
    {
        public DateTime FechaHora { get; set; }  
        public bool ValorSensor1 { get; set; }   
        public bool ValorSensor2 { get; set; }   

        
        public Mision() { }

        
        public Mision(DateTime fechaHora, bool valorSensor1, bool valorSensor2)
        {
            FechaHora = fechaHora;
            ValorSensor1 = valorSensor1;
            ValorSensor2 = valorSensor2;
        }

        
        public override string ToString()
        {
            return $"Fecha: {FechaHora}, Sensor 1: {ValorSensor1}, Sensor 2: {ValorSensor2}";
        }
    }
}
