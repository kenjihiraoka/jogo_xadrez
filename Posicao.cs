using System;

namespace xadrez
{
    class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void Posicao_2(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString() {
            return linha + ", " + coluna;
        }
    }    
}
