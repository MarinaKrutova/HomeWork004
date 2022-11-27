/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/



int[] CreateArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
       int number = new Random().Next(1, 100);
        array[i] = number;
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("массив [ ");
   for (int i = 0; i < array.Length; i++)
   {
    Console.Write($"{array[i]} ");
   }
   Console.WriteLine("]");
}
int[] array = CreateArray(8);
PrintArray(array);