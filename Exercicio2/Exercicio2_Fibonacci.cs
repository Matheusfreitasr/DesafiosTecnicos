using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        if (VerificaFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool VerificaFibonacci(int numero)
    {
        int a = 0, b = 1, temp;

        while (b < numero)
        {
            temp = a + b;
            a = b;
            b = temp;
        }

        return b == numero || a == numero;
    }
}
