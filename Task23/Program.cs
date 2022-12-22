// Задача 23: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    TableCube(number);
}
else Console.WriteLine("Вы ввели ненатуральное число");

void TableCube(int num)
{
   int count = 1;
   while (count <= num)
   {
        Console.WriteLine($"{count, 6} {Math.Pow(count, 3), 6}");
        count++;
   }
}