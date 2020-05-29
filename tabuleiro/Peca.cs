using Projetoxadrez .tabuleiro;
using System;
using System .Collections .Generic;
using System .Text;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor{ get; protected set; }
        public int QtePosicao{ get; protected set; }
        public Mesa Mesa { get; set; }

        public Peca ( Posicao posicao , Cor cor , int qtePosicao, Mesa mesa )
        {
            Posicao = null;
            Cor = cor;
            QtePosicao = 0;
            Mesa = mesa;
        }

        public Peca ( Mesa mesa , Cor cor )
        {
            Mesa = mesa;
            Cor = cor;
        }
    }
}
