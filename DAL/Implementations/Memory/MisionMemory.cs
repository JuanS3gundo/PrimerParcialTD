using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memory
{
    public class MisionMemory : IMision
    {
        private static readonly MisionMemory _current = new MisionMemory();
        private string filePath = "mision.bin";

        // Propiedad estática para obtener la instancia única (singleton)
        public static MisionMemory Current => _current;

        // Constructor privado para evitar instancias adicionales
        private MisionMemory() { }

        public void GuardarMision(Mision mision)
        {
            List<Mision> misiones = CargarMisiones();
            misiones.Add(mision);
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, misiones);
            }
        }

        private List<Mision> CargarMisiones()
        {
            if (!File.Exists(filePath))
            {
                return new List<Mision>();
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Mision>)formatter.Deserialize(fs);
            }
        }

        public List<Mision> ObtenerMisiones(DateTime fechaDesde, DateTime fechaHasta)
        {
            var misiones = CargarMisiones();
            return misiones.Where(m => m.FechaHora >= fechaDesde && m.FechaHora <= fechaHasta).ToList();
        }
        
        public List<Mision> ObtenerTodasLasMisiones()
        {
            return CargarMisiones();
        }
    }
}
