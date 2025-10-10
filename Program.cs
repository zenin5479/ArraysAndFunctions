using System;

// Массивы и функции в программировании
// - Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число
// - Задача 13: Напишите программу, которая выводит заданную цифру числа или сообщает, что такой цифры нет
// - Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// - Доп задача: Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным
// - Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на сегодня
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
         int Perenert(int numberone)
         {
            int i = numberone;
            if (i < 0) numberone = -1 * numberone;
            int number2 = 0;
            while (numberone > 0)
            {
               // Находим остаток - последнюю цифру исходного числа
               int digit = numberone % 10;
               // Удаляем последнюю цифру исходного числа (уменьшаем разрядность)
               numberone /= 10;
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
         int item = Convert.ToInt32(Console.ReadLine());
         if (item == 0)
         {
            while (item == 0)
            {
               Console.Write("Введите целое число отличнное от 0: ");
               int number2 = Convert.ToInt32(Console.ReadLine());
               item = number2;
            }
         }

         Console.Write("Введите порядковый номер цифры в числе: ");
         int n = Convert.ToInt32(Console.ReadLine());
         // Метод выводит выводит заданную цифру числа или сообщает, что такой цифры нет
         void Fun(int itemone)
         {
            int numone = Math.Abs(itemone);
            int digitone = 0;
            // Расчет количества разрядов в числе
            while (numone > 0)
            {
               numone /= 10;
               digitone++;
            }

            int[] array = new int[digitone];
            // Метод переворачивает число
            int numB = Math.Abs(Perenert(itemone));
            int s = numB;
            int digittwo = 0;
            // Число переводится в массив
            while (numB > 0)
            {
               numB /= 10;
               int numA = s - numB * 10;
               array[digittwo] = numA;
               s /= 10;
               digittwo++;
            }
            // Проверка условия наличия цифры в знаке числа
            if (n < digittwo + 1)
            {
               Console.WriteLine("Цифра в числе " + item + " под №" + n + " имеет значениe: " + array[n - 1]);
            }
            else
            {
               Console.WriteLine("Цифра в числе под №" + n + " отсутствует");
            }
         }
         Fun(item);

         Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
         Console.WriteLine("Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");
         Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
         Console.Write("Введите порядковый номер недели от 1 до 7: ");
         int issue = Convert.ToInt32(Console.ReadLine());
         string ss;
         // Метод определения является день недели ли выходным или нет
         string Weekend(int numberthree)
         {
            if ((numberthree == 6) | (numberthree == 7))
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
         string Week(int issueone)
         {
            if (issueone == 1)
            {
               s = "Понедельник";
               return s;
            }

            if (issueone == 2)
            {
               s = "Вторник";
               return s;
            }

            if (issueone == 3)
            {
               s = "Среда";
               return s;
            }

            if (issueone == 4)
            {
               s = "Четверг";
               return s;
            }

            if (issueone == 5)
            {
               s = "Пятница";
               return s;
            }

            if (issueone == 6)
            {
               s = "Суббота";
               return s;
            }

            if (issueone == 7)
            {
               s = "Воскресенье";
               return s;
            }

            s = "Ввели неправильное число";
            return s;
         }

         Console.WriteLine(issue + " - " + Week(issue) + Weekend(issue));

         // Дополнительные задачи
         Console.WriteLine("------------------------------------------------------------------------------------------");
         Console.WriteLine("Программа, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным");
         Console.WriteLine("------------------------------------------------------------------------------------------");
         Console.Write("Введите сторону a треугольника: ");
         int a = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите сторону b треугольника: ");
         int b = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите сторону c треугольника: ");
         int c = Convert.ToInt32(Console.ReadLine());

         void Isosceles(int d, int e, int f)
         {
            if ((d == e) | (d == f) | (e == f))
            {
               Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
               Console.WriteLine("Треугольник неравнобедренный");
            }
         }

         Isosceles(a, b, c);

         Console.WriteLine("---------------------------------------------------------");
         Console.WriteLine("Определить возраст человека на сегодня");
         Console.WriteLine("---------------------------------------------------------");
         // Метод проверки правильности ввода месяца
         int InputMonth(int month)
         {
            while (month > 12 | month <= 0)
            {
               Console.WriteLine("Введите корректный месяц: ");
               month = Convert.ToInt32(Console.ReadLine());
            }
            return month;
         }

         // Метод проверки правильности ввода дня
         int InputDay(int day)
         {
            while (day > 31 | day <= 0)
            {
               Console.WriteLine("Введите корректную дату: ");
               day = Convert.ToInt32(Console.ReadLine());
            }
            return day;
         }

         Console.Write("Введите дату рождения: ");
         Console.Write("Год: ");
         int yearone = Convert.ToInt32(Console.ReadLine());
         Console.Write("Месяц: ");
         int monthone = Convert.ToInt32(Console.ReadLine());
         monthone = InputMonth(monthone);
         Console.Write("День: ");
         int dayone = Convert.ToInt32(Console.ReadLine());
         dayone = InputDay(dayone);

         Console.Write("Введите текущую дату: ");
         Console.Write("Год: ");
         int yeartwo = Convert.ToInt32(Console.ReadLine());
         Console.Write("Месяц: ");
         int monthtwo = Convert.ToInt32(Console.ReadLine());
         monthtwo = InputMonth(monthtwo);
         Console.Write("День: ");
         int daytwo = Convert.ToInt32(Console.ReadLine());
         daytwo = InputDay(daytwo);

         // Метод расчета возраста
         void InputAge(int yearbirth, int yeartoday, int monthbirth, int monthtoday, int daybirth, int daytoday)
         {
            int age = 0;
            if (yeartoday > yearbirth)
               if ((monthtoday < monthbirth) & (daytoday < daybirth))
                  age = yeartoday - yearbirth - 1;
               else
                  age = yeartoday - yearbirth;
            Console.WriteLine("Возраст (количество полных лет) = " + age);
         }

         InputAge(yearone, yeartwo, monthone, monthtwo, dayone, daytwo);

         Console.WriteLine("------------------------------------------");
         Console.WriteLine("Определить размер депозита через n месяцев");
         Console.WriteLine(" -----------------------------------------");
         Console.Write("Введите количество месяцев: ");
         int period = Convert.ToInt32(Console.ReadLine());
         double deposit = 1000;
         // Метод расчета суммы вклада от кол месяцев  с процентом 1,5% ежемесячно
         void DepositPercent(double donation, int time)
         {
            int ind = 1;
            double money = donation;
            double percent = 1.5 / 100;
            while (ind <= time)
            {
               donation = money * percent + money;
               money = donation;
               ind += 1;
            }
            Console.WriteLine("Процент ежемесячный = " + percent * 100 + "%" + ", количество месяцев по вкладу = " + time);
            Console.WriteLine("Вклад с учетом процентов = " + Math.Round(donation, 2) + " рублей");
         }

         DepositPercent(deposit, period);

         // Доп задача: Дано натуральное число, в котором все цифры различны
         // Определить, какая цифра расположена в нем левее: максимальная или минимальная

         Console.Write("Введите натуральное число с разными цифрами: ");
         int num = int.Parse(Console.ReadLine());

         string numStr = num.ToString();
         char maxDigit = numStr[0];
         char minDigit = numStr[0];

         // Находим максимальную и минимальную цифры
         foreach (char digit in numStr)
         {
            if (digit > maxDigit) maxDigit = digit;
            if (digit < minDigit) minDigit = digit;
         }

         // Определяем позиции цифр
         int maxIndex = numStr.IndexOf(maxDigit);
         int minIndex = numStr.IndexOf(minDigit);

         // Сравниваем позиции
         if (maxIndex < minIndex)
            Console.WriteLine($"Максимальная цифра {maxDigit} левее минимальной {minDigit}");
         else if (minIndex < maxIndex)
            Console.WriteLine($"Минимальная цифра {minDigit} левее максимальной {maxDigit}");

         Console.ReadKey();
      }
   }
}