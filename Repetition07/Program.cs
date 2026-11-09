namespace M320.Repetition07;

/// <summary>
/// Beispielausführung für die Repetitionsaufgaben zur Dokumentation.
/// </summary>
public class Program
{
    /// <summary>
    /// Einstiegspunkt: zeigt den Temperaturumrechner und den Verhältnisrechner.
    /// </summary>
    /// <param name="args">Kommandozeilenargumente (nicht verwendet).</param>
    public static void Main(string[] args)
    {
        TemperatureConverter converter = new TemperatureConverter();
        Console.WriteLine($"25 °C = {converter.CelsiusToFahrenheit(25):F1} °F");
        Console.WriteLine($"98.6 °F = {converter.FahrenheitToCelsius(98.6):F1} °C");

        Console.WriteLine($"RatioWithSurcharge(10, 4, 5) = {RatioCalculator.RatioWithSurcharge(10, 4, 5)}");

        try
        {
            RatioCalculator.RatioWithSurcharge(10, 4, 0);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Fehler: {ex.Message}");
        }
    }
}
