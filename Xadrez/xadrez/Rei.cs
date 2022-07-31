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

        public override string ToString()
        {
            return "R";
        }
    }
}
