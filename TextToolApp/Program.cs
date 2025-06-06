using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст:: ");
        string text = Console.ReadLine();

        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("1. Подсчёт символов и слов");
        Console.WriteLine("2. Инвертировать текст");
        Console.WriteLine("3. Удалить гласные");

        Console.Write("Ваш выбор: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CountText(text);
                break;
            case "2":
                Console.WriteLine("Инвертированный текст: " + ReverseText(text));
                break;
            case "3":
                Console.WriteLine("Без гласных: " + RemoveVowels(text));
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

    static string ReverseText(string text)
    {
        char[] reversed = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            reversed[i] = text[text.Length - 1 - i];
        }
        return new string(reversed);
    }
    static string RemoveVowels(string text)
        {
            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouAEIOU";
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                bool isVowel = false;
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (text[i] == vowels[j])
                    {
                        isVowel = true;
                        break;
                    }
                }
                if (!isVowel)
                {
                    result += text[i];
                }
            }
            return result;
        }
}