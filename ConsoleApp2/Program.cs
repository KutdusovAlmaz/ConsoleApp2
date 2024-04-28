using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите расстояние в сантиметрах: ");
        int L = Convert.ToInt32(Console.ReadLine());

        int meters = L / 100;

        Console.WriteLine("Количество полных метров: " + meters);
    }
}

