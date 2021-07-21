using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Tabuleiro
    {
        public static void ExibeTabuleiro(int[,] posicao)
        {
            for (int l = 1; l < 4; l++)
            {
                for (int c = 1; c < 4; c++)
                {
                    if (posicao[l, c] == 0)
                    {
                        Console.Write(" - ");
                    }
                    else if (posicao[l, c] == 1)
                    {
                        Console.Write(" X ");
                    }
                    else if (posicao[l, c] == 2)
                    {
                        Console.Write(" O ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
