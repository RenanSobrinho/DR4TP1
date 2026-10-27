using System;
using System.IO;

class Program
{
    static void Main()
    {
        var logger = new Logger();
        Action<string>? log = null;

        Console.WriteLine("Invocando sem métodos associados:");
        log?.Invoke("Esta mensagem não será enviada.");

        log += logger.LogToConsole;
        log += logger.LogToFile;
        log += logger.LogToDatabase;

        Console.WriteLine("Invocando depois de associar os métodos:");
        log?.Invoke("Registro de teste do exercício 7.");
    }
}

public sealed class Logger
{
    public void LogToConsole(string message)
    {
        Console.WriteLine($"[Console] {message}");
    }

    public void LogToFile(string message)
    {
        File.AppendAllText(
            "logs.txt",
            $"[Arquivo] {message}{Environment.NewLine}");

        Console.WriteLine("Mensagem registrada em logs.txt.");
    }

    public void LogToDatabase(string message)
    {
        Console.WriteLine($"[Banco simulado] {message}");
    }
}
