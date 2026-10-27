using System;
using System.IO;

class Program
{
    static void Main()
    {
        var logger = new Logger();

        Action<string> log = logger.LogToConsole;
        log += logger.LogToFile;
        log += logger.LogToDatabase;

        log("Registro de teste do exercício 6.");
    }
}

public class Logger
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
