/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[4, 4]; 
        int num = 1; 
        int x = 0, y = 0; 
        int dx = 1, dy = 0; 

        while (num <= arr.Length) 
        {
            arr[x, y] = num++; 

            int nx = x + dx;
            int ny = y + dy;

            if (nx < 0  ny < 0  nx >= arr.GetLength(0)  ny >= arr.GetLength(1)  arr[nx, ny] != 0)
            {
                int temp = dx;
                dx = -dy;
                dy = temp;
            }

            x += dx;
            y += dy;
        }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0:D2} ", arr[i, j]); 
            }
            Console.WriteLine(); 
        }

        Console.ReadLine(); 
    }
}