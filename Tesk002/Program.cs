/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
int sumsOfDigitsInNumber(int number)
{
    int sumsOfDigitsInNumber = 0;
    while (number > 0)
    {
        sumsOfDigitsInNumber = sumsOfDigitsInNumber + (number % 10);
        number /= 10;
    }
    return sumsOfDigitsInNumber;
}
int userNumber = new int();
Console.Write("Введите число: ");
userNumber = Convert.ToInt32(Console.ReadLine());
int summa = sumsOfDigitsInNumber(userNumber);
Console.WriteLine($"Сумма цифр в числе {userNumber} равно {summa}");
