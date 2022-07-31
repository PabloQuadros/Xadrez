using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.tabuleiro;

namespace Xadrez.xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

         
        public PartidaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            turno= 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
            terminada = false;
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tabuleiro.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            tabuleiro.retirarPeca(destino);
            tabuleiro.colocarPeca(p, destino);
        }


        private void colocarPecas()
        {

        }
    }
}
