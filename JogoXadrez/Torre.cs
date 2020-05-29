using Projetoxadrez .tabuleiro;
using System;
using System .Collections .Generic;
using System .Text;
using Tabuleiro;

namespace JogoXadrez
{
    class Torre : Peca
    {
        public Torre ( Mesa mesa , Cor cor ) : base ( mesa , cor )
        {

        }
        public override string ToString ( )
        {
            return "T";
        }
    }
}
