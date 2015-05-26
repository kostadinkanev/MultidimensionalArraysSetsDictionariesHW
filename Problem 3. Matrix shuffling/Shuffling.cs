using System;

class Shuffling
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("matrix[{0}][{1}]= ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }

        string a = "swap";
        string input = Console.ReadLine();


        while (input != "END")
        {
            string[] mas = input.Split(' ');
            if (mas[0] == a)
            {
                string help = matrix[int.Parse(mas[1]), int.Parse(mas[2])];
                matrix[int.Parse(mas[1]), int.Parse(mas[2])] = matrix[int.Parse(mas[3]), int.Parse(mas[4])];
                matrix[int.Parse(mas[3]), int.Parse(mas[4])] = help;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                input = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Invalide input");
                input = Console.ReadLine();
            }
        }

    }
}

