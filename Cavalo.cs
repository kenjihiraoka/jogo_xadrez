using System;

namespace xadrez
{
    class Cavalo: Peca {
        public Cavalo(Tabuleiro tabuleiro, string cor): base(tabuleiro, cor) {
        }

        public override string ToString() {
            return "C";
        }

        public override bool[,] movimentacao() {
            bool[,] matriz_movimentacao = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0,0);
            
            // posicao para baixo e a esquerda
            pos.Posicao_2(posicao.linha - 1, posicao.coluna - 2);
            if(tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao para esquerda e abaixo
            pos.Posicao_2(posicao.linha - 2, posicao.coluna - 1);
            if(tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao para esquerda e acima
            pos.Posicao_2(posicao.linha - 2, posicao.coluna + 1);
            if(tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao para esquerda e acima
            pos.Posicao_2(posicao.linha - 1, posicao.coluna + 2);
            if(tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao para direita e acima
            pos.Posicao_2(posicao.linha + 1, posicao.coluna + 2);
            if(tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao para direita e acima
            pos.Posicao_2(posicao.linha + 2, posicao.coluna + 1);
            if(tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao para direita e abaixo
            pos.Posicao_2(posicao.linha + 2, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao para direita e abaixo
            pos.Posicao_2(posicao.linha + 1, posicao.coluna - 2);
            if (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
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