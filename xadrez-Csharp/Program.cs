using System;
using tabuleiro;
using xadrez;

namespace xadrez_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(2, 5));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 7));


            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}
