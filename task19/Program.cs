//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number < 10000 || number > 99999) {
    Console.WriteLine("Это не пятизначное число, попробуй ещё: ");
    number = int.Parse(Console.ReadLine());
}
//int firstDigit = number/10000;
//int secondDigit = number/1000 % 10;
//int thirdDigit = number/10 % 10;
//int fifthDigit = number % 10;
//if (firstDigit == fifthDigit && secondDigit == thirdDigit) Console.WriteLine("Число является полиндромом");
//else Console.WriteLine("Число не полиндром");
if (number/10000 == number%10 && number/1000 % 10 == number/10 % 10) Console.WriteLine("Число является полиндромом");
else Console.WriteLine("Число не полиндром");