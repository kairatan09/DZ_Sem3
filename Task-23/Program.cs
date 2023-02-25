// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Welcome(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}


void Cube(int n)
{
  if (n > 0)
  {
    for (int i = 1; i <= n; i++)
    {
      int res = i * i * i;
      Console.Write(res + " ");
    }
  }
  else
    Console.WriteLine("Введенное число не натуральное");
}

try
{
  int number = Welcome("Введите натуральное число: -> ");

  Cube(number);
}
catch
{
  Console.WriteLine("Были введены некорректные данные");
}