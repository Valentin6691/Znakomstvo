Console.WriteLine("Введите число1");
        int number1 = Convert.ToInt32(Console.ReadLine());

        int number2 = number1/100;
        int number3 = number2%10;
        if(number1>99)
        {
           Console.WriteLine(number3); 
        }
        else
        {
            Console.WriteLine("Число имеет меньше трех знаков");
        }
