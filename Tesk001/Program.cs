/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int getNaturalPowerOfNumber(int numberA, int numberB)
{
    int NaturalPowerOfNumber = numberA;
    for (int i = 1; i < numberB; i++)
    {
        NaturalPowerOfNumber = NaturalPowerOfNumber * numberA;
    }
    return NaturalPowerOfNumber;
}
int getNumberFromUser(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int numberA = getNumberFromUser("Введите натуральное число 1: ");
int numberB = getNumberFromUser("Введите натуральное число 2: ");
if (numberA == 0 && numberB == 0)
{
    Console.WriteLine("Число 0 не является натуральным числом.");
}
else
{
int NaturalPowerOfNumber = getNaturalPowerOfNumber(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} равно  {NaturalPowerOfNumber}");
}