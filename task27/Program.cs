/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int num1)
  {
    int counter = Convert.ToString(num1).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = num1 - num1 % 10;
      result = result + (num1 - advance);
      num1 = num1 / 10;
    }
    return result;
  }

int sumNumber = SumNumber(num1);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
