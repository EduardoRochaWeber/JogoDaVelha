using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Verificacao
    {
        Jogo jogo = new Jogo();
        Program program = new Program();
        public int VerificaVencedor(int[,] posicao)
        {
            int dado = 0;
            for (int i = 1; i <= 3; i++)
            {
                // Verifica na Horizontal
                if (posicao[i, 1] == posicao[i, 2] && posicao[i, 1] == posicao[i, 3] && posicao[i, 1] != 0)
                {
                    return dado = 1;
                }
                // Verifica na Vertical
                else if (posicao[1, i] == posicao[2, i] && posicao[1, i] == posicao[3, i] && posicao[1, i] != 0)
                {
                    return dado = 1;
                }
                // Verifica na Diagonal
                else if (posicao[1, 1] == posicao[2, 2] && posicao[1, 1] == posicao[3, 3] && posicao[1, 1] != 0 || posicao[1, 3] == posicao[2, 2] && posicao[1, 3] == posicao[3, 1] && posicao[3, 1] != 0)
                {
                    return dado = 1;
                }
                else
                {
                    return dado = 0;
                }

            }
            return dado = 0;
        }
        public int VerificaPosicao(int[,] posicao, int n1, int n2)
        {
            jogo.PedePosicao(posicao, jogo.Jogador, jogo.Valido);
            if (posicao[n1, n2] != 0)
            {
                return posicao[n1, n2];
            }
            else
            {
                return posicao[n1, n2] = 5;
            }
        }
        public int VerificaTermino(int[,] posicao, int cont)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (posicao[i, j] == 0)
                    {
                        cont--;
                        return cont;
                    }
                }
            }
            return cont;
        }
    }
}
