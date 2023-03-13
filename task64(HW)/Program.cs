// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Чтобы увидеть все натуральные числа в промежутке от 1 до N, введите число N: ");
int n = int.Parse(Console.ReadLine());
int lastNum = 1;
Console.Write($"N = {n} -> '");
PrintNumsToN(n, lastNum);
Console.Write($"'");
void PrintNumsToN(int value, int one)
{
    Console.Write($"{value}");
    if (value <= one)
        return;
    value--;
    Console.Write($", ");
    PrintNumsToN(value, one);
}