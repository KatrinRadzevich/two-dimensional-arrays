// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7]->по такому индексу нет элемента.
int[,] array = new int[3, 4];
array = GetRandomArray(array);
Console.Write("Чтобы узнать значение выбранного элемента массива,"
   + "необходимо ввести номер строки и столбца.\nВведите номер строки: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int colums = int.Parse(Console.ReadLine());
ShowElement(array, rows, colums);
int[,] GetRandomArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            someArray[i, j] = new Random().Next(1, 10);
            Console.Write($"{someArray[i, j]} ");
        }
        Console.WriteLine();
    }
    return someArray;
}
void ShowElement(int[,] anyArray, int m, int n)
{
    if (m > anyArray.GetLength(0) || n > anyArray.GetLength(1))
    {
        Console.Write($"[{m}, {n}] -> по такому индексу нет элемента.");
    }
    else if (m < anyArray.GetLength(0) || n < anyArray.GetLength(1))
    {
        Console.Write($"[{m}, {n}] -> {anyArray[m, n]}");
    }
}