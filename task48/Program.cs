// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
int[,] FillArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = i + j;
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