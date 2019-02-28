using SinUDuckApp.Interfaces;

namespace SinUDuckApp
{
    public class Simulador
    {
         public void Executar(IPato pato)
        {
            pato.Grasnar();
            pato.Voar();
            pato.Nadar();
        }
    }
}
