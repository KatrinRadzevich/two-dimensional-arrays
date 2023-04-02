// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

// !Все закоментированные части существуют для легкой проверки/самопроверки
// и наглядности работы кода. в этом виде в консоли вывод такой же как в примере!

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] rowArray = GetRowArray(array);
Console.WriteLine(String.Join(" ", rowArray));
Console.WriteLine();

int[] firstPartOfRowArray = GetLeftPartOfArray(rowArray);
int[] secondPartOfRowArray = GetRightPartOfArray(rowArray);
int[] firstString = GetLeftPartOfArray(firstPartOfRowArray);
int[] secondString = GetRightPartOfArray(firstPartOfRowArray);
int[] thirdString = GetLeftPartOfArray(secondPartOfRowArray);
int[] fourthString = GetRightPartOfArray(secondPartOfRowArray);

int sum0 = GetSumRow(firstString);
int sum1 = GetSumRow(secondString);
int sum2 = GetSumRow(thirdString);
int sum3 = GetSumRow(fourthString);
GetResult(sum0, sum1, sum2, sum3);
Console.WriteLine($"{String.Join(", ", firstString)}  Сумма строки = {sum0}");
Console.WriteLine($"{String.Join(", ", secondString)} Сумма строки = {sum1}");
Console.WriteLine($"{String.Join(", ", thirdString)} Сумма строки = {sum2}");
Console.WriteLine($"{String.Join(", ", fourthString)} Сумма строки = {sum3}");

void FillArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            someArray[i, j] = new Random().Next(1, 10);
        }
    }
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
int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i, j];
            index++;
        }
    }
    return result;
}
int[] GetLeftPartOfArray(int[] inArray)
{
    int mid = (inArray.Length + 1) / 2;
    int[] someArray = inArray[..mid];
    return someArray;
}
int[] GetRightPartOfArray(int[] inArray)
{
    int mid = (inArray.Length + 1) / 2;
    int[] someArray = inArray[mid..];
    return someArray;
}
int GetSumRow(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
void GetResult(int sum, int sum1, int sum2, int sum3)
{
    int result = 1;
    if (sum1 < sum) result = 2;
    if (sum2 < sum) result = 3;
    if (sum3 < sum) result = 4;
    Console.WriteLine($"Наименьшая строка {result}");
}