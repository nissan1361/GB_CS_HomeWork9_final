// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в
// промежутке от M до N
Console.Clear();

Console.Write("Введите число M:");
int numM = int.Parse(Console.ReadLine());

Console.Write("Введите число N:");
int numN = int.Parse(Console.ReadLine());

GetNaturSumm(numM, numN, 0);

static void GetNaturSumm(int m, int n, int summ)
{
    if (m > n)
    {
        Console.WriteLine($"Суммв от M до N = {summ}");
        return;
    }

    summ += m++;
    GetNaturSumm(m, n, summ);
}
