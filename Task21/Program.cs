// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 3D
// пространстве.
// A (3,6,8); B (2,1,-7) -> 15,84
// A (7,-5,0); B (1,-1,9) -> 11,53

Console.WriteLine("Введите координаты первой точки:");
int x1 = Convert.ToInt32(System.Console.ReadLine());
int y1 = Convert.ToInt32(System.Console.ReadLine());
int z1 = Convert.ToInt32(System.Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
int x2 = Convert.ToInt32(System.Console.ReadLine());
int y2 = Convert.ToInt32(System.Console.ReadLine());
int z2 = Convert.ToInt32(System.Console.ReadLine());

double res = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками = {Math.Round(res, 2, MidpointRounding.ToZero)}");

double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double pointX = Math.Pow(xc2 - xc1, 2);
    double pointY = Math.Pow(yc2 - yc1, 2);
    double pointZ = Math.Pow(zc2 - zc1, 2);
    double res = Math.Sqrt(pointX + pointY + pointZ);
    return res;
}