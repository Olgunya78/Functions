// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

void вариант1()
{
Console.WriteLine("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
double i = 1;
while (i <= n)
{
  Console.Write($"{Math.Pow((i),2)}, ");
  i++;
}
}
void вариант2()
{
Console.WriteLine("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
double i = 1;
while (i <= n)
{
  if (i != n) Console.Write($"{Math.Pow((i),2)}, ");
  else Console.Write($"{Math.Pow((i),2)}.");
  i++;
}
}
// вариант1();
вариант2();