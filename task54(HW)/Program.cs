// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());
int[,] array = FillArray(rows, colums, 1, 10);
PrintArray(array);
Console.WriteLine();
SortArrayNums(array);
PrintArray(array);
int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] anyArray)
{
    for (int k = 0; k < anyArray.GetLength(0); k++)
    {
        for (int l = 0; l < anyArray.GetLength(1); l++)
        {
            Console.Write($"{anyArray[k, l]} ");
        }
        Console.WriteLine();
    }
}
void SortArrayNums(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            for (int j1 = j + 1; j1 < someArray.GetLength(1); j1++)
                if (someArray[i, j] < someArray[i, j1])
                {
                    int temp = someArray[i, j];
                    someArray[i, j] = someArray[i, j1];
                    someArray[i, j1] = temp;
                }
        }
    }
}