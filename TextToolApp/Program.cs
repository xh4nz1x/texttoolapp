using System;

class Program
{
    static void Main()
    {
        Console.Write("Пожалуйста введите текст: ");
        string text = Console.ReadLine();

        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("1. Подсчёт символов и слов");

        Console.Write("Ваш выбор: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CountText(text);
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }

    static void CountText(string text)
    {
        int withSpaces = text.Length;
        int withoutSpaces = 0;
        int words = 0;

        bool inWord = false;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
            {
                withoutSpaces++;
                if (!inWord)
                {
                    inWord = true;
                    words++;
                }
            }
            else
            {
                inWord = false;
            }
        }

        Console.WriteLine($"Символов (с пробелами): {withSpaces}");
        Console.WriteLine($"Символов (без пробелов): {withoutSpaces}");
        Console.WriteLine($"Слов: {words}");
    }
}
