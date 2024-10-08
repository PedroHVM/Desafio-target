using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        int quantidade = ContarLetrasA(input);

        if (quantidade > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {quantidade} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não foi encontrada na string.");
        }
    }

    static int ContarLetrasA(string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }

        return count;
    }
}
