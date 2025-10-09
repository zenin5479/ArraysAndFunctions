using System;

// Массивы и функции в программировании
// - Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число
// - Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// - Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// - Доп задача: Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным
// - Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года
// - Доп задача:
// - Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев
// - Доп задача: Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная

namespace ArraysAndFunctions
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("---------------------------------------------------------------------------------------");
         Console.WriteLine("Программа, которая принимает на вход целое число и на выходе выводит перевёрнутое число");
         Console.WriteLine("---------------------------------------------------------------------------------------");
         Console.Write("Введите целое число: ");
         int number = Convert.ToInt32(Console.ReadLine());
         // Метод для переворачивания целого числа
         int Perenert(int number1)
         {
            int i = number1;
            if (i < 0) number1 = -1 * number1;
            int number2 = 0;
            while (number1 > 0)
            {
               // Находим остаток - последнюю цифру исходного числа
               int digit = number1 % 10;
               // Удаляем последнюю цифру исходного числа (уменьшаем разрядность)
               number1 /= 10;
               // Формируем новое  второе число (увеличиваем разрядность)
               number2 *= 10;
               // Добавляем цифру в разряд втрого числа
               number2 += digit;
            }
            if (i < 0) return -1 * number2;
            return number2;
         }

         Console.WriteLine("Числу: " + number + " соответствует перевернутое число: " + Perenert(number));

         Console.WriteLine("---------------------------------------------------------------------------------");
         Console.WriteLine("Программа, которая выводит заданную цифру числа или сообщает, что такой цифры нет");
         Console.WriteLine("---------------------------------------------------------------------------------");
         Console.Write("Введите целое число: ");
         int number1 = Convert.ToInt32(Console.ReadLine());
         if (number1 == 0)
         {
            while (number1 == 0)
            {
               Console.Write("Введите целое число отличнное от 0: ");
               int number2 = Convert.ToInt32(Console.ReadLine());
               number1 = number2;
            }
         }

         Console.Write("Введите порядковый номер цифры в числе: ");
         int n = Convert.ToInt32(Console.ReadLine());
         // Метод выводит выводит заданную цифру числа или сообщает, что такой цифры нет
         void Fun(int num)
         {
            int num1 = Math.Abs(num);
            int digit1 = 0;
            // Расчет количества разрядов в числе
            while (num1 > 0)
            {
               num1 /= 10;
               digit1++;
            }

            int[] array = new int[digit1];
            // Метод переворачивает число
            int numB = Math.Abs(Perenert(num));
            int s = numB;
            int digit2 = 0;
            // Число переводится в массив
            while (numB > 0)
            {
               numB /= 10;
               int numA = s - numB * 10;
               array[digit2] = numA;
               s /= 10;
               digit2++;
            }
            // Проверка условия наличия цифры в знаке числа
            if (n < digit2 + 1)
            {
               Console.WriteLine("Цифра в числе " + number1 + " под №" + n + " имеет значениe: " + array[n - 1]);
            }
            else
            {
               Console.WriteLine("Цифра в числе под №" + n + " отсутствует");
            }
         }
         Fun(number1);

         Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
         Console.WriteLine("Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");
         Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
         Console.WriteLine("Введите порядковый номер недели от 1 до 7: ");
         int number3 = Convert.ToInt32(Console.ReadLine());
         string ss;
         // Метод определения является день недели ли выходным или нет
         string HoliDay(int num6)
         {
            if ((num6 == 6) | (num6 == 7))
            {
               ss = " - является выходным";
            }
            else
            {
               ss = " - не является выходным";
            }
            return ss;
         }

         string s;

         // Метод определения дня недели по числу
         string Week(int num5)
         {
            if (num5 == 1)
            {
               s = "Понедельник";
               return s;
            }

            if (num5 == 2)
            {
               s = "Вторник";
               return s;
            }

            if (num5 == 3)
            {
               s = "Среда";
               return s;
            }

            if (num5 == 4)
            {
               s = "Четверг";
               return s;
            }

            if (num5 == 5)
            {
               s = "Пятница";
               return s;
            }

            if (num5 == 6)
            {
               s = "Суббота";
               return s;
            }

            if (num5 == 7)
            {
               s = "Воскресенье";
               return s;
            }

            s = "Ввели неправильное число";
            return s;
         }

         Console.WriteLine(number3 + " - " + Week(number3) + " " + HoliDay(number3));

         // ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ
         Console.WriteLine("------------------------------------------------------------------------------------------");
         Console.WriteLine("Программа, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным");
         Console.WriteLine("------------------------------------------------------------------------------------------");
         int a = Convert.ToInt32(Console.ReadLine());
         int b = Convert.ToInt32(Console.ReadLine());
         int c = Convert.ToInt32(Console.ReadLine());
         
         void IsoscelesYn(int a, int b, int c)
         {
            if ((a == b) | (a == c) | (b == c)) Console.WriteLine("треугольник равнобедренный");
            else Console.WriteLine("треугольник неравнобедренный");
         }
         IsoscelesYn(a, b, c);


         Console.WriteLine(" --------------------------------------------------------------------------------------------------------------------");
         Console.WriteLine(" Иван в январе года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.");
         Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------");
         Console.WriteLine("Введите кол. месяцев");
         int mounth = Convert.ToInt32(Console.ReadLine());
         double vklad = 1000;
         void VkladPercent(double vklad1, int mounth1)                                     // метод расчета суммы вклада от кол месяцев  с процентом 1,5% ежемесячно
         {
            int ind = 1;
            double sum = vklad1;
            double percent = 1.5 / 100;
            while (ind <= mounth1)
            {
               vklad1 = sum * percent + sum;
               sum = vklad1;
               ind = ind + 1;
            }
            Console.WriteLine("Процент ежемесячный =  " + percent * 100 + "%" + ", кол. месяцев по вкладу = " + mounth1);
            Console.WriteLine("Вклад с учетом процентов = " + Math.Round(vklad1, 2) + "руб.");
         }

         VkladPercent(vklad, mounth);
         Console.WriteLine(" --------------------------------------------------------------------------------------------------------------------");
         Console.WriteLine(" На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 февраля 2022 года.");
         Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------");
         int FunMonth(int month3)                              // метод проверки правильности ввода месяца
         {
            while (month3 > 12 | month3 <= 0)
            {
               Console.WriteLine("Введите корректный месяц");
               month3 = Convert.ToInt32(Console.ReadLine());
            }
            return month3;
         }

         int FunDay(int day3)                                  // метод проверки правильности ввода дня
         {
            while (day3 > 31 | day3 <= 0)
            {
               Console.WriteLine("Введите корректную дату");
               day3 = Convert.ToInt32(Console.ReadLine());
            }
            return day3;
         }

         Console.WriteLine("Введите дату рождения");
         Console.WriteLine("год");
         int year1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("месяц");
         int month1 = Convert.ToInt32(Console.ReadLine());
         month1 = FunMonth(month1);
         Console.WriteLine("день");
         int day1 = Convert.ToInt32(Console.ReadLine());
         day1 = FunDay(day1);

         Console.WriteLine("Введите текущую дату");
         Console.WriteLine("год");
         int year2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("месяц");
         int month2 = Convert.ToInt32(Console.ReadLine());
         month2 = FunMonth(month2);
         Console.WriteLine("день");
         int day2 = Convert.ToInt32(Console.ReadLine());
         day2 = FunDay(day2);

         void FunAge(int year_1, int year_2, int month_1, int month_2, int day_1, int day_2)          // метод расчета возраста
         {
            int age = 0;
            if (year_2 > year_1)
               if ((month_2 < month_1) & (day_2 < day_1))
                  age = year_2 - year_1 - 1;
               else
                  age = year_2 - year_1;
            Console.WriteLine("возраст (кол полных лет) = " + age);
         }

         FunAge(year1, year2, month1, month2, day1, day2);
         return;




      }
   }
}