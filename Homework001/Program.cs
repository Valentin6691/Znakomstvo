﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 7 == 0 && num % 23 == 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}