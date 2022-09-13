// ННапишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N..

// то же почти 1в1 с семинаром... Не знаю, можно ли
// как-то написать в кубе символом - ³.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    double result = Math.Pow(i, 3);
    Console.WriteLine($"Число {i} в кубе = {result}");
}
