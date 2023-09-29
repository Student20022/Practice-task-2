using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок: ");
        string inputString = Console.ReadLine();

        Console.Write("Введіть букву: ");
        char letter = Console.ReadKey().KeyChar;

        int firstIndex = inputString.IndexOf(letter);
        int lastIndex = inputString.LastIndexOf(letter);

        if (firstIndex != -1 && lastIndex != -1)
        {
            string substring = inputString.Substring(firstIndex + 1, lastIndex - firstIndex - 1);
            int count = substring.Count(c => c == letter);
            Console.WriteLine($"\nКількість входжень букви між першим і останнім: {count}");
        }
        else
        {
            Console.WriteLine("\nБуква не знайдена в рядку.");
        }
    }
}
