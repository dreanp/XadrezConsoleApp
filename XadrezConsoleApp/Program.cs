using System;
using tabuleiro;

namespace XadrezConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tabuleiro);

            Console.ReadLine();
        }
    }
}
