using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sensor
    {
        // Propiedad para ver q color detecta el sensor
        public bool IsActive { get; private set; }

        
        public Sensor(bool isActive)
        {
            IsActive = isActive;
        }

        public void CambiarEstado(bool nuevoEstado)
        {
            IsActive = nuevoEstado;
        }
    }

}
