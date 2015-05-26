using System;
using System.ComponentModel;

class second
{
    static void Main()
    {
         int n = int.Parse(Console.ReadLine());
        int[,] matrix=new int[n,n];
        int k = 1;
        int l = 0;

        for (int i = 0; i < n ; i++)
        {
            int p = 1;
            
            for (int j = 0; j < n; j++)
            {
                if (i%2 == 0)
                {

                    matrix[j, i] = k;
                    k++;
                    l = k;
                }

                else
                {
                    matrix[j, i] = (l+n)- p;
                    p++;
                    k++;
                }
                

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

