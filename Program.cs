using System;

// Массивы и функции в программировании
// Задача: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число
// Задача: Напишите программу, которая выводит заданную цифру числа или сообщает, что такой цифры нет
// Задача: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// Задача: Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным
// Задача: На вход подаются год, номер месяца и день рождения человека, определить возраст человека
// Задача: Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы
// Определить размер депозита через n месяцев
// Задача: Дано натуральное число, в котором все цифры различны
// Определить, какая цифра расположена в нем левее: максимальная или минимальная
// Задача: Напишите программу, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N
// Задача: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// Задача: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Задача: Напишите программу, на ввод подается номер четверти, создаются N случайных точек в этой четверти
// Определить оптимальный маршрут торгового представителя, который выезжает из центра координат
// Задача: Даны 4 точки A (x1,y1), B (x2,y2), C (x3, y3), D (x4, y4). Проверить пересекаются ли вектора AB и CD.
// Определить в какой честверти лежит точка пересечения векторов

namespace ArraysAndFunctions
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("-----------------------------");
         Console.WriteLine("Таблица кубов чисел от 1 до N");
         Console.WriteLine("-----------------------------");
         Random randomized = new Random();
         int date = randomized.Next(1, 20);
         Console.WriteLine("N = " + date);
         int countcub = 1;
         while (countcub <= date)
         {
            string text = "--------+--------\n";
            text = text + "|  " + countcub + "\t|  " + countcub * countcub * countcub + "\t|";
            Console.WriteLine(text);
            countcub++;
         }

         Console.WriteLine("-----------------------------------------------------------");
         Console.WriteLine("Нахождение расстояния между двумя точками в 3D пространстве");
         Console.WriteLine("-----------------------------------------------------------");
         int aX = randomized.Next(-10, 10);
         int aY = randomized.Next(-10, 10);
         int aZ = randomized.Next(-10, 10);
         int bX = randomized.Next(-10, 10);
         int bY = randomized.Next(-10, 10);
         int bZ = randomized.Next(-10, 10);

         // Формула длины отрезка 3D = SQRT((aX-bX)^2 + (aY-bY)^2 + (aZ-bZ)^2 )
         Console.WriteLine("Точка А -  [" + aX + ", " + aY + ", " + aZ + "]");
         Console.WriteLine("Точка B -  [" + bX + ", " + bY + ", " + bZ + "]");
         Console.WriteLine("Длина отрезка AB в 3D = " + Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY) + (aZ - bZ) * (aZ - bZ)));

         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Проверка пятизначного числа на палиндромность");
         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Вариант с числовым форматом");
         Console.WriteLine("---------------------------");
         Console.WriteLine("Введите данные");
         int figure = Convert.ToInt32(Console.ReadLine());
         // Метод для переворачивания целого числа
         int Inversions(int numeral)
         {
            int i = numeral;
            if (i < 0)
            {
               numeral = -1 * numeral;
            }

            int numeralone = 0;
            while (numeral > 0)
            {
               // Находим остаток - последнюю цифру исходного числа
               int digit = numeral % 10;
               // Удаляем последнюю цифру исходного числа (уменьшаем разрядность)
               numeral /= 10;
               // Формируем новое  второе число (увеличиваем разрядность)
               numeralone *= 10;
               // Добавляем цифру в разряд втрого числа
               numeralone += digit;
            }

            if (i < 0)
            {
               return -1 * numeralone;
            }

            return numeralone;
         }

         int numeraltwo = Inversions(figure);
         if (figure == numeraltwo) Console.WriteLine("Число: " + figure + " - является палиндромом");
         else Console.WriteLine("Число: " + figure + " - не является палиндромом");

         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Проверка пятизначного числа на палиндромность");
         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Вариант 1 с форматом строка");
         Console.WriteLine("---------------------------");
         Console.WriteLine("Введите данные");
         string paragraph = Console.ReadLine();
         // Метод для переворачивания строки
         void InversionsString(string fragment)
         {
            int lines = fragment.Length;
            char[] charone = fragment.ToCharArray();
            char[] chartwo = new char[lines];
            int p = 0;
            int q = lines;
            while (p < lines)
            {
               q -= 1;
               chartwo[q] = charone[p];
               p++;
            }

            int count = 0;
            int t = 0;
            while (t < lines)
            {
               if (chartwo[t] == charone[t])
               {
                  count++;
               }

               t++;
            }

            if (count == lines)
            {
               Console.WriteLine("Запись: " + fragment + " - является палиндромом");
            }
            else
            {
               Console.WriteLine("Запись: " + fragment + " - не является палиндромом");
            }
         }

         InversionsString(paragraph);

         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Проверка пятизначного числа на палиндромность");
         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Вариант 2 с форматом строка");
         Console.WriteLine("---------------------------");
         Console.WriteLine("Введите данные");
         string palindromeone = Console.ReadLine();
         Palindrom(palindromeone);
         void Palindrom(string digits)
         {
            if (digits[0] == digits[4] && digits[1] == digits[3])
            {
               Console.WriteLine($"Число {digits} является полиндромом");
            }
            else
            {
               Console.WriteLine($"Число {digits} не является полиндромом");
            }
         }

         Console.WriteLine("--------------------------------------------------------------------------------------------");
         Console.WriteLine("Определить оптимальный маршрут торгового представителя, который выезжает из центра координат");
         Console.WriteLine("--------------------------------------------------------------------------------------------");
         Console.WriteLine("Введите номер четверти: ");
         int numberChetv = Convert.ToInt32(Console.ReadLine());
         bool selector = true;
         // Расчета мультипликатора для задания точек для определенной четверти
         int xMult = 0; int yMult = 0;
         while (selector)
         {
            if (numberChetv == 1)
            {
               xMult = 1; yMult = 1;
               selector = false;
            }
            else if (numberChetv == 2)
            {
               xMult = -1; yMult = 1;
               selector = false;
            }
            else if (numberChetv == 3)
            {
               xMult = -1; yMult = -1;
               selector = false;
            }
            else if (numberChetv == 4)
            {
               xMult = 1; yMult = -1;
               selector = false;
            }
            else
            {
               Console.WriteLine("Введите правильный номер четверти: ");
               numberChetv = Convert.ToInt32(Console.ReadLine());
            }
         }

         Console.WriteLine("Введите количество точек: ");
         int numberPoint = Convert.ToInt32(Console.ReadLine());
         Random randPoint = new Random();
         // Инициализация массива всех точек по х координате
         int[] arrayX = new int[numberPoint];
         // Инициализация массива всех точек по Y координате
         int[] arrayY = new int[numberPoint];
         // Инициализация массива всех точек по х координате
         int[] arrayXInput = new int[numberPoint];
         // Инициализация массива расстояний от центра до каждой точки
         int[] arrayYInput = new int[numberPoint];
         // Количество элементов массива (точек)
         double[] arrayDistance = new double[numberPoint];
         int distance = arrayX.Length;
         // Метод MethodFillArray для заполнения массива случайными числами заданной четверти
         void MethodFillArray(int[] array, int mult)
         {
            int size = array.Length;
            int record = 0;
            while (record < size)
            {
               array[record] = mult * randPoint.Next(1, 10);
               record++;
            }
         }

         // Заполнение массива координатами Х соответствующей четверти
         MethodFillArray(arrayX, xMult);
         // Заполнение массива координатами Y соответствующей четверти
         MethodFillArray(arrayY, yMult);
         // Массив для вывода первоначальных значений точек
         int rx = 0;
         while (rx < distance)
         {
            arrayXInput[rx] = arrayX[rx];
            arrayYInput[rx] = arrayY[rx];
            rx++;
         }

         // Заполнение массива расстояний от центра до каждой точки
         int register = 0;
         while (register < distance)
         {
            arrayDistance[register] = Math.Sqrt(arrayX[register] * arrayX[register] + arrayY[register] * arrayY[register]);
            register++;
         }

         // Сортировка элементов массива от меньшего значения к большему
         int i = 0;
         while (i < distance)
         {
            int j = 0;
            while (j < distance - 1)
            {
               if (arrayDistance[j] > arrayDistance[j + 1])
               {
                  double tD = arrayDistance[j + 1];
                  int tX = arrayX[j + 1];
                  int tY = arrayY[j + 1];
                  arrayDistance[j + 1] = arrayDistance[j];
                  arrayX[j + 1] = arrayX[j];
                  arrayY[j + 1] = arrayY[j];
                  arrayDistance[j] = tD;
                  arrayX[j] = tX;
                  arrayY[j] = tY;
               }

               j++;
            }

            i++;
         }

         Console.WriteLine("|      Ввод         |     Построение пути         | ");
         Console.WriteLine("|Точка | Координата |   Точка    Расстояние       |"); //

         register = 0;

         while (register < distance)
         {
            string res1 = string.Format("{0:f4}", arrayDistance[register]); // 4 знака
            //string res2 = arrayDistance[register].ToString("F2"); // 2 знака
            //string res3 = arrayDistance[register].ToString("N3"); // 3 знака + разделители
            Console.WriteLine("|   " + register + "  |  [" + arrayXInput[register] + "; " + arrayYInput[register] +
                              "]   " + "|  [" + arrayX[register] + "; " + arrayY[register] + "]" + " = " + res1 + "|");

            //
            //double number2 = 45.08;
            //string result2 = string.Format("{0:f4}", register);
            //Console.WriteLine(result2); // 45,0800
            //string result3 = register.ToString("F2"); // "123.46" (2 знака)
            //string result4 = register.ToString("N3");// "123.456" (3 знака + разделители)
            //

            register++;
         }

         Console.WriteLine("--------------------------------------");
         Console.WriteLine("Определение точки пересечения векторов");
         Console.WriteLine("--------------------------------------");
         Random randomline = new Random();
         double xA = randomline.Next(-10, 10);
         double yA = randomline.Next(-10, 10);
         double xB = randomline.Next(-10, 10);
         double yB = randomline.Next(-10, 10);
         double xC = randomline.Next(-10, 10);
         double yC = randomline.Next(-10, 10);
         double xD = randomline.Next(-10, 10);
         double yD = randomline.Next(-10, 10);

         double ax, ay, bx, by, cx, cy;
         double y = 0, x = 0;
         ax = yA - yB;
         bx = xB - xA;
         cx = xA * yB - xB * yA;
         ay = yC - yD;
         by = xD - xC;
         cy = xC * yD - xD * yC;

         if ((bx * ay - by * ax) != 0)
         {
            y = (cy * ax - cx * ay) / (bx * ay - by * ax);
            x = (-cx - bx * y) / ax;
         }

         // Метод  определения максимального числа из двух
         double MethodMax(double caseone, double casetwo)
         {
            double result = caseone;
            if (casetwo > result)
            {
               result = casetwo;
            }

            return result;
         }

         // Метод определения минимального числа из двух
         double MethodMin(double proofone, double prooftwo)
         {
            double score = proofone;
            if (prooftwo < score)
            {
               score = prooftwo;
            }

            return score;
         }

         Console.WriteLine("AB:  A = [" + xA + ", " + yA + "];  " + "B = [" + xB + ", " + yB + "];  и   CD:  " +
                           "C = [" + xC + ", " + yC + "];  " + "D = [" + xD + ", " + yD + "];  ");
         if (x >= MethodMin(xA, xB) & x <= MethodMax(xA, xB) & y >= MethodMin(yA, yB) & y <= MethodMax(yA, yB))
         {
            Console.WriteLine("Есть точка пересечения:  [x =" + x + ";  y=" + y + "]");
            if (x > 0 & y > 0)
            {
               Console.WriteLine("Точка пересечения в 1 четверти");
            }
            else if (x < 0 & y > 0)
            {
               Console.WriteLine("Точка пересечения во 2 четверти");
            }
            else if (x > 0 & y < 0)
            {
               Console.WriteLine("Точка пересечения в 4 четверти");
            }
         }
         else
         {
            Console.WriteLine("Точки пересечения нет");
         }
         if (bx * ay - by * ax == 0)
         {
            Console.WriteLine("Отрезки параллельны");
         }

         Console.ReadKey();
      }
   }
}

//Console.WriteLine("------------------");
//Console.WriteLine("Перевёрнутое число");
//Console.WriteLine("------------------");
//Console.Write("Введите целое число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//// Метод для переворачивания целого числа
//int Perenert(int numberone)
//{
//   int i = numberone;
//   if (i < 0) numberone = -1 * numberone;
//   int numbertwo = 0;
//   while (numberone > 0)
//   {
//      // Находим остаток - последнюю цифру исходного числа
//      int digit = numberone % 10;
//      // Удаляем последнюю цифру исходного числа (уменьшаем разрядность)
//      numberone /= 10;
//      // Формируем новое  второе число (увеличиваем разрядность)
//      numbertwo *= 10;
//      // Добавляем цифру в разряд втрого числа
//      numbertwo += digit;
//   }
//   if (i < 0) return -1 * numbertwo;
//   return numbertwo;
//}

//Console.WriteLine("Числу: " + number + " соответствует перевернутое число: " + Perenert(number));

//Console.WriteLine("------------------------------");
//Console.WriteLine("Проверка наличия цыфры в числе");
//Console.WriteLine("------------------------------");
//Console.Write("Введите целое число: ");
//int item = Convert.ToInt32(Console.ReadLine());
//if (item == 0)
//{
//   while (item == 0)
//   {
//      Console.Write("Введите целое число отличнное от 0: ");
//      int itemone = Convert.ToInt32(Console.ReadLine());
//      item = itemone;
//   }
//}

//Console.Write("Введите порядковый номер цифры в числе: ");
//int n = Convert.ToInt32(Console.ReadLine());
//// Метод выводит выводит заданную цифру числа или сообщает, что такой цифры нет
//void Fun(int itemone)
//{
//   int numone = Math.Abs(itemone);
//   int digitone = 0;
//   // Расчет количества разрядов в числе
//   while (numone > 0)
//   {
//      numone /= 10;
//      digitone++;
//   }

//   int[] array = new int[digitone];
//   // Метод переворачивает число
//   int numB = Math.Abs(Inversions(itemone));
//   int s = numB;
//   int digittwo = 0;
//   // Число переводится в массив
//   while (numB > 0)
//   {
//      numB /= 10;
//      int numA = s - numB * 10;
//      array[digittwo] = numA;
//      s /= 10;
//      digittwo++;
//   }
//   // Проверка условия наличия цифры в знаке числа
//   if (n < digittwo + 1)
//   {
//      Console.WriteLine("Цифра в числе " + item + " под №" + n + " имеет значениe: " + array[n - 1]);
//   }
//   else
//   {
//      Console.WriteLine("Цифра в числе под №" + n + " отсутствует");
//   }
//}
//Fun(item);

//Console.WriteLine("-------------------");
//Console.WriteLine("Проверка дня недели");
//Console.WriteLine("-------------------");
//Console.Write("Введите порядковый номер дня недели от 1 до 7: ");
//int issue = Convert.ToInt32(Console.ReadLine());
//string ss;
//// Метод определения является день недели ли выходным или нет
//string Weekend(int numberthree)
//{
//   if ((numberthree == 6) | (numberthree == 7))
//   {
//      ss = " - является выходным";
//   }
//   else
//   {
//      ss = " - не является выходным";
//   }
//   return ss;
//}

//string s;

//// Метод определения дня недели по числу
//string Week(int issueone)
//{
//   if (issueone == 1)
//   {
//      s = "Понедельник";
//      return s;
//   }

//   if (issueone == 2)
//   {
//      s = "Вторник";
//      return s;
//   }

//   if (issueone == 3)
//   {
//      s = "Среда";
//      return s;
//   }

//   if (issueone == 4)
//   {
//      s = "Четверг";
//      return s;
//   }

//   if (issueone == 5)
//   {
//      s = "Пятница";
//      return s;
//   }

//   if (issueone == 6)
//   {
//      s = "Суббота";
//      return s;
//   }

//   if (issueone == 7)
//   {
//      s = "Воскресенье";
//      return s;
//   }

//   s = "Ввели неправильное число";
//   return s;
//}

//Console.WriteLine(issue + " - " + Week(issue) + Weekend(issue));

//Console.WriteLine("-----------------------------------------------------------");
//Console.WriteLine("Проверка равнобедренности треугольника со сторонами a, b, c");
//Console.WriteLine("-----------------------------------------------------------");
//Console.Write("Введите сторону a треугольника: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите сторону b треугольника: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите сторону c треугольника: ");
//int c = Convert.ToInt32(Console.ReadLine());

//void Isosceles(int d, int e, int f)
//{
//   if ((d == e) | (d == f) | (e == f))
//   {
//      Console.WriteLine("Треугольник равнобедренный");
//   }
//   else
//   {
//      Console.WriteLine("Треугольник неравнобедренный");
//   }
//}

//Isosceles(a, b, c);

//Console.WriteLine("-----------------------------");
//Console.WriteLine("Определение возраста человека");
//Console.WriteLine("-----------------------------");
//// Метод проверки правильности ввода месяца
//int InputMonth(int month)
//{
//   while (month > 12 | month <= 0)
//   {
//      Console.WriteLine("Введите корректный месяц: ");
//      month = Convert.ToInt32(Console.ReadLine());
//   }

//   return month;
//}

//// Метод проверки правильности ввода дня
//int InputDay(int day)
//{
//   while (day > 31 | day <= 0)
//   {
//      Console.WriteLine("Введите корректную дату: ");
//      day = Convert.ToInt32(Console.ReadLine());
//   }

//   return day;
//}

//Console.Write("Введите дату рождения: ");
//Console.Write("Год: ");
//int yearone = Convert.ToInt32(Console.ReadLine());
//Console.Write("Месяц: ");
//int monthone = Convert.ToInt32(Console.ReadLine());
//monthone = InputMonth(monthone);
//Console.Write("День: ");
//int dayone = Convert.ToInt32(Console.ReadLine());
//dayone = InputDay(dayone);

//Console.Write("Введите текущую дату: ");
//Console.Write("Год: ");
//int yeartwo = Convert.ToInt32(Console.ReadLine());
//Console.Write("Месяц: ");
//int monthtwo = Convert.ToInt32(Console.ReadLine());
//monthtwo = InputMonth(monthtwo);
//Console.Write("День: ");
//int daytwo = Convert.ToInt32(Console.ReadLine());
//daytwo = InputDay(daytwo);

//// Метод расчета возраста
//void InputAge(int yearbirth, int yeartoday, int monthbirth, int monthtoday, int daybirth, int daytoday)
//{
//   int age = 0;
//   if (yeartoday > yearbirth)
//   {
//      if ((monthtoday < monthbirth) & (daytoday < daybirth))
//      {
//         age = yeartoday - yearbirth - 1;
//      }
//      else
//      {
//         age = yeartoday - yearbirth;
//      }
//   }

//   Console.WriteLine("Возраст (количество полных лет) = " + age);
//}

//InputAge(yearone, yeartwo, monthone, monthtwo, dayone, daytwo);

//Console.WriteLine("--------------------------------------------");
//Console.WriteLine("Определение размера депозита через N месяцев");
//Console.WriteLine("--------------------------------------------");
//Console.Write("Введите количество месяцев: ");
//int period = Convert.ToInt32(Console.ReadLine());
//double deposit = 1000;
//// Метод расчета суммы вклада от кол месяцев  с процентом 1,5% ежемесячно
//void DepositPercent(double donation, int time)
//{
//   int first = 1;
//   double money = donation;
//   double percent = 1.5 / 100;
//   while (first <= time)
//   {
//      donation = money * percent + money;
//      money = donation;
//      first += 1;
//   }
//   Console.WriteLine("Процент ежемесячный = " + percent * 100 + "%" + ", количество месяцев по вкладу = " + time);
//   Console.WriteLine("Вклад с учетом процентов = " + Math.Round(donation, 2) + " рублей");
//}

//DepositPercent(deposit, period);

//Console.WriteLine("------------------------------------------------------------------------------------------------");
//Console.WriteLine("Определение расположения максимальной и минимальной цифр в натуральном числе с разными цифрами: ");
//Console.WriteLine("------------------------------------------------------------------------------------------------");
//Console.Write("Введите натуральное число с разными цифрами: ");
//int naturalnumber;
//bool flag = int.TryParse(Console.ReadLine(), out naturalnumber);
//string line = naturalnumber.ToString();
//char[] digits = new char[line.Length];
//int m = 0;
//while (m < digits.Length)
//{
//   digits[m] = line[m];
//   m++;
//}

//if (flag)
//{
//   int maxIndex = 0;
//   int minIndex = 0;
//   for (int i = 1; i < digits.Length; i++)
//   {
//      if (digits[i] > digits[maxIndex])
//      {
//         maxIndex = i;
//      }

//      if (digits[i] < digits[minIndex])
//      {
//         minIndex = i;
//      }
//   }

//   if (maxIndex < minIndex)
//   {
//      Console.WriteLine($"Максимальная цифра {digits[maxIndex]} левее минимальной {digits[minIndex]}");
//   }
//   else if (minIndex < maxIndex)
//   {
//      Console.WriteLine($"Минимальная цифра {digits[minIndex]} левее максимальной {digits[maxIndex]}");
//   }
//}