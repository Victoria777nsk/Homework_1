// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int N2 = 2;

if (N > 1)
{
    while (N2 <= N)
    {
    Console.Write(N2 + ", ");
    N2 += 2;
    }
}
else
{
    Console.WriteLine("Ошибка! Число должно быть > 1 !");
}
