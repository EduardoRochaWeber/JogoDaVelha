using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Jogo
    {
        public int[,] Posicao { get; set; }
        public int Jogador { get; set; }
        public int Vencedor { get; set; }
        public int Cont { get; set; }
        public int Valido { get; set; }

        public Jogo(int[,] posicao, int jogador, int vencedor, int cont, int valido)
        {
            this.Posicao = posicao;
            this.Jogador = jogador;
            this.Vencedor = vencedor;
            this.Cont = cont;
            this.Valido = valido;
        }
        public Jogo()
        {

        }
        //int[,] posicao = new int[4, 4];
        //int jogador = 1;
        //int vencedor = 0;
        //int cont = 9;
        //int valido = 0;

        public void PedePosicao(int[,] posicao, int jogador, int valido)
        {
            Verificacao verifica = new Verificacao();
            Console.WriteLine("Escolha uma posição de jogada");
            Console.Write("Linha: ");
            int lin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coluna: ");
            int col = Convert.ToInt32(Console.ReadLine());
            //Verificacao verifica = new Verificacao();
            //posicao[lin, col] = Convert.ToInt32(Console.ReadLine());
            if (posicao[lin, col] == 0)
            {
                ValorJogada(posicao, lin, col, jogador, valido);
                verifica.VerificaTermino(posicao, Cont);
                jogador = TrocaJogador(jogador);
            }
            verifica.VerificaTermino(posicao, Cont);
            //posicao[lin, col]; //= verifica.VerificaPosicao(posicao, lin, col);

            /*if (posicao[lin, col] != 5)
            {
                //erro++;
                //jogo.VerificaErro(erro, jogador);
                //Console.Clear();
                //Tabuleiro.ExibeTabuleiro(posicao);
                Console.WriteLine("Posição inválida!");
                Console.ReadLine();
                //jogador = TrocaJogador(jogador);
                ValorJogada(posicao, lin, col, jogador);
                return valido;
            }
            ValorJogada(posicao, lin, col, jogador);
            return valido = 1;*/
        }
        public int ValorJogada(int[,] posicao, int lin, int col, int jogador, int valido)
        {
            if (jogador == 1)
            {
                    
                return posicao[lin, col] = 1;
            }
            else
            {
                return posicao[lin, col] = 2;
            }
        }
        public int TrocaJogador(int jogador)
        {
            if (jogador == 1)
            {
                return jogador = 2;
            }
            else
            {
                return jogador = 1;
            }

        }
        public void MostraVencedor(int vencedor, int[,] posicao)
        {
            string pessoa = String.Empty;
            if (vencedor != 3)
            {
                if (vencedor == 1)
                {
                    pessoa = "jogador 1";
                }
                else if (vencedor == 2)
                {
                    pessoa = "jogador 2";
                }
                Console.Clear();
                Tabuleiro.ExibeTabuleiro(posicao);
                Console.WriteLine($"O vencedor é o {pessoa}");
            }
            else
            {
                Console.Clear();
                Tabuleiro.ExibeTabuleiro(posicao);
                Console.WriteLine("O jogo empatou!");
            }
        }
        /*public int VerificaErro(int erro, int jogador)
        {
            Program program = new Program();
            if (erro % 2 == 1)
            {
                return jogador;
            }
            else
            {
                return jogador;
            }
        }*/
    }
}
