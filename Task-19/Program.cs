// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Welcome(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

bool CheckNumber(int number)
{
  if (number > 9999 && number < 100000)
    return true;
  Console.WriteLine("Введенное число не пятизначное.");
  return false;
}

bool CheckPolindrom(int number)
{
  int chislo1 = number / 10000;
  int chislo5 = number % 10;
  int chislo2 = number / 1000 - chislo1 * 10;
  int chislo4 = (number % 100 - chislo5) / 10;
  if (chislo1 == chislo5 && chislo2 == chislo4)
  {
    Console.WriteLine("Это число является полиндромом.");
    return true;
  }
  Console.WriteLine("Это число не является полиндромом.");
  return false;
}

int number = Welcome("Введите пятизначное число: -> ");
if (CheckNumber(number))
  if (CheckPolindrom(number))
  {

  }