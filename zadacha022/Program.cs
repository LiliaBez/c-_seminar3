// Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    double result = Math.Pow(i, 2);
    Console.WriteLine($"Квадрат {i} = {result}");
}