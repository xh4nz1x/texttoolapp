using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("4. Изменить регистр");

        Console.Write("Ваш выбор: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "4":
                Console.WriteLine("1. В нижний регистр\n2. В верхний регистр");
                string subChoice = Console.ReadLine();
                if (subChoice == "1") Console.WriteLine(text.ToLower());
                else if (subChoice == "2") Console.WriteLine(text.ToUpper());
                else Console.WriteLine("Неверный выбор.");
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }
}