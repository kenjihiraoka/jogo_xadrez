using System;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Partida partida = new Partida();

                while (!partida.jogada_feita) {
                    try
                    {
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
                    catch (System.Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (System.Exception e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
