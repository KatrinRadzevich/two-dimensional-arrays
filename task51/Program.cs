// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
int[,] array = new int[3, 4];
array = FillArray(array);
PrintArray(array);
int sum = GetMainDiagonalSum(array);
Console.Write("Сумма элементов главной диагонали: ");
Console.Write($"{array[0, 0]} + {array[1, 1]} + {array[2, 2]} = {sum}");
int[,] FillArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray(int[,] arrayToPrint)
{
    for (int k = 0; k < arrayToPrint.GetLength(0); k++)
    {
        for (int l = 0; l < arrayToPrint.GetLength(1); l++)
        {
            Console.Write($"{arrayToPrint[k, l]} ");
        }
        Console.WriteLine();
    }
}
int GetMainDiagonalSum(int[,] knowingArray)
{
    int sum = 0;
    for (int k = 0; k < knowingArray.GetLength(0); k++)
    {
        for (int l = 0; l < knowingArray.GetLength(1); l++)
        {
            if (k == l)
            {
                sum += knowingArray[k, l];
            }
        }
    }
    return sum;
}