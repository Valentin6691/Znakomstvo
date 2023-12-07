internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите абсциссу");
        int abs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ординату");
        int ord = Convert.ToInt32(Console.ReadLine());
        if (abs == 0 && ord == 0)
        {
            Console.WriteLine("Одна или две координаты равны 0");
        }
            else if (abs > 0 && ord > 0)
            {
                Console.WriteLine("1");
            }
            else if (abs < 0 && ord > 0)
            {
                Console.WriteLine("2");
            }
            else if (abs < 0 && ord < 0)
            {
                Console.WriteLine("3");
            }
            else if (abs > 0 && ord < 0)
            {
                Console.WriteLine("4");
            }
    }
}