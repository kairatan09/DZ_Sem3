// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

// Console.Write("Введите мерность постранства:\t");
// int n = int.Parse(Console.ReadLine());
// int[] koord1 = new int[n];
// int[] koord2 = new int[n];

// Console.WriteLine($"\nВведите {n}-мерную координату точки 1:");
// for (int i = 0; i < koord1.Length; i++)
//   koord1[i] = int.Parse(Console.ReadLine());

// Console.WriteLine($"\nВведите {n}-мерную координату точки 2:");
// for (int i = 0; i < koord1.Length; i++)
//   koord2[i] = int.Parse(Console.ReadLine());

// Console.WriteLine("\nВывод координат точки 1:");
// for (int i = 0; i < koord1.Length; i++)
//   Console.WriteLine(koord1[i]);

// Console.WriteLine("\nВывод координат точки 2:");
// for (int i = 0; i < koord2.Length; i++)
//   Console.WriteLine(koord2[i]);
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//   sum += (koord1[i] - koord2[i]) * (koord1[i] - koord2[i]);
// }

// double distance = Math.Sqrt(sum);

// Console.WriteLine($"\nРасстояние между точками в {n}-мерном пространстве:\t{distance}");

void FillArray(int[] array, int n, int dot)
{
  Console.WriteLine($"\nВведите {n}-мерную координату точки {dot}:");
  for (int i = 0; i < array.Length; i++)
    array[i] = int.Parse(Console.ReadLine());
}


void PrintArray(int[] array, int dot)
{
  Console.WriteLine($"\nВывод координат точки {dot}:");
  for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);
}


void Distance(int[] koord1, int[] koord2, int n)
{
  int sum = 0;
  for (int i = 0; i < n; i++)
  {
    sum += (koord1[i] - koord2[i]) * (koord1[i] - koord2[i]);
  }
  double dis = Math.Sqrt(sum);
  Console.WriteLine($"\nРасстояние между точками в {n}-мерном пространстве:\t{dis}");
}


Console.Write("Введите мерность постранства:\t");
int n = int.Parse(Console.ReadLine());
int[] koord1 = new int[n];
int[] koord2 = new int[n];

FillArray(koord1, n, 1);
FillArray(koord2, n, 2);

PrintArray(koord1, 1);
PrintArray(koord2, 2);

Distance(koord1, koord2, n);