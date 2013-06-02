using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FallDown
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
        while (true)
        {
            count = 0;
            for (int row = 6; row >=0 ; row--)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (m[row, col] == 1 && m[(row + 1), col] == 0)
                    {
                        m[(row + 1), col] = 1;
                        m[row, col] = 0;
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                break;
            }
        }
        for (int row = 0; row < 8; row++)
        {
            string rowString = "";
            for (int col = 7; col >= 0; col--)
            {
                rowString += m[row, col];
            }
            Console.WriteLine(Convert.ToInt32(rowString, 2));
        }
    }
}

