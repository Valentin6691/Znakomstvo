internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите двузначное число");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 9 && num < 100)
        {
            int num1 = num / 10;
            int num2 = num % 10;
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
        }
        else
        {
            Console.WriteLine("Введенное число не является двузначным");
        }
    }
}