// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y) 
void variant1()
{
Console.WriteLine("Введите номер четверти координат от 1 до 4: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x > 0 и y > 0");}
else if (a == 2) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x < 0 и y > 0");}
else if (a == 3) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x < 0 и y < 0");}
else if (a == 4) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x > 0 и y < 0");}
else {Console.WriteLine("не существует такой четверти координат");}
}
void variant2()
{
Console.WriteLine("Введите номер четверти координат от 1 до 4: ");
int a = Convert.ToInt32(Console.ReadLine());
Check (a);
}
void Check (int a)
{
if (a == 1) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x > 0 (0; +∞) и y > 0 (0; +∞)");}
else if (a == 2) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x < 0 (-∞; 0) и y > 0 (0; +∞)");}
else if (a == 3) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x < 0 (-∞; 0) и y < 0 (-∞; 0)");}
else if (a == 4) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x > 0 (0; +∞) и y < 0 (-∞; 0)");}
else {Console.WriteLine("не существует такой четверти координат");}
}
void variant3()
{
Console.WriteLine("Введите номер четверти координат от 1 до 4: ");
int a = Convert.ToInt32(Console.ReadLine());
zadacha (a);
}
void zadacha (int a)
{
  if (a == 1) 
{
int x = new Random().Next(0, 10);
int y = new Random().Next(0, 10);
Console.WriteLine("число точек в первой четверти соответствует " + (x, y));
}
else if (a == 2) 
{
int x = new Random().Next(0, 10);
int y = new Random().Next(-10, 0);
Console.WriteLine("число точек во второй четверти соответствует " + (x, y));
}
else if (a == 3) 
{
int x = new Random().Next(-10, 0);
int y = new Random().Next(-10, 0);
Console.WriteLine("число точек в третьей четверти соответствует " + (x, y));
}
else if (a == 4) 
{
int x = new Random().Next(-10, 0);
int y = new Random().Next(0, 10);
Console.WriteLine("число точек в червертой четверти соответствует " + (x, y));
}
else {Console.WriteLine("не существует такой четверти координат");}
}
void variant4()
{
Random nam = new Random();
int i = nam.Next(1, 5);
Console.WriteLine($"Задана четверть {i}");
if (i == 1) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x > 0 (0; +∞) и y > 0 (0; +∞)");}
else if (i == 2) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x < 0 (-∞; 0) и y > 0 (0; +∞)");}
else if (i == 3) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x < 0 (-∞; 0) и y < 0 (-∞; 0)");}
else if (i == 4) {Console.WriteLine("диапазон координат точек в этой четверти соответствует: x > 0 (0; +∞) и y < 0 (-∞; 0)");}
else {Console.WriteLine("не существует такой четверти координат");}
}

// variant1();
// variant2();
// variant3();
variant4();