// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой 
//находится эта точка.

Console.WriteLine("Введите X Y:");
string xy = Console.ReadLine ();
string[] parts = xy.Split (' ');
int x = int.Parse (parts[0]);
int y = int.Parse (parts[1]);

if (x > 0 && y > 0)
    Console.WriteLine("1-я четверть");
else if (x < 0 && y > 0)
    Console.WriteLine("2-я четверть");
else if (x < 0 && y < 0)
    Console.WriteLine("3-я четверть");
else if (x > 0 && y < 0)
    Console.WriteLine("4-я четверть");
else 
Console.WriteLine("Не правильная точка! не соответсвует условию задачи");