// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

Console.Clear();

Console.Write("Координаты точки А по x: ");
double xA = double.Parse(Console.ReadLine());

Console.Write("Координаты точки А по y: ");
double yA = double.Parse(Console.ReadLine());

Console.Write("Координаты точки А по z: ");
double zA = double.Parse(Console.ReadLine());

Console.Write("Координаты точки B по x: ");
double xB = double.Parse(Console.ReadLine());

Console.Write("Координаты точки B по y: ");
double yB = double.Parse(Console.ReadLine());

Console.Write("Координаты точки B по z: ");
double zB = double.Parse(Console.ReadLine());

double distance(double xA, double xB, double yA, double yB, double zA, double zB)
{
    double Distance = Math.Sqrt(Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2));
    return Distance;
}
Console.WriteLine("Расстояние между точками А и В в 3D: "+ distance(xA, xB, yA, yB, zA, zB));


