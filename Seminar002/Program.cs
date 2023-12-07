internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 99 && number < 1000)
        {
            int number2 = number / 10 % 10;
            int number3 = number % 10;
            int result = 1;
            while (number3 >= 1)
            {
                result = result * number2;
                number3--;
            }
            Console.WriteLine(result);
        }
        else
        {

            Console.WriteLine("Введите трехначное число");
        }
    }
}