using System;

namespace xadrez
{
    class Partida {
        public Tabuleiro tabuleiro { get; private set; }
        public int turno { get; private set; }
        public string jogador { get; private set; }
        public bool jogada_feita { get; private set; }

        public Partida() {
            tabuleiro = new Tabuleiro();
            turno = 1;
            jogador = "Branca";
            posicionarPeca();
        }

        public void Movimento(Posicao og, Posicao ds) {
            Peca p = tabuleiro.atualizarPeca(og);
            p.incMovimento();
            Peca p_comida = tabuleiro.atualizarPeca(ds);
            tabuleiro.colocarPeca(p, ds);
            jogada_feita = false;
        }

        public void Jogada(Posicao og, Posicao ds) {
            Movimento(og, ds);
            turno++;
            trocaJogador();
        }

        private void trocaJogador() {
            if(jogador == "Branca") {
                jogador = "Preta";
            }
            else {
                jogador = "Branca";
            }
        }

        public void validarOrigem(Posicao pos) {
            if(tabuleiro.peca(pos) == null) {
                throw new Exception("Posicao vazia!");
            }
            if(jogador != tabuleiro.peca(pos).cor) {
                throw new Exception("Peca do jogador advresario!");
            }
        }

        public void validarDestino(Posicao og, Posicao ds) {
            if(!tabuleiro.peca(og).destinoValido(ds)) {
                throw new Exception("Destino invalido!");
            }
        }

        private void posicionarPeca() {
            tabuleiro.colocarPeca(new Torre(tabuleiro, "Branca"), new PosicaoTabuleiro('a', 1).xadrezToPosicao());
            tabuleiro.colocarPeca(new Cavalo(tabuleiro, "Branca"), new PosicaoTabuleiro('b', 1).xadrezToPosicao());
            tabuleiro.colocarPeca(new Bispo(tabuleiro, "Branca"), new PosicaoTabuleiro('c', 1).xadrezToPosicao());
            tabuleiro.colocarPeca(new Rainha(tabuleiro, "Branca"), new PosicaoTabuleiro('d', 1).xadrezToPosicao());
            tabuleiro.colocarPeca(new Rei(tabuleiro, "Branca"), new PosicaoTabuleiro('e', 1).xadrezToPosicao());
            tabuleiro.colocarPeca(new Bispo(tabuleiro, "Branca"), new PosicaoTabuleiro('f', 1).xadrezToPosicao());
            tabuleiro.colocarPeca(new Cavalo(tabuleiro, "Branca"), new PosicaoTabuleiro('g', 1).xadrezToPosicao());
            tabuleiro.colocarPeca(new Torre(tabuleiro, "Branca"), new PosicaoTabuleiro('h', 1).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Branca"), new PosicaoTabuleiro('a', 2).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Branca"), new PosicaoTabuleiro('b', 2).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Branca"), new PosicaoTabuleiro('c', 2).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Branca"), new PosicaoTabuleiro('d', 2).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Branca"), new PosicaoTabuleiro('e', 2).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Branca"), new PosicaoTabuleiro('f', 2).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Branca"), new PosicaoTabuleiro('g', 2).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Branca"), new PosicaoTabuleiro('h', 2).xadrezToPosicao());

            tabuleiro.colocarPeca(new Torre(tabuleiro, "Preta"), new PosicaoTabuleiro('a', 8).xadrezToPosicao());
            tabuleiro.colocarPeca(new Cavalo(tabuleiro, "Preta"), new PosicaoTabuleiro('b', 8).xadrezToPosicao());
            tabuleiro.colocarPeca(new Bispo(tabuleiro, "Preta"), new PosicaoTabuleiro('c', 8).xadrezToPosicao());
            tabuleiro.colocarPeca(new Rainha(tabuleiro, "Preta"), new PosicaoTabuleiro('d', 8).xadrezToPosicao());
            tabuleiro.colocarPeca(new Rei(tabuleiro, "Preta"), new PosicaoTabuleiro('e', 8).xadrezToPosicao());
            tabuleiro.colocarPeca(new Bispo(tabuleiro, "Preta"), new PosicaoTabuleiro('f', 8).xadrezToPosicao());
            tabuleiro.colocarPeca(new Cavalo(tabuleiro, "Preta"), new PosicaoTabuleiro('g', 8).xadrezToPosicao());
            tabuleiro.colocarPeca(new Torre(tabuleiro, "Preta"), new PosicaoTabuleiro('h', 8).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Preta"), new PosicaoTabuleiro('a', 7).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Preta"), new PosicaoTabuleiro('b', 7).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Preta"), new PosicaoTabuleiro('c', 7).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Preta"), new PosicaoTabuleiro('d', 7).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Preta"), new PosicaoTabuleiro('e', 7).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Preta"), new PosicaoTabuleiro('f', 7).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Preta"), new PosicaoTabuleiro('g', 7).xadrezToPosicao());
            tabuleiro.colocarPeca(new Peao(tabuleiro, "Preta"), new PosicaoTabuleiro('h', 7).xadrezToPosicao());
        }
    }   
}