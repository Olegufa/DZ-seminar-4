// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(double ax, double ay, double bx, double by, double cx, double cy)
{
double distence = Math.Sqrt(Math.Pow(bx - ax -cx,2) + Math.Pow(by - ay - cy, 2));
return Math.Round(distence, 2);    
}

Console.Write("Введите координату Х точки А: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х точки C: ");
double Cx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки C: ");
double Cy = Convert.ToDouble(Console.ReadLine());
