// Напишите программу, которая принимает на вход координаты точки (х и y), 
// причем x ≠ 0  и y ≠ 0 и выдает номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());
if ((x > 0) && (y > 0)) {Console.WriteLine("точка пересечения в 1 четверти плоскости");}
else if ((x < 0) && (y > 0)) Console.WriteLine("точка пересечения во 2 четверти плоскости");
else if ((x < 0) && (y < 0)) Console.WriteLine("точка пересечения в 3 четверти плоскости");
else if ((x > 0) && (y < 0)) Console.WriteLine("точка пересечения в 4 четверти плоскости");
else Console.WriteLine("x или y равны 0");