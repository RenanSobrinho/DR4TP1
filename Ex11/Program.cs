using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Func<string, string, string> transformations = Concatenate;
        transformations += ConvertToUpper;
        transformations += RemoveWhitespace;

        string result = transformations("Ana", " Silva");

        Console.WriteLine($"Resultado retornado pelo delegate: [{result}]");
        Console.WriteLine(
            "Em delegates multicast com retorno, o resultado retornado " +
            "é o da última função. Todas recebem os mesmos argumentos.");
    }

    static string Concatenate(string first, string last)
    {
        string result = first + last;
        Console.WriteLine($"Concatenação: [{result}]");
        return result;
    }

    static string ConvertToUpper(string first, string last)
    {
        string result = (first + last).ToUpperInvariant();
        Console.WriteLine($"Maiúsculas: [{result}]");
        return result;
    }

    static string RemoveWhitespace(string first, string last)
    {
        string result = string.Concat(
            (first + last).Where(character => !char.IsWhiteSpace(character)));

        Console.WriteLine($"Sem espaços: [{result}]");
        return result;
    }
}
