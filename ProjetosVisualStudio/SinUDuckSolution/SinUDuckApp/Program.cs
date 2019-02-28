using SinUDuckApp.Fabrica;
using SinUDuckApp.Interfaces;
using SinUDuckApp.Patos;
using System;

namespace SinUDuckApp
{
    class Program
    {
        static void Main(string[] args)
        {

            FabricaPatos fabrica = new FabricaPatos();
            Simulador simulador = new Simulador();

            foreach (var item in fabrica.ObeterPatos())
                simulador.Executar(item);

            //IPato patoSelvagem = new PatoSelvagem();

            //Console.WriteLine("Pato Selvagem");
            //patoSelvagem.Grasnar();
            //patoSelvagem.Voar();
            //patoSelvagem.Nadar();
            //patoSelvagem.Nadar("PatoTeste");
            //Console.WriteLine("\n");

            //IPato patoCabecaVermelha = new PatoCabecaVermelha();

            //Console.WriteLine("Pato Cabeça Vermelha");
            //patoCabecaVermelha.Grasnar();
            //patoCabecaVermelha.Voar();
            //patoCabecaVermelha.Nadar();
            //Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
