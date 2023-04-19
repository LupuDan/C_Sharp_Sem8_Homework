/*
Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

using System;

class Program
{
    static void Main()
    {
        int[,] arr = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int[] temp = new int[arr.GetLength(1)];
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                temp[j] = arr[i, j];
            }

            Array.Sort(temp, (x, y) => -x.CompareTo(y));

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = temp[j];
            }
        }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}