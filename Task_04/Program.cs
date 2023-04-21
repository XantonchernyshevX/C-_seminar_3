// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int exponentiation(int n)
{
    int expo = 1;
    for (int i = 1; i <= n; i++)
    {
        Console.Write(" " + Math.Pow(i, 2));
    }
    return expo;
}
Console.Write($"Таблица квадратов чисел от 1 до {n}: ");
exponentiation(n);