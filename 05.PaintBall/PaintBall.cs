using System;

namespace _05.PaintBall
{
    class PaintBall
    {
        public static int count = 0;
        static void Main(string[] args)
        {
            int step = 1;
            int[] canvas = { 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023 };
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] separated = input.Split(' ');
                int[] toDo = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    toDo[i] = int.Parse(separated[i]);
                }

                if (toDo[2] == 0)
                {
                    canvas[toDo[0]] ^= 1 << toDo[1];
                    continue;
                }

                for (int i = 0; i < 10; i++)
                {
                    if ((i >= toDo[1] - toDo[2]) && (i <= toDo[1] + toDo[2]))
                    {
                        canvas[i] = ShootBits(canvas[i], toDo[1], toDo[2],step);
                    }
                }
                
            }
            int sum = 0;
            for (int i = 0; i < canvas.Length; i++)
            {
                sum += canvas[i];
            }
            Console.WriteLine(sum);
            
        }

        static int ShootBits(int number, int centerBit, int leftRight,int step)
        {
            int leftBits = centerBit + leftRight + 1;
            int rightBits = centerBit - leftRight - 1;
            int index = 0;
            int mask = 0;
            for (int bitIndex = 10; bitIndex > 0; bitIndex--)
            {
                if ((index > rightBits) && (index < leftBits))
                {
                    mask = mask | (1 << index);
                }
                index++;
            }
            if (count % 2 == 1)
            {
                number &= ~(mask);
            }
            else
            {
                number |= mask;
            }
            count++;
            return number;
        }
    }
}
