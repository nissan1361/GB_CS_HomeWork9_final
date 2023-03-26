// Задача 68: Напишите программу вычисления функции Аккермана с
// помощью рекурсии. Даны два неотрицательных числа m и n
Console.Clear();

Console.WriteLine("Введите число M:");
int numM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numN = int.Parse(Console.ReadLine());

int result = Akkerman(numM, numN);
Console.WriteLine($"Функция Аккермана для {numM} и {numN} = {result}");

static int Akkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }

    if (numM != 0 && numN == 0)
    {
        return Akkerman(numM - 1, 1);
    }

    if (numM > 0 && numN > 0)
    {
        return Akkerman(numM - 1, Akkerman(numM, numN - 1));
    }
    return Akkerman(numM, numN);
}
