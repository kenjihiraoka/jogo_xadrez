using System;

namespace xadrez
{
    class Tabuleiro {
        public int linhas { get; private set; } = 8;
        public int colunas { get; private set; } = 8;

        // Matriz de pecas do tabulerio
        private Peca[,] pecas;

        public Tabuleiro() {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        // imprimi o tabuleiro no console
        public static void imprimirTabuleiro(Tabuleiro tabuleiro) {
            for (int i = 0; i < tabuleiro.linhas; i++) {
                Console.Write(8 - i + "   ");
                for (int j = 0; j < tabuleiro.colunas; j++) {
                    Posicao pos = new Posicao(i, j);
                    imprimirPeca(tabuleiro.peca(pos));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("    a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca) {
            if(peca == null) {
                Console.Write("- ");
            }
            else {
                if (peca.cor == "Branca") {
                    Console.Write(peca);
                }
                else {
                    ConsoleColor cc = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(peca);
                    Console.ForegroundColor = cc;
                }
                Console.Write(" ");
            }
        }

        public static PosicaoTabuleiro lerMovimento() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoTabuleiro(coluna, linha);
        }

        public Peca peca(Posicao pos) {
            return pecas[pos.linha, pos.coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) {
            if (existePeca(pos)) {
                throw new Exception("Posicão já ocupada");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        // atualiza um espaço da peça para -
        public Peca atualizarPeca(Posicao pos) {
            if(peca(pos) == null) {
                return null;
            }
            
            Peca p = peca(pos);
            p.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return p;
        }

        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public bool posicaoValida(Posicao pos) {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas) {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) {
            if(!posicaoValida(pos)) {
                throw new Exception("Posição invalida");
            }
        }
    }    
}
