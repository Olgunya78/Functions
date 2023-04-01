//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними  в 3D пространстве.

void вариант1()    /// вариант считает верно
{
Random nam = new Random();
int x1 = nam.Next(0, 100);
int y1 = nam.Next(0, 100);
int z1 = nam.Next(0, 100);
int x2 = nam.Next(0, 100);
int y2 = nam.Next(0, 100);
int z2 = nam.Next(0, 100);
Console.WriteLine($"точка: A({x1}, {y1}, {z1})");
Console.WriteLine($"точка: B({x2}, {y2}, {z2})");
Dist(x1, y1, x2, y2, z1, z2);
}
void Dist(int x1, int y1, int x2, int y2, int z1, int z2) // тут применена процедура для проверки правильности работы кода
{
Console.WriteLine($"расстояние между точками A и B:{Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))}");
}
void вариант2()    /// вариант с диапазоном отрицательных чисел - считает верно
{
Random nam = new Random();
int x1 = nam.Next(-100, 101);
int y1 = nam.Next(-100, 101);
int z1 = nam.Next(-100, 101);
int x2 = nam.Next(-100, 101);
int y2 = nam.Next(-100, 101);
int z2 = nam.Next(-100, 101);
Console.WriteLine($"точка: A({x1}, {y1}, {z1})");
Console.WriteLine($"точка: B({x2}, {y2}, {z2})");
Длина(x1, y1, x2, y2, z1, z2);
}
void Длина(int x1, int y1, int x2, int y2, int z1, int z2) // тут применена процедура для проверки правильности работы кода
{
Console.WriteLine($"расстояние между точками A и B:{Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))}");
}

// вариант1();
вариант2();