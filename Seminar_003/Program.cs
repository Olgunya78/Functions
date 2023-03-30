// Напишите программу, которая принимает на вход координаты 2-х точек и находит расстояние между ними в 2D пространстве.
// A (3, 6); В (2, 1) -> 5,09
// A (7, -5); В (1, -1) -> 5,09

// sqrt((x2 - x1)^2 + (y2 - y1)^2)

void вариант1()
{
Console.WriteLine("Введите значение точки a: ");
double[] a = new double[2] {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
Console.WriteLine("Введите значение точки b: ");
double[] b = new double[2] {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
double firstOp = Math.Pow((b[0] - a[0]),2) + Math.Pow((b[1] - a[1]),2);
Console.WriteLine(Math.Sqrt(firstOp));
}
void вариант2()
{
Console.WriteLine("Введите значение точки a: ");
double[] a = new double[2] {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
Console.WriteLine("Введите значение точки b: ");
double[] b = new double[2] {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
double firstOp = Math.Pow((b[0] - a[0]),2);
double secondOp = Math.Pow((b[1] - a[1]),2);
Console.WriteLine(Math.Sqrt(firstOp + secondOp));
}
void вариант3()
{
Console.WriteLine("Введите значение точки a: ");
Console.WriteLine("x: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки b: ");
Console.WriteLine("x: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int by = Convert.ToInt32(Console.ReadLine());
int k = bx - ax;
int m = by - ay;
double length = Math.Sqrt(k * k + m * m);
Console.WriteLine(length);
length = Math.Round(length, 2);
Console.WriteLine($"Длина {length}");
}
void вариант4()
{
Random nam = new Random();
int ax = nam.Next(-10, 11);
int ay = nam.Next(-10, 11);
int bx = nam.Next(-10, 11);
int by = nam.Next(-10, 11);
Console.WriteLine($"точки: a({ax}, {ay}), b({bx}, {by})");
Console.WriteLine($"расстояние между точками a и b:{Math.Sqrt(Math.Pow((bx-ax),2) + Math.Pow((by-ay),2))}");
}
void вариант5()    /// вариант считает верно (применена процедура для проверки правильности работы кода)
{
Random nam = new Random();
int x1 = nam.Next(0, 100);
int y1 = nam.Next(0, 100);
int x2 = nam.Next(0, 100);
int y2 = nam.Next(0, 100);
Console.WriteLine($"точка: A({x1}, {y1})");
Console.WriteLine($"точка: B({x2}, {y2})");
Dist(x1, y1, x2, y2);
}
void Dist(int x1, int y1, int x2, int y2)
{
Console.WriteLine($"расстояние между точками A и B:{Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");
}
void вариант6()    /// вариант считает верно (применена функция double)
{
Random nam = new Random();
int x1 = nam.Next(-100, 101);
int y1 = nam.Next(-100, 101);
int x2 = nam.Next(-100, 101);
int y2 = nam.Next(-100, 101);
Console.WriteLine($"точка: A({x1}, {y1})");
Console.WriteLine($"точка: B({x2}, {y2})");
Console.WriteLine($"Расстояние между точками A и B = {Длина(x1, y1, x2, y2)}");
}
double Длина(int x1, int y1, int x2,  int y2)
{
return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

// вариант1();
// вариант2();
// вариант3();
// вариант4();
// вариант5();   
вариант6();   