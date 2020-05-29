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

        public Peca ( Posicao posicao , Cor cor , int qtePosicao )
        {
            Posicao = posicao;
            Cor = cor;
            QtePosicao = 0;
        }
    }
}
