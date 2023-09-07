int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int firtsDigit = num / 100;
int lastDigit = num % 10;
num = firtsDigit * 10 + lastDigit;
Console.WriteLine(num);
