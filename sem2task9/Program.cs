﻿void Variant1()

{
    Console.WriteLine("способ 1");

    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void Variant2()

{
    Console.WriteLine("способ 1");

    System.Random numberGenerator1 = new System.Random();
    int number1 = numberGenerator.Next(10, 100);
    Console.WriteLine(number1);

    Console.WriteLine((number1 / 10 > number1 % 10) ? (int)(number1 / 10) : (int)(number1 % 10));

}

void Variant3()

{
    Console.WriteLine("способ 1");

    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    char[] digitChar = number.ToString().ToCharArray();
    Console.WriteLine(digitChar[0]>digitChar[1]?digitChar[0]:digitChar[1]);

}