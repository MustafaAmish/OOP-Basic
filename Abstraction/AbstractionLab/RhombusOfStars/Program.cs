using System;


public class Program
{
    static void Main(string[] args)
    {
        int rhombusSize = int.Parse(Console.ReadLine());
        for (int i = 0; i <= rhombusSize; i++)
        {
            PrintRow(i, rhombusSize);
        }
        for (int i = rhombusSize - 1; i > 0; i--)
        {
            PrintRow(i, rhombusSize);
        }
    }

    private static void PrintRow(int i, int size)
    {
        for (int j = 0; j < size - i; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

