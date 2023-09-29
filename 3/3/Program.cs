using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок: ");
        string inputString = Console.ReadLine();

        string[] words = inputString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Слова з буквами в алфавітному порядку:");
        foreach (string word in words)
        {
            if (IsAlphabetical(word))
            {
                Console.WriteLine(word);
            }
        }
    }

    static bool IsAlphabetical(string word)
    {
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] < word[i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
