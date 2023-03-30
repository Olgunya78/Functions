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
void вариант3()
{
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{Console.Write($"{Math.Pow((i),2)}, ");}
}
void вариант4()
{
  Console.WriteLine("Введите число: ");
  int nam = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Число\t квадрат");   // слеш \ дает пробел, само \t - это табличный вывод
  for (int i = 1; i <= nam; i++)
  {Console.WriteLine("{0}\t{1}\t", i, Math.Pow((i),2));}   // "{0}\t{1}\t" - " – красивая запись в таблицу
}
void вариант5()
{
  Console.WriteLine("Введите число: ");
  int nam = Convert.ToInt32(Console.ReadLine());
  int i = 1;
  double Sqw;
  while(i <= nam)
{
  Sqw = Math.Pow(i, 2);
  {Console.WriteLine($"|{i}||{Sqw}|");
  i++;
}
}
}
void вариант6()   
{
Random nam = new Random();
int n = nam.Next(1, 20);
string ResultStr = "";
int i = 1;
Console.WriteLine($"Квадраты чисел от 1 до {n}: ");
while(i <= n)
{
  if (ResultStr.Length > 0) ResultStr = ResultStr.Insert(ResultStr.Length, ", ");  // в этой задаче один раз собирается весь ответ и 
  ResultStr = ResultStr.Insert(ResultStr.Length, Convert.ToString(Math.Pow(i, 2)));
  i++;
}
  Console.WriteLine(ResultStr);  // и один раз выводится (тк вывод очень много весит, а так  - оптимально)
}
  void вариант7()
{
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
result(num);
}
void result (int num)
{
  int i = 1;
  if (num > 1)
  {
    while (i <= num)
    {
      Console.WriteLine($"Квадрат числа {i} = {Math.Pow(i, 2)}");
    i++;
    }
  }
    else
  {
    while (i <= 1)
    {
      Console.WriteLine($"Квадрат числа {num} = {Math.Pow(num, 2)}");
      num++;
    }
  }
}
void вариант8()  
{
  int namb = 17;
  int counter = 1;
  while(counter <= namb)
  {
    Console.WriteLine($"{counter} * {counter} = {counter * counter}");
    counter++;
  }
}

// вариант1();
// вариант2();
// вариант3();
// вариант4();
// вариант5();
// вариант6();
// вариант7();
вариант8();

