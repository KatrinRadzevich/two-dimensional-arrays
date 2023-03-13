// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Чтобы увидеть сумму натуральных элементов в промежутке от M до N, введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Также введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"M = {m}; N = {n} -> {RecurseSum(m, n)}");
int RecurseSum(int minNum, int maxNum)
{
    int sum = 0;
    if (maxNum < minNum) return sum;
    else return sum += maxNum + RecurseSum(minNum, maxNum - 1);
}