using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Motor
    {
        public int Potencia { get; private set; }  

        public void MoverAdelante(int potencia)
        {
            Potencia = potencia;    
        }
        public void MoverAtras(int potencia)
        {
            Potencia = -potencia;   
        }
    }
}
