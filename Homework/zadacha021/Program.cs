// Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние 
//между ними в 3D пространстве.

Console.WriteLine("Введите через пробел координаты первой точки X Y Z:");
string firstXY = Console.ReadLine ();
string[] parts1 = firstXY.Split (' ');
int firstX = int.Parse (parts1[0]);
int firstY = int.Parse (parts1[1]);
int firstZ = int.Parse (parts1[2]);


Console.WriteLine("Введите через пробел координаты второй точки X Y Z:");
string secondXY = Console.ReadLine ();
string[] parts2 = secondXY.Split (' ');
int secondX = int.Parse (parts2[0]);
int secondY = int.Parse (parts2[1]);
int secondZ = int.Parse (parts2[2]);


double dist = Math.Sqrt (Math.Pow(secondX-firstX, 2) + Math.Pow(secondY-firstY, 2) + Math.Pow(secondZ-firstZ, 2));
Console.WriteLine($"Расстояние между данными точками равно {dist:F3}");