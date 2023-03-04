// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// !Тут вопрос! Тут никак не могу добится вывода чисел и с запятой,и без
//  Подскажите пожалуйста,как это сделать

int[,] array = new int[3, 4];
array = GetRandomArray(array);
Console.Write("Среднее арифметическое каждого столбца: "
+ "{0:F1}", +averageNumOfColum(array, 0));
Console.Write(", {0:F1}", +averageNumOfColum(array, 1));
Console.Write(", {0:F1}", +averageNumOfColum(array, 2));
Console.Write(", {0:F1}", +averageNumOfColum(array, 3));
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
double averageNumOfColum(int[,] anyArray, int colums)
{
    double sum = 0;
    double averageNum = 0;
    for (int rows = 0; rows < anyArray.GetLength(0); rows++)
    {
        sum += anyArray[rows, colums];
        averageNum = (sum / anyArray.GetLength(0));
    }
    return averageNum;
}
