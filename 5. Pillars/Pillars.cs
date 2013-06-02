using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pillars
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

        int countOne = 0;
        int countTwo = 0;
        int result = 0;
        int pillar = 0;
        int num = 0;

        for (int i = 0; i < 8; i++)
        {
            countOne = 0;
            countTwo = 0;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((i != 0) || (i != 7))
                    {
                        if ((col < i) && (m[row, col] == 1))
                        {
                            countOne++;
                        }
                        if ((col > i) && (m[row, col] == 1))
                        {
                            countTwo++;
                        }
                    }
                    else if (((i == 0) && (col > i) && (m[row, col] == 1)) || ((i == 7) && (col < i) && (m[row, col] == 1)))
                    {
                        countOne++;
                        countTwo++;
                    }
                }
            }
            if (countOne == countTwo)
            {
                result++;
                pillar = i;
                num = countOne;
            }
        }
        if (result >= 1)
        {
            Console.WriteLine(pillar);
            Console.WriteLine(num);
            
        }                
        else 
        {
            Console.WriteLine("No");
        }
    }
}

