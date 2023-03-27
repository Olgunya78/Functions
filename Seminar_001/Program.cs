// Напишите программу, которая принимает на вход координаты точки (х и y), 
// причем x ≠ 0  и y ≠ 0 и выдает номер четверти плоскости, в которой находится эта точка.

void variant1()
{
Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());
if ((x > 0) && (y > 0)) {Console.WriteLine("точка пересечения в 1 четверти плоскости");}
else if ((x < 0) && (y > 0)) Console.WriteLine("точка пересечения во 2 четверти плоскости");
else if ((x < 0) && (y < 0)) Console.WriteLine("точка пересечения в 3 четверти плоскости");
else if ((x > 0) && (y < 0)) Console.WriteLine("точка пересечения в 4 четверти плоскости");
else Console.WriteLine("x или y равны 0");
}
void variant2()
{
Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);
Console.WriteLine($"A({x}, {y})");
if ((x > 0) && (y > 0)) {Console.WriteLine("точка пересечения в 1 четверти плоскости");}
else if ((x < 0) && (y > 0)) Console.WriteLine("точка пересечения во 2 четверти плоскости");
else if ((x < 0) && (y < 0)) Console.WriteLine("точка пересечения в 3 четверти плоскости");
else if ((x > 0) && (y < 0)) Console.WriteLine("точка пересечения в 4 четверти плоскости");
else Console.WriteLine("точка лежит на одной из осей x или y и равна 0");
}
void variant3()
{// условие задачи
Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);
Console.WriteLine($"A({x}, {y})");
CoordCheck(x, y);
}
void CoordCheck(int x, int y)
{
if ((x > 0) && (y > 0)) {Console.WriteLine("точка пересечения в 1 четверти плоскости");}
else if ((x < 0) && (y > 0)) Console.WriteLine("точка пересечения во 2 четверти плоскости");
else if ((x < 0) && (y < 0)) Console.WriteLine("точка пересечения в 3 четверти плоскости");
else if ((x > 0) && (y < 0)) Console.WriteLine("точка пересечения в 4 четверти плоскости");
else Console.WriteLine("точка лежит на одной из осей x или y и равна 0");
}

// variant1();
// variant2();
variant3();