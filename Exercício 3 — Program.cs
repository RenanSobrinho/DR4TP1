using System;

class Program
{
    static void Main()
    {
        Console.Write("Base do retângulo: ");
        bool baseValida = double.TryParse(Console.ReadLine(), out double width);

        Console.Write("Altura do retângulo: ");
        bool alturaValida = double.TryParse(Console.ReadLine(), out double height);

        if (!baseValida || !alturaValida)
        {
            Console.WriteLine("Informe valores numéricos válidos.");
            return;
        }

        Func<double, double, double> calcularArea = (baseRetangulo, alturaRetangulo) =>
            baseRetangulo * alturaRetangulo;

        double area = calcularArea(width, height);

        Console.WriteLine($"Área do retângulo: {area}");
    }
}
