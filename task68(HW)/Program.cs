// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Чтобы увидеть сумму натуральных элементов в промежутке от M до N, введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Также ведите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {A(m, n)}");
int A(int k, int l)
{
    if (k == 0)
        return l + 1;
    else
      if ((k != 0) && (l == 0))
        return A(k - 1, 1);
    else
        return A(k - 1, A(k, l - 1));
}