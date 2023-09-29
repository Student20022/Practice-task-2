using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введіть першу пропозицію: ");
        string sentence1 = Console.ReadLine();

        Console.Write("Введіть другу пропозицію: ");
        string sentence2 = Console.ReadLine();

        string[] words1 = sentence1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] words2 = sentence2.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var mergedWords = words1.Union(words2);

        string result = string.Join(" ", mergedWords);

        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }
}
