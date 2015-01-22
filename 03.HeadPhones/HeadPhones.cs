using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HeadPhones
{
    class HeadPhones
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());

            int height = 2 * d;
            int width = 2 * d + 1;
            int center = width / 2;
            int count = width / 4 + 1;
            for (int i = 0; i < height / 2; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j >= center - count && j <= center + count)
                    {
                        Console.Write('*');
                    }
                    else if (i > 0 && ((j == center - count) || (j == center + count)))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }

            int countLeft = center - count;
            int countRight = center + count;
            int counter = 0;
            for (int i = 0; i < height / 2; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((j >= countLeft - counter && j <= countLeft + counter) || 
                        (j >= countRight - counter && j <= countRight + counter)) 
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
                if (i < height / 4)
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }
        }
    }
}
