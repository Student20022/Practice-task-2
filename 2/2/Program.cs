using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок: ");
        string inputString = Console.ReadLine();

        string[] words = inputString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string result = string.Join(" ", words);

        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }
}
