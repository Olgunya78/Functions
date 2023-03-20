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
// вариант1();
вариант2();