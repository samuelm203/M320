namespace M320.Repetition07;

/// <summary>
/// Stellt Berechnungen für Verhältnisse mit einem prozentualen Zuschlag bereit.
/// </summary>
public static class RatioCalculator
{
    /// <summary>
    /// Berechnet das Verhältnis zweier Werte und addiert einen Zuschlag in Prozentpunkten.
    /// </summary>
    /// <param name="dividend">Der Wert, der geteilt wird.</param>
    /// <param name="divisor">Der Wert, durch den geteilt wird. Er darf nicht 0 sein.</param>
    /// <param name="surchargePercent">Der Zuschlag in Prozent, z.B. 5 für 5 % (= 0.05). Er darf nicht 0 sein.</param>
    /// <returns>Das Verhältnis <c>dividend / divisor</c> plus <c>surchargePercent / 100</c>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Wird ausgelöst, wenn <paramref name="surchargePercent"/> 0 ist.
    /// </exception>
    /// <exception cref="DivideByZeroException">
    /// Wird ausgelöst, wenn <paramref name="divisor"/> 0 ist.
    /// </exception>
    /// <remarks>
    /// Die ursprüngliche Methode hat bei einem Zuschlag von 0 den Wert -1 zurückgegeben.
    /// Das ist keine gute Idee: -1 kann auch ein gültiges Ergebnis sein (z.B. bei negativem Dividenden),
    /// und der Aufrufer kann einen vergessenen Fehler-Check nicht bemerken.
    /// Deshalb wird jetzt eine Exception geworfen, die den Fehler sofort und eindeutig meldet.
    /// </remarks>
    /// <example>
    /// <code>
    /// double result = RatioCalculator.RatioWithSurcharge(10, 4, 5); // 2.55
    /// </code>
    /// </example>
    public static double RatioWithSurcharge(double dividend, double divisor, int surchargePercent)
    {
        if (surchargePercent == 0)
            throw new ArgumentOutOfRangeException(nameof(surchargePercent), "Der Zuschlag darf nicht 0 sein.");
        if (divisor == 0)
            throw new DivideByZeroException("Der Divisor darf nicht 0 sein.");

        return dividend / divisor + surchargePercent * 0.01;
    }
}
