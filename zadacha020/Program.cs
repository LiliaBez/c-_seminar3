// Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между 
//ними в 2D пространстве.

Console.WriteLine("Введите координаты первой точки X Y:");
string firstXY = Console.ReadLine ();
string[] parts1 = firstXY.Split (' ');
int firstX = int.Parse (parts1[0]);
int firstY = int.Parse (parts1[1]);
Console.WriteLine("Введите координаты второй точки X Y:");
string secondXY = Console.ReadLine ();
string[] parts2 = secondXY.Split (' ');
int secondX = int.Parse (parts2[0]);
int secondY = int.Parse (parts2[1]);

double dist = Math.Sqrt (Math.Pow(secondX-firstX, 2) + Math.Pow(secondY-firstY, 2));
Console.WriteLine($"Расстояние между точками равно {dist:F3}");
