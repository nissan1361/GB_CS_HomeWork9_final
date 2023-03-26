// Задача 64: Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии
Console.Clear();

Console.Write("Введите число N > 1: ");
int num = int.Parse(Console.ReadLine());
GetNatur(num);

static void GetNatur(int n)
{
    if (n == 0)
    {
        return;
    }
    Console.Write(n + " ");
    GetNatur(n - 1);
}