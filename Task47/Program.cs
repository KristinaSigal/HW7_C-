﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int row, int col, int min, int max) 
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)         
        {
            matrix[i, j] = (double)rnd.Next(min, max + 1) + Math.Round(rnd.NextDouble(), 1);
           
        }
    }
    return matrix;
}

void PrinMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 6}, ");
            else Console.Write($"{matrix[i, j], 6}"); 
        }
        Console.WriteLine("]");
    }
}

double[,] matr = CreateMatrixRndInt(3, 4, -99, 99);
PrinMatrix(matr);