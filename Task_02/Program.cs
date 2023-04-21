// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y)

Console.Clear();

System.Console.Write("Номер четверти: ");
int n = int.Parse(Console.ReadLine());

string checkcoordinate(int n)
{
    if (n == 1)
    {
        return ("x > 0, y > 0");
    }
    else if(n == 2)
    {
        return ("x < 0, y > 0");
    }
    else if(n == 3)
    {
        return ("x < 0, y < 0");
    }
    else if(n == 4)
    {
        return ("x > 0, y < 0");
    }
    else
    {
        return ("Число четвертей не может быть больше 4");
    }
}
Console.Write("Возможные координаты: ");
Console.Write(checkcoordinate(n));