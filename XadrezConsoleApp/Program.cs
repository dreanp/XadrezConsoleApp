using System;
using tabuleiro;
using xadrez;

namespace XadrezConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez posicao = new PosicaoXadrez('c', 7);
            Console.WriteLine(posicao);

            Console.WriteLine(posicao.toPosicao());
            

            Console.ReadLine();
        }
    }
}
