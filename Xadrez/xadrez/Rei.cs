using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.tabuleiro;

namespace Xadrez.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro,Cor cor) : base(tabuleiro,cor)
        {
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            //Para cima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha,pos.coluna] = true;
            }
            //ne
            pos.definirValores(posicao.linha - 1, posicao.coluna+1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Para Direita
            pos.definirValores(posicao.linha , posicao.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //se
            pos.definirValores(posicao.linha+1, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Para baixo
            pos.definirValores(posicao.linha + 1, posicao.coluna  );
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //so
            pos.definirValores(posicao.linha + 1, posicao.coluna-1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //no
            pos.definirValores(posicao.linha-1, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
