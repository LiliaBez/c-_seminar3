﻿// Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных 
//координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
    Console.WriteLine($"Диапазон возможных координат четверти {number}: x > 0, y > 0");
else if (number == 2)
    Console.WriteLine($"Диапазон возможных координат четверти {number}: x > 0, y < 0");
else if (number == 3)
    Console.WriteLine($"Диапазон возможных координат четверти {number}: x < 0, y < 0");
else if (number == 4)
    Console.WriteLine($"Диапазон возможных координат четверти {number}: x > 0, y < 0");
 else 
    Console.WriteLine("Такой четверти не существует!");  



