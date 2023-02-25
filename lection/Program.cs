// Лекция двухмерных массивов
//тип переменной[,](показатель двухмерности) название = new тип[ , ]
// string[,] table = new string[2, 5];
// для строк инициализация через константу String.Empty(т е без приданий значений строкам они пустые)
// table[0, 0], table[0, 1], table[0, 2], table[0, 3], table[0, 4]
// table[1, 0], table[1, 1], table[1, 2], table[1, 3], table[1, 4]
// table[1, 2] = "слово"; //обратиться к нужному эллементу: имя[индекс строки, индекс столбца] = "что там будет"
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"{table[rows, colums]}---");
//     }
// }



int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(1, 10);
        }
    }
}