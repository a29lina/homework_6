


//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Zadacha41()
{
    Console.WriteLine("Сколько чисел введете?");
    int amount = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < amount; i++)
    {
        Console.Write($"Введите {i + 1} число");
        Console.WriteLine();
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }

    Console.WriteLine($"Количество чисел больше нуля: {count}");
}



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Zadacha43()
{
    Console.Write($"Введите b1:");
    Console.WriteLine();
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите k1:");
    Console.WriteLine();
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите b2:");
    Console.WriteLine();
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите k2:");
    Console.WriteLine();
    double k2 = Convert.ToDouble(Console.ReadLine());

    if (k1 == k2)
    {
        Console.WriteLine("Параллельные прямые");
    }
    else
    {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"x = {x}");
    Console.WriteLine($"y = {y}");
    }
}
