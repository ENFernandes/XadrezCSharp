using System;
using System .Collections .Generic;
using System .Text;
using Tabuleiro;
using Projetoxadrez .tabuleiro;

namespace JogoXadrez
{
    class Dama : Peca
    {
        public Dama ( Mesa mesa , Cor cor ) : base ( mesa , cor )
        {

        }
        public override string ToString ( )
        {
            return "B";
        }
    }
}
