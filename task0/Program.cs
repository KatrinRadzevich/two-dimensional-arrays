//                           //РЕКУРСИЯ   


//     // Рассчет факториала

// double factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! -> {factorial(i)}");
// }

//      // Рассчет числа фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return fibonacci(n - 1) + fibonacci(n - 2);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) -> {fibonacci(i)}");
}