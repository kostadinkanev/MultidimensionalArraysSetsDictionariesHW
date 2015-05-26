using System;

class Sum
{
    static void Main()
    {
        string nums = Console.ReadLine();

        int n = int.Parse(nums[0].ToString());
        int m = int.Parse(nums[2].ToString());

        int help = n;
        int helppp = m;

        int[,] matrix = new int[n, m];

        int bestSum = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("matrix[{0}][{1}]= ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                          matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] +
                          matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    help = row;
                    helppp = col;
                }
            }
        }
        Console.WriteLine("maxsum: {0} ", bestSum);
        for (int row = help; row < (help + 3); row++)
        {
            for (int col = helppp; col < (helppp + 3); col++)
            {
                Console.Write("{0} ", matrix[row, col]);

            }
            Console.WriteLine();
        }

        
    }
}

