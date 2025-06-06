using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("3. Удалить гласные");

        Console.Write("Ваш выбор: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "3":
                Console.WriteLine("Без гласных: " + RemoveVowels(text));
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
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
