using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IMision
    {
        void GuardarMision(Mision mision);
        List<Mision> ObtenerMisiones(DateTime fechadesde, DateTime fechahasta);
        List<Mision> ObtenerTodasLasMisiones();
    }
}
