// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();

Console.Write("Введите координату x: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введите координату y: ");
double y = double.Parse(Console.ReadLine());

string checkquarter(double x, double y)
{
    if (x > 0 || y > 0)
    {
        return ("1 четверть");
    }
    else if(x < 0 || y > 0)
    {
        return ("2 четверть");
    }
    else if(x < 0 || y < 0)
    {
        return ("3 четверть");
    }
    else if(x > 0 || y < 0)
    {
        return ("4 четверть");
    }
    else
    {
        return ("В точке начала координат");
    }
}
Console.Write("Искомая четверть: ");
Console.Write(checkquarter(x, y));
