// Задача 52. 
// 1. Задайте двумерный массив из целых чисел. 
// 2. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min,max);
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

void Average (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        double average = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           average += matr [i, j];
        }
        average = average/matr.GetLength(1);
        Console.Write($"{average.ToString(".00")}; ");
    }
}

int[,] matrix = CreateMatrixRndInt(4, 3, 0, 9);
PrinMatrix(matrix);
Console.Write($"Среднее арифметическое каждого столбца: ");
Average(matrix);
