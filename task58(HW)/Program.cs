// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение
// двух матриц.Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int size = 2;
int[,] array1 = FillArray(size, size, 1, 10);
int[,] array2 = FillArray(size, size, 1, 10);
int[,] arrayResult = GetMultiplicationArray(array1, array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(arrayResult);
int[,] FillArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
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
int[,] GetMultiplicationArray(int[,] inArray, int[,] inArray2)
{
    int[,] array = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = inArray[i, 0] * inArray2[0, j] + inArray[i, 1] * inArray2[1, j];
        }
    }
    return array;
}
