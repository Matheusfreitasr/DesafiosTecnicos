using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string para inverter: ");
        string texto = Console.ReadLine();

        string invertida = InverteString(texto);
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverteString(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        string resultado = "";

        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            resultado += caracteres[i];
        }

        return resultado;
    }
}
