using SinUDuckApp.Interfaces;
using System;

namespace SinUDuckApp.Patos
{
    class PatoCabecaVermelha : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Grasnndo");
        }

        public virtual void Voar()
        {
            Console.WriteLine("Voando");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine("Nadando");
        }
    }
}
