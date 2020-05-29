using Projetoxadrez .tabuleiro;
using System;
using System .Collections .Generic;
using System .Text;
using Tabuleiro;

namespace JogoXadrez
{
    class Bispo : Peca
    {
        public Bispo ( Mesa mesa , Cor cor ) : base ( mesa , cor )
        {

        }
        public override string ToString ( )
        {
            return "B";
        }
    }
}
