using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("2. Инвертировать текст");

        Console.Write("Ваш выбор: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "2":
                Console.WriteLine("Инвертированный текст: " + ReverseText(text));
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
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
}