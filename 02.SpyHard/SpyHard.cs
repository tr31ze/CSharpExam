using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SpyHard
{
    class SpyHard
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int search = 0;
            foreach (var item in input)
            {
                if (item >= 'a' && item <= 'z')
                {
                    search += item - 'a' + 1;
                }
                else if (item >= 'A' && item <= 'Z')
                {
                    search += item - 'A' + 1;
                }
                else
                {
                    search += (int)item;
                }
            }
            string output = "";
            while (search > 0)
            {
                int remainder = search % n;

                output = remainder >= 10 ? (char)('A' + remainder - 10) + output : remainder + output;

                search /= n;
            }
            output = "" + n + input.Length + output;
            Console.WriteLine(output);
        }
    }
}
