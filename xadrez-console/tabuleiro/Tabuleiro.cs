using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas  )
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[ linhas, Colunas ];
        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public bool ExistePeca(Posicao pos)
        {
            ValidarPos(pos);
            return peca(pos) != null;
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Ja existe uma peça nessa posição ");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.Position = pos;
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }
        public bool PosValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        public void ValidarPos (Posicao pos)
        {
            if (!PosValida(pos))
            {
                throw new TabuleiroException("Posição invalida! ");
            }
        }
    }
}
