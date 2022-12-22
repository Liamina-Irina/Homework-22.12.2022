// Задача 19: Напишите программу, которая
// принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.WriteLine("Введите целое пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 10000 && number < 100000)
{
    Console.WriteLine(Palindrome(number) ? "Палиндром" : "Не палиндром");
}
else if(number < 0)
{
Console.WriteLine("Вы ввели ненатуральное число");
}
else Console.WriteLine("Вы ввели непятизначное число");

bool Palindrome(int num)
{
    return num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10;
}


