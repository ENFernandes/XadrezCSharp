using JogoXadrez;
using Projetoxadrez .tabuleiro;
using System;
using Tabuleiro;

namespace Projetoxadrez
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            Mesa tab = new Mesa(8,8);
            tab .CriarPeca ( new Torre ( tab , Cor .Preto ) , new Posicao ( 0 , 0 ) );
            tab .CriarPeca ( new Torre ( tab , Cor .Preto ) , new Posicao ( 1 , 3 ) );
            tab .CriarPeca ( new Rei ( tab , Cor .Preto ) , new Posicao ( 2 , 4 ) );

            Tela .ImprimirTabuleiro ( tab );
        }
    }
}
