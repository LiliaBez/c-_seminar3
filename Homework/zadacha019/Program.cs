// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

//так и не смогла найти самостоятельно, как сделать из
//числа массив не используя разделители((( В общем,
// программа работает, только если ввести число 
// в формате 1 2 3 2 1 (через пробелы)

Console.WriteLine("Введите пятизначное число: ");

string input = Console.ReadLine();
string[] nums = input.Split(' ');
int[] seriesNums = Array.ConvertAll(nums, int.Parse);


if (nums.Length < 5 || nums.Length > 5)
    Console.WriteLine($"Число {input} не пятизначное");
else if (nums[0] == nums[4] && nums[1] == nums[3])
    Console.WriteLine($"Число {input} является палиндромом");
 else 
    Console.WriteLine($"Число {input} не является палиндромом");  

    