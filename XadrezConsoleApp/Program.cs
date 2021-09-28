using System;
using tabuleiro;
using xadrez;

namespace XadrezConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));

                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(3, 5));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(1, 4));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(0, 1));

                Tela.imprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
