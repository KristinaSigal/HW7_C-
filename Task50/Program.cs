// Задача 50. Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите значение позиции элемента в массиве (строка)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение позиции элемента в массиве (стобец)");
int b = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrinMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, "); // {matrix[i, j], 4} 4 - форматирование,отступ для выравнивания
            else Console.Write($"{matrix[i, j],4}"); // {matrix[i, j], 4} 4 - форматирование, отступ для выравнивания
        }
        Console.WriteLine("]");
    }
}

void FindElement(int[,] matr, int a1, int b1)
{
    if (a1 <= matr.GetLength(0) && b1 <= matr.GetLength(1) && a1 > 0 && b1 > 0)
    {
        Console.WriteLine($"элемент [{a1}, {b1}] =  {matr[a1 - 1, b1 - 1]} ");
    }
    else
        Console.WriteLine("Элемента с такой позицией в массиве нет");
}
int[,] matrix = CreateMatrixRndInt(4, 4, 0, 9);
PrinMatrix(matrix);
FindElement(matrix, a, b);