namespace M320.Repetition07;

/// <summary>
/// Rechnet Temperaturen zwischen den Einheiten Celsius und Fahrenheit um.
/// </summary>
public class TemperatureConverter
{
    /// <summary>
    /// Rechnet eine Temperatur von Grad Celsius in Grad Fahrenheit um.
    /// </summary>
    /// <param name="celsius">Die Temperatur in Grad Celsius.</param>
    /// <returns>Die entsprechende Temperatur in Grad Fahrenheit.</returns>
    public double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9.0 / 5.0 + 32;
    }

    /// <summary>
    /// Rechnet eine Temperatur von Grad Fahrenheit in Grad Celsius um.
    /// </summary>
    /// <param name="fahrenheit">Die Temperatur in Grad Fahrenheit.</param>
    /// <returns>Die entsprechende Temperatur in Grad Celsius.</returns>
    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5.0 / 9.0;
    }
}
