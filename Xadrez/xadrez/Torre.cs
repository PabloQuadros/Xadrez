using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.tabuleiro;
namespace Xadrez.xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
}
