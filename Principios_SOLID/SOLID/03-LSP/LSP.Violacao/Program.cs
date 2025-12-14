using SOLID._03_LSP.LSP.Violacao;
using System;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quad = new Quadrado
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);
        }

        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine($"{ret.Altura.ToString()} * {ret.Largura.ToString()}");
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }
    }
}
