internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число1");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число2");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int result = number1 % number2;
        if (number1 > number2)
        {
            if (result == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет, " + number1 % number2);
            }

        }
        else
        {
            Console.WriteLine("Числа не подходят");
        }
    }
}