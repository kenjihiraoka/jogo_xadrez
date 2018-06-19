using System;

namespace xadrez
{
    class Rei: Peca {
        public Rei(Tabuleiro tabuleiro, string cor) : base(tabuleiro, cor) {
        }

        public override string ToString() {
            return "R";
        } 

        public override bool[,] movimentacao() {
            bool[,] matriz_movimentacao = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            // posicao em cima
            pos.Posicao_2(posicao.linha - 1, posicao.coluna);
            if(tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao em cima e a esquerda
            pos.Posicao_2(posicao.linha - 1, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao a direita
            pos.Posicao_2(posicao.linha, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && movimentoAceito(pos))
            {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao em baixo e a direita
            pos.Posicao_2(posicao.linha + 1, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao em baixo
            pos.Posicao_2(posicao.linha + 1, posicao.coluna);
            if (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao em baixo e a esquerda
            pos.Posicao_2(posicao.linha + 1, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao a esquerda
            pos.Posicao_2(posicao.linha, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }

            // posicao em cima a esquerda
            pos.Posicao_2(posicao.linha - 1, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(pos) && movimentoAceito(pos)) {
                matriz_movimentacao[pos.linha, pos.coluna] = true;
            }
            return matriz_movimentacao;
        }

        private bool movimentoAceito(Posicao pos) {
            Peca p = tabuleiro.peca(pos);

            if(p == null || p.cor != this.cor) {
                return true;
            }
            else{
                return false;
            }
        }
    }    
}
