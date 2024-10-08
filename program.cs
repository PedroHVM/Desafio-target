using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int num)
    {
        int a = 0;
        int b = 1;

        if (num == 0 || num == 1)
            return true;
        
        while (b < num)
        {
            int temp = b;
            b = a + b; 
            a = temp;  
        }

        return b == num;
    }
}
