// Напишите программу, которая принимает на вход число N и выводит таблицу кубов чисел от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void вариант1()  
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter = 1;
  while(counter <= num)
  {
    Console.WriteLine($"{counter} * {counter} * {counter} = {counter * counter * counter}");
    counter++;
  }
}

void вариант2()  
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов:");
for (int i = 1; i <= num; i++)
{
Console.WriteLine($"{i} * {i} * {i} = {i*i*i}");
}
}

void вариант3()  
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
double S;
Console.WriteLine("Таблица кубов:");
for (int i = 1; i <= num; i++)
{
  S = Math.Pow((i),3);
  Console.WriteLine($"|{i}| |{S}|");
}
}

void вариант4()  
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов");
Console.WriteLine("Число \t Куб");
for (int i = 1; i <= num; i++)
{
  Console.WriteLine("{0} \t {1} \t", i, Math.Pow((i),3));
}
}
void вариант5()  // самый лучший вариант
{
  int number = 15;
  for (int i = 1; i <= number; i++)
  {
    Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
  }
}
void вариант6()
{
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
  for (int i = 1; i <= n; i++)
  {
    Console.WriteLine($"{Math.Pow(i, 3)}");
  }
}
// вариант1();
вариант2();
// вариант3();
// вариант4();
// вариант5();
// вариант6();
