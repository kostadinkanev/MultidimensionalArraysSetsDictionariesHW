using System;

class Coins
{
    static char[][] gameMatrix;
    static int x = 0;
    static int y = 0;
    static int coins = 0;
    static int walls = 0;
    static int correctX;
    static int correctY;


    static void MakeMove(char[] moves)
    {
        for (int i = 0; i < moves.Length; i++)
        {
            if (moves[i] == 'V')
            {
                y++;
                CheckForCoins();
            }
            else if (moves[i] == '^')
            {
                y--;
                CheckForCoins();
            }
            else if (moves[i] == '>')
            {
                x++;
                CheckForCoins();
            }
            else if (moves[i] == '<')
            {
                x--;
                CheckForCoins();
            }
        }
    }
    static void CheckForCoins()
    {
        char currentPosition;
        try
        {
            currentPosition = gameMatrix[y][x];
            if (currentPosition == '$')
            {
                coins++;
            }
            correctX = x;
            correctY = y;
        }
        catch (IndexOutOfRangeException exc)
        {
            walls++;
            x = correctX;
            y = correctY;
        }
    }
    static void Main(string[] args)
    {
        gameMatrix = new char[4][];

        for (int a = 0; a < gameMatrix.Length; a++)
        {
            char[] input = Console.ReadLine().ToCharArray();
            gameMatrix[a] = input;
        }
        char[] moves = Console.ReadLine().ToCharArray();
        MakeMove(moves);

        Console.WriteLine("Coins collected {0}", coins);
        Console.WriteLine("Walls hit {0}", walls);
    }
}





