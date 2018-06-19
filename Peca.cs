using System;

namespace xadrez
{
    abstract class Peca {
        public Posicao posicao { get; set; }
        public int movimento { get; protected set; }
        public string cor { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca (Tabuleiro tabuleiro, string cor) {
            this.posicao = null;
            this.tabuleiro = tabuleiro;
            this.movimento = 0;
            this.cor = cor;
        }

        public void incMovimento() {
            movimento++;
        }

        public bool destinoValido(Posicao pos) {
           return movimentacao()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentacao();
    }
}