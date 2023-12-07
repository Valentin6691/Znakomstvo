Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number/100;
int number3 = number % 10;
int result = number1*10 + number3;
Console.WriteLine(result);
