// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());
int[,] array = FillArray(rows, colums, 0, 20);
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