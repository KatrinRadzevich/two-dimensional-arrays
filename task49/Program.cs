// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.Например, изначально массив
// изначальный массив:          итоговый:
// 1 4 7 2                      1 4 49 2
// 5 9 2 3                      5 9 2 3
// 8 4 2 4                      64 4 4 4
int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
PrintArray(array);
Console.WriteLine();
int[,] result = FillResultArray(array);
PrintArray(result);
int[,] FillResultArray(int[,] anyArray)
{
    for (int i = 0; i < anyArray.GetLength(0); i++)
    {
        for (int j = 0; j < anyArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                anyArray[i, j] *= anyArray[i, j];
            }
        }
    }
    return anyArray;
}
void PrintArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j]} ");
        }
        Console.WriteLine();
    }
}