Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number>99 && number<1000)
{int number1 = number/100;
int number3 = number % 10;
int result = number1*10 + number3;
Console.WriteLine(result);
}
else
{
    
    Console.WriteLine("Введите трехначное число");
}
