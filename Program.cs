using System;

public class Program
{
    public static void Main()
    {
        string[] moves = new string[32];

        for (int i=0; i <= 31; i++)
        {
            Console.Write("Type in a move: ");
            moves[i] = Console.ReadLine();
            if (moves[i] == "done" || i >= 31)
            {
                break;
            }
        }

        Console.Write("Type in the number of iterations to iterate through: ");
        int num = Convert.ToInt32(Console.ReadLine()) - 1;

        for (int i = 0; i <= num; i++)
        {
            Console.WriteLine($"{moves[i]}");
        }
    }
}
