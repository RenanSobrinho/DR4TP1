using System.Globalization;

public delegate decimal CalculateDiscount(decimal price);

internal class Program
{
    private static void Main()
    {
        Console.Write("Informe o preço original do produto: R$ ");

        if (!decimal.TryParse(
                Console.ReadLine(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out decimal price))
        {
            Console.WriteLine("Preço inválido.");
            return;
        }

        CalculateDiscount calculateDiscount = ApplyTenPercentDiscount;
        decimal finalPrice = calculateDiscount(price);

        Console.WriteLine($"Preço com 10% de desconto: {finalPrice:C}");
    }

    private static decimal ApplyTenPercentDiscount(decimal price)
    {
        return price * 0.90m;
    }
}
