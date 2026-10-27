using System;

class Program
{
    static void Main()
    {
        var sensor = new TemperatureSensor();

        sensor.TemperatureExceeded += (_, temperature) =>
        {
            Console.WriteLine(
                $"ALERTA: temperatura de {temperature} °C acima de 100 °C!");
        };

        Console.WriteLine("Digite temperaturas. Digite 's' para sair.");

        while (true)
        {
            Console.Write("Temperatura: ");
            string? input = Console.ReadLine();

            if (string.Equals(input, "s", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (double.TryParse(input, out double temperature))
            {
                sensor.ReadTemperature(temperature);
            }
            else
            {
                Console.WriteLine("Temperatura inválida.");
            }
        }
    }
}

public sealed class TemperatureSensor
{
    public event EventHandler<double>? TemperatureExceeded;

    public void ReadTemperature(double temperature)
    {
        Console.WriteLine($"Leitura: {temperature} °C");

        if (temperature > 100)
        {
            TemperatureExceeded?.Invoke(this, temperature);
        }
    }
}
