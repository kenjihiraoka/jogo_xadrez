using System;

namespace xadrez
{
    class Rainha: Peca {
        public Rainha(Tabuleiro tabuleiro, string cor): base(tabuleiro, cor) {
        }

        public override string ToString() {
            return "r";
        }

        public override bool[,] movimentacao() {
            bool[,] matriz_movimentacao = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            // posicao em cima
            pos.Posicao_2(posicao.linha - 1, posicao.coluna);
            while (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            // posicao em baixo
            pos.Posicao_2(posicao.linha + 1, posicao.coluna);
            while (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            // posicao a direita
            pos.Posicao_2(posicao.linha, posicao.coluna + 1);
            while (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            // posicao a esquerda
            pos.Posicao_2(posicao.linha, posicao.coluna - 1);
            while (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }

            // posicao em cima e a esquerda
            pos.Posicao_2(posicao.linha - 1, pos.coluna - 1);
            while (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.linha = pos.linha - 1;
                pos.coluna = pos.coluna - 1;
            }

            // posicao em cima e a direita
            pos.Posicao_2(posicao.linha - 1, pos.coluna + 1);
            while (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.linha = pos.linha - 1;
                pos.coluna = pos.coluna + 1;
            }

            // posicao em baixo e a direita
            pos.Posicao_2(posicao.linha + 1, pos.coluna + 1);
            while (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.linha = pos.linha + 1;
                pos.coluna = pos.coluna + 1;
            }

            // posicao em baixo e a esquerda
            pos.Posicao_2(posicao.linha + 1, pos.coluna - 1);
            while (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.linha = pos.linha + 1;
                pos.coluna = pos.coluna - 1;
            }
            return matriz_movimentacao;
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