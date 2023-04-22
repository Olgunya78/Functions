//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void variant1()    /// вариант считает верно
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
void variant2()    /// вариант с диапазоном отрицательных чисел - считает верно
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
void variant3()   //самый лучший код
{
  Random nam = new Random();
  int a_x = nam.Next(0, 100);
  int a_y = nam.Next(0, 100);
  int a_z = nam.Next(0, 100);
  int b_x = nam.Next(0, 100);
  int b_y = nam.Next(0, 100);
  int b_z = nam.Next(0, 100);
  double reasult = Math.Sqrt(Math.Pow(a_x - b_x, 2) 
                                + Math.Pow(a_x - b_x, 2) 
                                + Math.Pow(a_y - b_y, 2) 
                                + Math.Pow(a_z - b_z, 2));
  Console.WriteLine($"расстояние между точками A и B: {reasult}");
}
void variant4()
{
  int a_x = 1;
  int a_y = 1;
  int a_z = 1;
  int b_x = 0;
  int b_y = 0;
  int b_z = 0;
  double reasult = Math.Sqrt(Math.Pow(a_x - b_x, 2) 
                                + Math.Pow(a_x - b_x, 2) 
                                + Math.Pow(a_y - b_y, 2) 
                                + Math.Pow(a_z - b_z, 2));
  Console.WriteLine(reasult);
}
// variant1();
// variant2();
variant3();
// variant4();