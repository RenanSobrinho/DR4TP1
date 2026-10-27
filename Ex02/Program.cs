using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o idioma:");
        Console.WriteLine("1 - Português");
        Console.WriteLine("2 - Inglês");
        Console.WriteLine("3 - Espanhol");
        Console.Write("Opção: ");

        string? opcao = Console.ReadLine();

        Action<string>? boasVindas = opcao switch
        {
            "1" => nome => Console.WriteLine($"Bem-vindo(a), {nome}!"),
            "2" => nome => Console.WriteLine($"Welcome, {nome}!"),
            "3" => nome => Console.WriteLine($"¡Bienvenido(a), {nome}!"),
            _ => null
        };

        if (boasVindas is null)
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        Console.Write("Digite seu nome: ");
        string nomeUsuario = Console.ReadLine() ?? "visitante";

        boasVindas(nomeUsuario);
    }
}
