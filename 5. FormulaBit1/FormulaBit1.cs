using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FormulaBit1
{
    static void Main()
    {
        int[,] m = new int[8, 8];

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

        int count = 0;
        int turn = -1;

        int cRow = 0;
        int cCol = 0;

        while (cRow < 8 && cCol < 8)
        {
            if (m[cRow, cCol] == 0)
            {
                turn++;
                while (cRow < 8 && m[cRow, cCol] == 0)
                {
                    count++;
                    cRow++;
                }
                cRow--;
                if (cRow == 7 && cCol == 7)
                {
                    Console.WriteLine(count + " " + turn);
                    break;
                }          
            }
            else
            {
                Console.WriteLine("No" + " " + count);
                break;
            }

            if (cRow < 8 && (cCol + 1) < 8 && m[cRow, (cCol + 1)] == 0)
            {
                turn++;
                cCol++;
                while (cCol < 8 && m[cRow, cCol] == 0)
                {
                    count++;
                    cCol++;
                }
                cCol--;
                if (cRow == 7 && cCol == 7)
                {
                    Console.WriteLine(count + " " + turn);
                    break;
                }                                       
            }           
            else
            {
                Console.WriteLine("No" + " " + count);
                break;
            }

            if (cRow >= 0 && cCol < 8 && m[(cRow - 1), cCol] == 0)
            {
                turn++;
                cRow--;
                while (cRow >= 0 && cCol < 8 && m[cRow, cCol] == 0)
                {
                    count++;
                    cRow--;
                }
                cRow++;
                if (cRow == 7 && cCol == 7)
                {
                    Console.WriteLine(count + " " + turn);
                    break;
                }          
            }
            else
            {
                Console.WriteLine("No" + " " + count);
                break;
            }

            if (cRow >= 0 && (cCol + 1) < 8 && m[cRow, (cCol + 1)] == 0)
            {
                turn++;
                cCol++;
                while (cCol < 8 && m[cRow, cCol] == 0)
                {
                    count++;
                    cCol++;
                }
                cCol--;
                cRow++;
                if (cRow == 7 && cCol == 7)
                {
                    Console.WriteLine(count + " " + turn);
                    break;
                }          
            }
            else
            {
                Console.WriteLine("No" + " " + count);
                break;
            }
        }
    }
}



