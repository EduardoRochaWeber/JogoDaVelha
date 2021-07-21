using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Verificacao verifica = new Verificacao();
            Jogo jogo = new Jogo();
            int[,] posicao = new int[4,4];
            int jogador = 1;
            int vencedor = 0;
            int cont = 9;
            int valido = 0;
            //int n1 = 0, n2 = 0;
            //int erro = 0;
            do
            {
                //do
                //{
                    Console.Clear();
                    Tabuleiro.ExibeTabuleiro(posicao);
                    jogo.PedePosicao(posicao, jogador, valido);
                //} while (valido == 0);
                //jogador = jogo.TrocaJogador(jogador);
                cont = verifica.VerificaTermino(posicao, cont);
                if (cont == 0)
                {
                    vencedor = 3;
                }
                else
                {
                    vencedor = verifica.VerificaVencedor(posicao);
                }
                //vencedor = jogador;
                //vencedor = VerificarVazio(vencedor);
            }
            while (vencedor == 0);
            jogo.MostraVencedor(vencedor, posicao);
            Console.ReadLine();
        }
    }
}
