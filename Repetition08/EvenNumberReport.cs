namespace M320.Repetition08;

public class EvenNumberReport
{
    public void PrintSumOfEvenNumbersTwice(List<int> numbers)
    {
        int sum = SumOfEvenNumbers(numbers);
        Console.WriteLine(sum);
        Console.WriteLine(sum);
    }

    private static int SumOfEvenNumbers(IEnumerable<int> numbers)
    {
        return numbers.Where(IsEven).Sum();
    }

    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
