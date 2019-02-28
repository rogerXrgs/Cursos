using MeuPrimeiroPrograma.MinhasClasses;
using System;

namespace MeuPrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseA classeA = new ClasseA();
            ClasseB classeB = new ClasseB();

            int valor = classeA.valor1;

            Console.Write(valor);
            Console.Read();
        }
    }
}
