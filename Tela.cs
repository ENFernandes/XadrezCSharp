using Projetoxadrez .tabuleiro;
using System;
using System .Collections .Generic;
using System .Runtime .CompilerServices;
using System .Text;

namespace Projetoxadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro ( Mesa tab )
        {

            for (int l=0 ;l < tab.Linhas ; l++  )
            {
                for (int c =0 ; c< tab.Colunas ; c++ )
                {
                    if ( tab .peca ( l , c ) != null )
                    {
                        Console .Write ( tab .peca ( l , c ) + " " );
                    }
                    else
                    {
                        Console .Write ("- ");
                    }


                }
                Console .WriteLine ();
            }

        }
    }
}
