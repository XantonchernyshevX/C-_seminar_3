// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
void checknumber(string number)
{
    if(number[0] == number[4] || number[1] == number[3])
    {
        Console.Write("Число является палиндромом");
    }
    else
    {
        Console.Write("Число не является палиндромом");
    }
}
if(number.Length == 5)
{
    checknumber(number);
}
else
{
    Console.Write("Введите пятизначное число");
}