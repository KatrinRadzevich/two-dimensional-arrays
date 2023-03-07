// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] a = new double[3, 4];
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = Math.Round(random.NextDouble() * 2 + random.Next(-9, 10), 1);
        a[1, 2] = 3; a[0, 1] = -1;//эта строчка исключительно для наглядности результата вывода
        Console.Write("{0,9:D/f1}", +a[i, j] + " ");
    }
    Console.WriteLine();
}
