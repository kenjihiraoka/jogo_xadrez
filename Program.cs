using System;

namespace xadrez
{
    class Program
    {
        static void Main(){
            Console.Clear();
            Console.WriteLine("BEM VINDO AO JOGO DE XADREZ");
            Console.WriteLine("\n\nMENU:");
            Console.WriteLine("1 - Jogar");
            Console.WriteLine("2 - Instrucao");
            Console.WriteLine("3 - Sair");
            string opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    try {
                        Partida partida = new Partida();

                        while (!partida.jogada_feita) {
                            try {
                                Console.Clear();
                                Tabuleiro.imprimirTabuleiro(partida.tabuleiro);
                                Console.WriteLine("\n\nTurno: " + partida.turno);
                                Console.WriteLine("Jogador " + partida.jogador);

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.Write("Digite a casa da peca: ");
                                Posicao og = Tabuleiro.lerMovimento().xadrezToPosicao();
                                partida.validarOrigem(og);

                                Console.Write("Digite a casa de destino: ");
                                Posicao ds = Tabuleiro.lerMovimento().xadrezToPosicao();
                                partida.validarDestino(og, ds);

                                partida.Jogada(og, ds);
                            }
                            catch (System.Exception e) {
                                Console.WriteLine(e.Message);
                            }
                        }
                    }
                    catch (System.Exception e) {
                        Console.WriteLine(e.Message);
                    }
                    break;
                
                case "2":
                    Console.Clear();
                    Console.WriteLine("As peças estão divididas em brancas e pretas, iguais em número e força, que se movimentam segundo as convenções do jogo. " +  
                    "O objetivo dos movimentos que se chamam jogadas, é levar o Rei adversário a uma posição que se chama “xeque mate”, e ganha o jogo àquele que " + 
                    "conseguir colocar o Rei do adversário nesta posição critica primeiro.");
                    Console.WriteLine("\n\nMovimentacao das Pecas: ");
                    Console.WriteLine("Torre - A movimentação da torre se dá somente de forma horizontal (linhas do tabuleiro) ou vertical (colunas do tabuleiro).");
                    Console.WriteLine("Bispo - Esta peça se movimenta somente nas diagonais do tabuleiro.");
                    Console.WriteLine("Dama - Uma dama pode se movimentar tanto na horizontal como na vertical (assim como uma torre) ou nas diagonais (assim como um bispo).");
                    Console.WriteLine("Rei - Se movimenta em qualquer direção mas com limitação quanto ao número de casas. O limite de casas que um rei pode se deslocar é de uma casa por lance. " + 
                                      "O rei NUNCA pode fazer um movimento que resulte em um xeque para ele.");
                    Console.WriteLine("Peão - O peão somente pode fazer movimentos adjacentes à sua posição anterior, isto é, não pode retroceder. O peão, assim como o rei só pode deslocar-se 1 casa" +
                                      "à frente por lance, no entanto, quando o peão ainda está na sua posição inicial, este pode dar um salto de 2 casas à frente.");
                    Console.WriteLine("Cavalo - É a única peça que pode saltar sobre outras peças. A movimentação do cavalo é feita em forma de L, ou seja, anda 2 casas " + 
                                      "em qualquer direção (vertical ou horizontal) e depois mais uma em sentido perpendicular.");

                    Console.WriteLine("\n\nDigite ENTER para voltar ao MENU.");
                    Console.Read();
                    Main();
                    break;
                
                case "3":
                    break;

                default:
                    Console.WriteLine("Opcao invalida!");
                    Main();
                    break;
            }

            Console.ReadLine();
        }
    }
}
