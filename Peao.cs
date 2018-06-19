using System;

namespace xadrez
{
    class Peao: Peca {
        public Peao(Tabuleiro tabuleiro, string cor): base(tabuleiro, cor) {
        }

        public override string ToString() {
            return "P";
        }

        public override bool[,] movimentacao() {
            bool[,] matriz_movimentacao = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            if(this.cor == "Branca") {
                pos.Posicao_2(posicao.linha - 1, posicao.coluna);
                if(tabuleiro.posicaoValida(pos) && posicaoLivre(pos)) {
                    matriz_movimentacao[pos.linha, pos.coluna] = true;
                }
                pos.Posicao_2(posicao.linha - 2, posicao.coluna);
                if (tabuleiro.posicaoValida(pos) && posicaoLivre(pos) && movimento == 0){
                    matriz_movimentacao[pos.linha, pos.coluna] = true;
                }
                pos.Posicao_2(posicao.linha - 1, posicao.coluna - 1);
                if (tabuleiro.posicaoValida(pos) && posicaoInimigo(pos)) {
                    matriz_movimentacao[pos.linha, pos.coluna] = true;
                }
                pos.Posicao_2(posicao.linha - 1, posicao.coluna + 1);
                if (tabuleiro.posicaoValida(pos) && posicaoInimigo(pos)) {
                    matriz_movimentacao[pos.linha, pos.coluna] = true;
                }
            }
            else {
                pos.Posicao_2(posicao.linha + 1, posicao.coluna);
                if (tabuleiro.posicaoValida(pos) && posicaoLivre(pos))
                {
                    matriz_movimentacao[pos.linha, pos.coluna] = true;
                }
                pos.Posicao_2(posicao.linha + 2, posicao.coluna);
                if (tabuleiro.posicaoValida(pos) && posicaoLivre(pos) && movimento == 0)
                {
                    matriz_movimentacao[pos.linha, pos.coluna] = true;
                }
                pos.Posicao_2(posicao.linha + 1, posicao.coluna - 1);
                if (tabuleiro.posicaoValida(pos) && posicaoInimigo(pos))
                {
                    matriz_movimentacao[pos.linha, pos.coluna] = true;
                }
                pos.Posicao_2(posicao.linha + 1, posicao.coluna + 1);
                if (tabuleiro.posicaoValida(pos) && posicaoInimigo(pos))
                {
                    matriz_movimentacao[pos.linha, pos.coluna] = true;
                }
            }
            return matriz_movimentacao;
        }

        private bool posicaoLivre(Posicao pos) {
            return tabuleiro.peca(pos) == null;
        }

        private bool posicaoInimigo(Posicao pos) {
            Peca p = tabuleiro.peca(pos);
            return p != null && p.cor != this.cor;
        }

        private bool movimentoAceito(Posicao pos) {
            Peca p = tabuleiro.peca(pos);

            if (p == null || p.cor != this.cor) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}