using System;

namespace xadrez
{
    class PosicaoTabuleiro {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoTabuleiro(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao xadrezToPosicao() {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString() {
            return "" + coluna + linha;
        } 
    }
}