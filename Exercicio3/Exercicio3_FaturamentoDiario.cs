using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> faturamento = new List<double> { 100, 200, 0, 300, 0, 0, 500, 400, 0, 150, 600, 0, 0, 100, 700 };

        // Filtrar dias com faturamento
        var diasComFaturamento = faturamento.FindAll(dia => dia > 0);

        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0;

        foreach (var valor in diasComFaturamento)
        {
            if (valor < menorFaturamento) menorFaturamento = valor;
            if (valor > maiorFaturamento) maiorFaturamento = valor;
            somaFaturamento += valor;
        }

        double mediaMensal = somaFaturamento / diasComFaturamento.Count;
        int diasAcimaDaMedia = diasComFaturamento.FindAll(dia => dia > mediaMensal).Count;

        Console.WriteLine($"Menor faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
        Console.WriteLine($"Dias acima da média mensal: {diasAcimaDaMedia}");
    }
}
