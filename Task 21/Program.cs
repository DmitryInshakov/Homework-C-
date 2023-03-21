// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance (int point_xa,int point_ya,int point_za,int point_xb,int point_yb, int point_zb)
{
    double distance_3D = Math.Sqrt(Math.Pow((point_xb-point_xa),2) + Math.Pow((point_yb-point_ya),2) + Math.Pow((point_zb-point_za),2));
    distance_3D = Math.Round(distance_3D,2,MidpointRounding.ToZero);
    return distance_3D;
}


Console.WriteLine("Введите координаты точки А:");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({xa},{ya},{za});B({xb},{yb},{zb}) -> {Distance(xa,ya,za,xb,yb,zb)}");



