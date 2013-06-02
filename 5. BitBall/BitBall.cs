using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitBall
{
    static void Main()
    {
        int[,] m = new int[8, 8];
        int[,] n = new int[8, 8];

        int[,] fouls = new int[8, 8];

        for (int row = 0; row < 8; row++)
        {
            int bits = int.Parse(Console.ReadLine());

            for (int col = 0; col < 8; col++)
            {
                if ((bits & (1 << col)) != 0)
                {
                    m[row, col] = 1;
                }
            }
        }
        for (int row = 0; row < 8; row++)
        {
            int bits = int.Parse(Console.ReadLine());

            for (int col = 0; col < 8; col++)
            {
                if ((bits & (1 << col)) != 0)
                {
                    n[row, col] = 1;
                }
            }
        }

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if ((m[row, col] == 1) && (n[row, col] == 1))
                {
                    fouls[row, col] = 0;
                }
                else if ((m[row, col] == 0) && (n[row, col] == 1))
                {
                    fouls[row, col] = 1;
                }
                else if ((m[row, col] == 1) && (n[row, col] == 0))
                {
                    fouls[row, col] = 1;
                }
            }
        }

        int topScore = 0;
        int bottomScore = 0;


        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {                
                if ((fouls[row, col] == 1))
                {
                    if (n[row, col] == 1)
                    {
                        bottomScore++;
                        break;   
                    }
                    else if (m[row, col] == 1)
                    {
                        break;
                    }
                                 
                }             
            }
        }

        for (int col = 0; col < 8; col++)
        {
            for (int row = 7; row >=0 ; row--)
            {
                if ((fouls[row, col] == 1))
                {
                    if (n[row, col] == 1)
                    {
                        break;
                    }
                    else if (m[row, col] == 1)
                    {
                        topScore++;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(topScore + ":" + bottomScore);       
    }
}

