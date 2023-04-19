/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System;

class Program
{
    static void Main()
    {
        int[,] arr = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int minSumRow = 0;
        int minSum = int.MaxValue;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                rowSum += arr[i, j];
            }
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRow = i;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRow + 1));
    }
}