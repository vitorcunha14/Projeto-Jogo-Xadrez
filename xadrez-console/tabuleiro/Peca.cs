using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
    
namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Position { get; set; }
        public Cor Color { get; protected set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor color)
        {
            Position = null;
            Tab = tab;
            Color = color;
            QteMovimentos = 0;
        }
        public void IncrementarQteMovimento()
        {
            QteMovimentos++;
        }
    }
}
