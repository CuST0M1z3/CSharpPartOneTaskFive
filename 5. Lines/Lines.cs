using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Lines
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

        int len = 0;
        int count = 0;
        int maxLen = 0;

        for (int row = 0; row < 8; row++)
        {
            len = 0;
            for (int col = 0; col < 8; col++)
            {
                if (m[row, col] == 1)
                {
                    len++;
                }
                else
                {
                    
                    len = 0;
                }
                if (len == maxLen)
                {
                    count++;
                }
                if (len > maxLen)
                {
                    maxLen = len;
                    count = 1;
                }                
            }           
        }
        for (int col = 0; col < 8; col++)
        {
            len = 0;
            for (int row = 0; row < 8; row++)
            {
                if (m[row, col] == 1)
                {
                    len++;
                }
                else
                {                    
                    len = 0;
                }
                if (len == maxLen)
                {
                    count++;
                }
                if (len > maxLen)
                {
                    maxLen = len;
                    count = 1;
                }
            }
            
        }
        if (maxLen == 1)
        {
            count = count / 2;
        }
        Console.WriteLine(maxLen);
        Console.WriteLine(count);
    }
}

