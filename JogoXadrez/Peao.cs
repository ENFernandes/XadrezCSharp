using Projetoxadrez .tabuleiro;
using System;
using System .Collections .Generic;
using System .Text;
using Tabuleiro;

namespace JogoXadrez
{
    class Peao : Peca
    {
        public Peao ( Mesa mesa , Cor cor ) : base ( mesa , cor )
        {

        }
        public override string ToString ( )
        {
            return "B";
        }
    }
}
