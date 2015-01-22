using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        char[,] matrix = new char[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRotations = n * n;
        int countLetter = 0;

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && row < 0 || matrix[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
            }

            matrix[row, col] = input[countLetter];


            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
            countLetter++;
            if (countLetter == input.Length)
            {
                countLetter = 0;
            }
        }
        string[] strings = new string[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                strings[i] += "" + matrix[i, j];
            }
        }
        int sums = 0;
        int maxSum = 0;
        int rows = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            foreach (var item in strings[i])
            {
                sums += (char.ToUpper(item) - 'A' + 1) * 10;
            }
            if (sums > maxSum)
            {
                maxSum = sums;
                rows = i;
            }
            sums = 0;
        }
        Console.WriteLine("{0} - {1}", rows, maxSum);


         //Display Matrix

        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0,4}", matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}