using System;

class first
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix=new int[n,n];
        int k = 1;

        for (int i = 0; i < n ; i++)
        {
            for (int j = 0; j < n; j++)
            {
               
                matrix[j, i] = k;
                k++;

            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ",matrix[i, j]);

            }
            Console.WriteLine();
        }
    }
}

