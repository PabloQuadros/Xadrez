using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }



        public Peca( Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }

        public void incrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
        
    }
}
