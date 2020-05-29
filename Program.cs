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

            Tela .ImprimirTabuleiro ( tab );
        }
    }
}
