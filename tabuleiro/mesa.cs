using System;
using System .Collections .Generic;
using System .Text;
using Tabuleiro;

namespace Projetoxadrez .tabuleiro
{
    class Mesa
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Mesa ( int linhas , int colunas )
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca [ linhas , colunas ];
        }
        public Peca peca ( int linha , int coluna )
        {

            return pecas[linha, coluna];
        
        }
    }
}
