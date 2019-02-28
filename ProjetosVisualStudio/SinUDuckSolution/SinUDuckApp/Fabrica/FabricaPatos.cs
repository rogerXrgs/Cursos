using SinUDuckApp.Interfaces;
using SinUDuckApp.Patos;
using System.Collections.Generic;

namespace SinUDuckApp.Fabrica
{
    public class FabricaPatos
    {
        public List<IPato> ObeterPatos()
        {
            List<IPato> patos = new List<IPato>();
            patos.Add(new PatoSelvagem());
            patos.Add(new PatoCabecaVermelha());

            return patos;
        }
    }
}
