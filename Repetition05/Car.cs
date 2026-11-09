namespace M320.Repetition05;

public class Car
{
    private Engine _engine;

    public Engine Engine => _engine;

    public Car(Engine engine)
    {
        _engine = engine;
    }

    public Engine ReplaceEngine(Engine newEngine)
    {
        Engine oldEngine = _engine;
        _engine = newEngine;
        return oldEngine;
    }
}
