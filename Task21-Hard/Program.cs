// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

void Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
  double n = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
  Console.WriteLine($"Расстояние составляет {n}");
}

try
{
  Console.WriteLine("Введите 3D координату х1, у1 и z1:");
  int x1 = Convert.ToInt32(Console.ReadLine());
  int y1 = Convert.ToInt32(Console.ReadLine());
  int z1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите 3D координату х2, у2 и z2:");
  int x2 = Convert.ToInt32(Console.ReadLine());
  int y2 = Convert.ToInt32(Console.ReadLine());
  int z2 = Convert.ToInt32(Console.ReadLine());

  Distance3D(x1, y1, z1, x2, y2, z2);
}

catch
{
  Console.WriteLine("Были введены некорректные данные");
}