/*
 * Основы программы
 */

// using System;
// Пространство имён группирует типы и защищает от конфликтов имён.
// namespace MyApp
// {
//  class Program { }
// }

// короткая форма (C# 10+), действует на весь файл
// namespace MyApp;
//
// class Program { }
// Полное имя класса: MyApp.Program.
// Метод Main
// Точка входа: с него начинается выполнение программы.

// using System;
//
// namespace MyApp
// {
//  class Program
//  {
//   static void Main(string[] args)
//   {
//    Console.WriteLine("Привет");
//   }
//  }
// }

/*
 * Вывод в консоли первый
 */

// Console.WriteLine("Я начинаю изучать C#");
// Console.WriteLine("Это мой первый урок");
// Console.WriteLine("Мне интересно");

/*
 * Типы данных int и string также вывод вкнутри принта данных $
 */

// int age = 18;
// string name = "Вира";
//
// Console.WriteLine($"Меня зовут {name}");
// Console.WriteLine($"Мне {age} лет");


/*
 * Операторы, сложения, вычетания, умножения, процента, деления, прибавления
 */

// int a = 15;
// int b = 4;
//
// double num = (double)a / b;
//
// Console.WriteLine($"Сложение {a + b}");
// Console.WriteLine($"Деление {num}");
// Console.WriteLine($"Процент {a % b}");
// Console.WriteLine($"Умножение {a * b}");
// Console.WriteLine($"Минус {a - b}");

/*Ввод типа данных float и переобразование из string на float */

// Console.WriteLine("Enter your name:\t");
// string name = Console.ReadLine();
// float age = float.Parse(Console.ReadLine());
// Console.WriteLine($"Hello, {name}!\nThis your age {age}");

/*
 * Условные опеаторы if else 
 */

// Console.WriteLine("Hi enter number:\n");
// string input = Console.ReadLine();
//
// if (int.TryParse(input, out int number))
// {
//     Console.WriteLine($"Your number is int: {number}");
// }
// else if (float.TryParse(input, out float number2))
// {
//     Console.WriteLine($"Your number is float: {number2}");
// }
// else if (double.TryParse(input, out double number3))
// {
//     Console.WriteLine($"Your number is double: {number3}");
// }
// else
// {
//     Console.WriteLine("This is string");
// }



/*
 * Декмаил число 
 */

// var name = "Bob";
// var message = 3;
// var temperature = 34.40;
//
// Console.WriteLine(34.40m);
// Console.Write($"Hello, {name}! You have {message} messages in your inbox. The temperature is {temperature} celsius.");

/*
 * Вывод с принтом знаком.
 */

// Console.WriteLine("Hello \"World\"!");
// Console.WriteLine("c://source//repos");

// Console.WriteLine(@"    c:\source\repos    
//         (this is where your code goes)");
// Console.Write(@"c:\invoices");

// Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.Write("\nOutput Directory:\t");
// Console.Write(@"c:\invoices");
//
// Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// Console.WriteLine(@"c:\invoices\app.exe -j");

/*Пример деления умножения и прибавления в переменной одной и далее вывод  в консоли*/

// int result = 3 + 1 * 5 / 2;
// Console.WriteLine(result);

/*
 * Добавления значений без использования числа
 */

// int value = 1;
//
// value = value + 1;
// Console.WriteLine("First increment: " + value);
//
// value += 1;
// Console.WriteLine("Second increment: " + value);
//
//
//Так работает конкатенация строк со значением int, и это правильный способ вывода, но в следующих примерах удобнее использовать
// value++;
// Console.WriteLine("Third increment: " + value);
// Console.WriteLine($"First increment: {value}")
//
// value = value - 1;
// Console.WriteLine("First decrement: " + value);
//
// value -= 1;
// Console.WriteLine("Second decrement: " + value);
//
// value--;
// Console.WriteLine("Third decrement: " + value);

/*
 * Вывод и добавление без использования прмо внутри Console.WriteLine 
 */

// int value = 1;
// value++;
// Console.WriteLine("First: " + value);
// Console.WriteLine($"Second: {value++}");
// Console.WriteLine("Third: " + value);
// Console.WriteLine("Fourth: " + (++value));

/*
 * умножение в переменной и в Console.WriteLine
 */

// int fahrenheit = 94;
// float numb = 5f / 9f;
// int celsius = 32 ;
// float min = fahrenheit - celsius;
//
// Console.WriteLine($"The temperature is {min * numb} Celsius" );

/*
 * Деление внутри вывода на консоль
 */

// Console.WriteLine(5 / 10);

/*
 *  Пример использования всех изученных данных
 */

// initialize variables - graded assignments 
//
// int currentAssignments = 5;
//
// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;
//
// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;
//
// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;
//
// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;
//
// int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
// int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
// int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
//
// decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
// decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
// decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
// decimal jeongScore = (decimal) jeongSum / currentAssignments;
//
// Console.WriteLine("Sophia: " + sophiaScore + " A");
// Console.WriteLine("Nicolas: " + nicolasScore + " B");
// Console.WriteLine("Zahirah: " + zahirahScore + " B");
// Console.WriteLine("Jeong: " + jeongScore + " A");
// decimal sophiaScore;
// decimal nicolasScore;
// decimal zahirahScore;
// decimal jeongScore;
// decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
// decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
// decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
// decimal jeongScore = (decimal) jeongSum / currentAssignments;
//
// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
// Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
// Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
// Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

// var value = (int) dividend / (int) divisor;
// Console.WriteLine(value);
// string studentName = "Sophia Johnson";
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";
//
// int course1Credit = 3;
// int course2Credit = 3;
// int course3Credit = 4;
// int course4Credit = 4;
// int course5Credit = 3;
//
// int gradeA = 4;
// int gradeB = 3;
//
// int course1Grade = gradeA;
// int course2Grade = gradeB;
// int course3Grade = gradeB;
// int course4Grade = gradeB;
// int course5Grade = gradeA;
//
// int totalCreditHours = 0;
// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;
//
// int totalGradePoints = 0;
// totalGradePoints += course1Credit * course1Grade;
// totalGradePoints += course2Credit * course2Grade;
// totalGradePoints += course3Credit * course3Grade;
// totalGradePoints += course4Credit * course4Grade;
// totalGradePoints += course5Credit * course5Grade;
//
// decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;
//
// int leadingDigit = (int) gradePointAverage;
// int firstDigit = (int) (gradePointAverage * 10 ) % 10;
// int secondDigit = (int) (gradePointAverage * 100 ) % 10;
//
// Console.WriteLine($"Student: {studentName}\n");
// Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
//
// Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
// Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
// Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
// Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
// Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
//
// Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");

/*
 * Рандомные число вывод и значения
 */

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

/*
 * максимальное значнение рандом и назначение одним числом максимального значения о одного значения ко до 2
 */

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);
//
// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

/*
 * использование дополнение Math и значения Max для большого количества переменных 
 */

// int d, a, v, b, c;
// d = 1;
// a = 10;
// v = 20;
// b = 42;
// c = -10;
//
// var max = Math.Max(Math.Max(Math.Max(Math.Max(d, a), v), b), c);

/*
 * for цикл
 */

// for (int i = 0; i < 3; i++)
// {
//  Console.WriteLine(i);
// }

/*
 * for цикл 
 */
// 1 часть
// Число от 1 до 10 
// for (int i = 1; i <= 10; i++)
// {
//  Console.WriteLine(i);
// }
//
// От 10 до 1
// for (int i = 10; i >= 1; i--)
// {
//  Console.WriteLine(i);
// }
// 
// от 1. до 10. привет!
// for (int i = 1; i <= 10; i++)
// {
//  Console.WriteLine($"{i}. Привет!");
// }
//
// 2 часть
// От 1 до 20 четные числа 
// for (int i = 0; i <= 20; i += 2)
// {
//  Console.WriteLine(i);
// }
//
//
// for (int i = 1; i <= 15; i++)
// {
//  if (i % 3 != 0)
//  {
//   Console.WriteLine(i);
//  }
// }

/*
 * switch - конструкция похожая на if Конструкция switch/case оценивает некоторое выражение и сравнивает его значение с набором значений.
 * И при совпадении значений выполняет определенный код.
 */ 

// switch (выражение)
// {
//  case значение1:
//  код,выполняемый если выражение имеет значение1
//  break;
//  case значение2:
//  код,выполняемый если выражение имеет значение2
//  break;
//  //.............
//  case значениеN:
//  код, выполняемый если выражение имеет значениеN
//  break;
//  default:
//  код, выполняемый если выражение не имеет ни одно из выше указанных значений
//  break;
// }

/*
 * While цикл 
 */

// class App
// {
//  public static void PrintNumbers(int lastNumber)
//  {
//   // i сокращение от index (порядковый номер)
//   // используется по общему соглашению во множестве языков
//   // как счетчик цикла
//   var i = 1;
//
//   while (i <= lastNumber)
//   {
//    Console.WriteLine(i);
//    i = i + 1;
//   }
//
//   Console.WriteLine("finished!");
//  }
// }
//
// App.PrintNumbers(3);

/*
 * array - массивы  аррай хранит данные
 * https://metanit.com/sharp/tutorial/3.45.php
 */

/*
*Обявление массива 
*/

// int [] integerArray; // числовой массив 
// string [] stringArray; // строковый массив
// bool [] booleanArray; // логический массив

/*
 * Примеры хранения данных в масиве
 */

// int[] luckyNumbers = {3, 4, 144, 135, 105, 21};
//
// string[] friends = new string[3];
// friends[0] = "giem";
// friends[1] = "neuwqf";
//
// luckyNumbers[1] = 400;
//
// Console.WriteLine(luckyNumbers[1]);

/*
 * Обозначение данных в массиве
 */

// int[] arrNumbers = new int[5];
//
// // заполняем массив
// arrNumbers[0] = 1;
// arrNumbers[1] = 5;
// arrNumbers[2] = 7;
// arrNumbers[3] = 10;
// arrNumbers[4] = 25;
//
// // показываем массив на экране
// for (int i = 0; i < arrNumbers.Length; i++)
// {
//  int number = arrNumbers[i];
//  Console.WriteLine(number);
//  Console.WriteLine(arrNumbers[4])
// }

/*
 * массив с разными типом данных
 */

// class Program
// {
//  static void Main()
//  {
//   int[] scores = new int[4];                     // 4 elements, all 0
//   string[] names = { "Ana", "Ben", "Chloe" };     // initializer
//   double[] prices = new double[] { 2.5, 9.99 };   // explicit form
//   var days = new[] { "Mon", "Tue", "Wed" };       // type inferred: string[]
//
//   scores[0] = 90;
//   scores[3] = 72;
//
//   Console.WriteLine(string.Join(", ", scores));
//   Console.WriteLine(names[1]);
//   Console.WriteLine(prices.Length + " prices, " + days.Length + " days");
//  }
// }

// object[] arr1 = {"aaa", 5, 7, 8.6, "eeee"};

/*
 * Array длина массива
 */

// int[] numbers = {1,2,3,4};
// Console.WriteLine(numbers.Length);

/*
 * Перебор массивов 
 */

// int[] numbers = { 1, 2, 3, 4, 5 };
// foreach (int i in numbers)
// {
//  Console.WriteLine(i);
// }

/*
* Многомерные массивы
* Массивы характеризуются таким понятием как ранг или количество измерений. Выше мы рассматривали массивы, которые имеют одно измерение (то есть их ранг равен 1) - такие массивы можно представлять в виде ряда (строки или столбца) элемента. Но массивы также бывают многомерными. У таких массивов количество измерений (то есть ранг) больше 
* 1.Массивы которые имеют два измерения (ранг равен 2) называют двухмерными. Например, создадим одномерный и двухмерный массивы, которые имеют одинаковые элементы:
*/

// int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };
//  
// int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

/*
 * Массив массивов
 * От многомерных массивов надо отличать массив массивов или так называемый "зубчатый массив"
 */

// int[][] nums = new int[3][];
// nums[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
// nums[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
// nums[2] = new int[5] { 1, 2, 3, 4, 5 }; // выделяем память для третьего подмассива

/*
 * Ступенчатые (зубчатые) массивы - Двумерный массив можно представить в виде таблицы,
 * в которой длина каждой строки остается неизменной по всему массиву.
 * Но в C# можно также создавать специальный тип двумерного массива, называемый ступенчатым массивом. Ступенчатый массив представляет собой массив массивов,
 * в котором длина каждого массива может быть разной. Следовательно,
 * ступенчатый массив может быть использован для составления таблицы из строк разной длины.
 */

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
//
// namespace ConsoleApplication1
// {
//  class Program
//  {
//   static void Main(string[] args)
//   {
//    int i = 0;
//    // Объявляем ступенчатый массив
//    int[][] myArr = new int[4][];
//    myArr[0] = new int[4];
//    myArr[1] = new int[6];
//    myArr[2] = new int[3];
//    myArr[3] = new int[4];
//
//    // Инициализируем ступенчатый массив
//    for (; i < 4; i++)
//    {
//     myArr[0][i] = i;
//     Console.Write("{0}\t",myArr[0][i]);
//    }
//
//    Console.WriteLine();
//    for (i = 0; i < 6; i++)
//    {
//     myArr[1][i] = i;
//     Console.Write("{0}\t", myArr[1][i]);
//    }
//
//    Console.WriteLine();
//    for (i = 0; i < 3; i++)
//    {
//     myArr[2][i] = i;
//     Console.Write("{0}\t", myArr[2][i]);
//    }
//
//    Console.WriteLine();
//    for (i = 0; i < 4; i++)
//    {
//     myArr[3][i] = i;
//     Console.Write("{0}\t", myArr[3][i]);
//    }
//
//    Console.ReadLine();
//   }
//  }
// }

/*
 * Array class -  Sort, Reverse, IndexOf, Copy, Clear, Resize
 * Класс Array в C# принадлежит к пространству имён System и предоставляет встроенные свойства и методы для работы с массивами.  Он поддерживает стандартные операции, такие как сортировка, поиск, копирование, обращение и получение информации об элементах массива. 
 * Класс Array является базовым для всех типов массивов в C#. 
 * Он предоставляет такие свойства, как Length, LongLength и Rank, для получения информации об массиве. 
 * Он включает в себя такие методы, как Sort(), Reverse(), Copy() и BinarySearch(), для выполнения операций с массивами.
 */

/*
 * Array Lenght , Rank Property
 */

// using System;
// class Program
// {
//  static void Main()
//  {
//   int[] numbers = { 10, 20, 30, 40, 50, 60 };
//   Console.WriteLine("Length of the array: " + numbers.Length);
//   Console.WriteLine("Rank of the array: " + numbers.Rank);
//  }
// }

/*
 * Reverse, Sort
 */

// using System;
// class Program
// {
//  static void Main()
//  {
//   int[] numbers = { 10, 20, 30, 40, 50, 60 };
//
//   Console.WriteLine("Array before reversing:");
//   foreach (int number in numbers)
//   {
//    Console.Write(number + " ");
//   }
//
//   Array.Reverse(numbers);
//
//   Console.WriteLine("\nArray after reversing:");
//   foreach (int number in numbers)
//   {
//    Console.Write(number + " ");
//   }
//
//  Array.Sort(numbers);
//
//  Console.WriteLine("\nArray after sorting:");
//  foreach (int number in numbers)
//  {
//  Console.Write(number + " ");
//  }
//  }
// }

/*
 * Метод — это блок кода, содержащий ряд инструкций. Программа инициирует выполнение инструкций, вызывая метод и указывая все аргументы,
 * необходимые для этого метода.
 * В C# все инструкции выполняются в контексте метода.
 * Метод Main является точкой входа для каждого приложения C# и вызывается средой CLR при запуске программы.
 * В приложении, использующего инструкции верхнего уровня,
 * Main метод создается компилятором и содержит все инструкции верхнего уровня.
 */

/*
 * Сигнатуры методов
 * Методы объявляются в классе, структуре или интерфейсе путем указания уровня доступа,
 * например или необязательных модификаторов,
 * таких как publicprivate или abstractsealedвозвращаемое значение,
 * имя метода и любые параметры метода. Эти части вместе являются сигнатурой метода.
 */
 
// abstract class Motorcycle
// {
//  // Вызвать этот метод может кто угодно.
//  public void StartEngine() {/* Операторы метода */ }
//
//  // Вызвать этот метод могут только производные классы.
//  protected void AddGas(int gallons) { /* Операторы метода */ }
//
// // Производные классы могут переопределять реализацию базового класса.
// public virtual int Drive(int miles, int speed) { /* Операторы метода */ return 1; }
//
// // Производные классы должны реализовать этот метод.
// public abstract double GetTopSpeed();
// }

/* Используйте void в качестве типа возвращаемого значения метода или локальной функции, чтобы указать, что метод не возвращает значение.
 * Справочник по языку C# содержит документацию по последней выпущенной версии языка C#.
 * В нем также представлена начальная документация по функциям, доступным в публичных предварительных версиях для предстоящего выпуска языка.
 * В документации указаны все функции, впервые появившиеся в трех последних версиях языка или в текущих публичных предварительных версиях.
 * Вы также можете использовать void в качестве ссылочного типа для объявления указателя на неизвестный тип.
 * Дополнительные сведения см. в разделе Типы указателей.
 * Вы не можете использовать void в качестве типа переменной.
 */

// public static void Display(IEnumerable<int> numbers)
// {
//  if (numbers is null)
//  {
//   return;
//  }
//
//  Console.WriteLine(string.Join(" ", numbers));
// }

/*
 * Область видимости: переменная живёт внутри {}, где объявлена
 */

// int a = 1;
// {
//     int b = 2;
//     Console.WriteLine(a + b);   // a и b видны
// }
// Console.WriteLine(a);           // ок
// Console.WriteLine(b);           // ошибка: b живёт только в блоке выше

/*
 * Переменная цикла живёт только в цикле
 */

// for (int i = 0; i < 3; i++)
// {
//     int sq = i * i;             // создаётся заново на каждой итерации
// }
// Console.WriteLine(i);           // ошибка
// Console.WriteLine(sq);          // ошибка

/*
 * Параметры и локальные переменные живут только внутри метода
 */

// int Add(int x, int y)           // x, y: параметры
// {
//     int sum = x + y;            // sum: локальная
//     return sum;
// }
// Console.WriteLine(sum);         // ошибка: sum существует только в Add

/*
 * Затенение: в C# локальную переменную с тем же именем
 * во вложенном блоке объявлять НЕЛЬЗЯ
 */

// int count = 0;
// if (true)
// {
//     int count = 5;              // ошибка CS0136
// }

// Но для полей класса можно: параметр или локальная закрывает поле, поле достаётся через this
// class Player
// {
//     int score = 10;             // поле
//
//     void Show(int score)        // параметр с тем же именем закрывает поле
//     {
//         Console.WriteLine(score);        // параметр
//         Console.WriteLine(this.score);   // поле
//     }
// }

/*
 * out-переменные
 */

// if (int.TryParse("5", out int n))
// {
//     Console.WriteLine(n);       // видна только в этом if
// }
// Console.WriteLine(n);           // ошибка

// int.TryParse("5", out int m);   // отдельной строкой: m видна дальше в блоке
// Console.WriteLine(m);           // ок

/*
 * Top-level код: переменные верхнего уровня видны в локальных функциях
 * (поэтому ru и en работали внутри ChooseLanguage), но не в классах
 */

// int total = 0;
//
// void AddToTotal(int x) => total += x;   // видит total
//
// AddToTotal(5);
// Console.WriteLine(total);               // 5
//
// class Helper
// {
//     void Test() { total++; }            // ошибка: класс не видит total
// }

/*
 * Поля и static (кратко, подробнее в ООП)
 * Поле: переменная внутри класса, а не метода. Живёт, пока жив объект.
 * static: одна общая копия на весь класс, живёт всю программу.
 */

// class Counter
// {
//     int own = 0;                 // у каждого объекта своё
//     static int shared = 0;       // одно на всех
//
//     public void Hit()
//     {
//         own++;
//         shared++;
//     }
//
//     public static void Show() => Console.WriteLine(shared);
// }
//
// var c1 = new Counter();
// var c2 = new Counter();
// c1.Hit();
// c2.Hit();                        // own у каждого = 1, shared = 2
// Counter.Show();                  // 2 (static вызывается через имя класса)

/*
 * Время жизни
 * локальная переменная / параметр: от объявления до конца блока или метода
 * поле: пока существует объект
 * static-поле: пока работает программа
 */
 

/*
 * Инструкция try-catch-finally
 * try-catch-finally Используйте инструкцию как для обработки исключений,
 * которые могут возникать во время выполнения try блока, так и для указания кода,
 * который должен выполняться при выходе try элемента управления из оператора:
*/
 
// public async Task ProcessRequest(int itemId, CancellationToken ct)
// {
//  Busy = true;
//
//  try
//  {
//   await ProcessAsync(itemId, ct);
//  }
//  catch (Exception e) when (e is not OperationCanceledException)
//  {
//   LogError(e, $"Failed to process request for item ID {itemId}.");
//   throw;
//  }
//  finally
//  {
//   Busy = false;
//  }
//
// }
 
 
 /*
  * Преимущество использования обобщений — в возможности избежать упаковки и распаковки значимых типов. 
  * Это позволяет увеличить производительность кода.
  * Также благодаря обобщениям код можно использовать повторно.
  * Нет необходимости писать свой собственный код для каждого типа данных,
  * не нужно использовать перегрузку методов и писать отдельный классы для типов данных.
  * С generics в C# намного меньше шансов получить какие-либо ошибки,
  * поскольку код лежит в одном конкретном месте программы. 
  * Ссылка на статью https://highload.tech/generics-v-c-sharp/
  */
  
 // Статические поля generic-классов
 // Статические поля практически всегда уникальны для отдельно взятого закрытого типа:
 // class Bob<T> { public static int Count; }
 // ...
 // Console.WriteLine (++Bob<int>.Count); // 1
 // Console.WriteLine (++Bob<int>.Count); // 2
 // Console.WriteLine (++Bob<string>.Count); // 1
 // Console.WriteLine (++Bob<object>.Count); // 1
 
 /*
  *Среда выполнения .NET предоставляет множество типов коллекций,
  * которые хранят группы связанных объектов и управляют ими.
  * Некоторые типы коллекций, такие как System.Array, System.Span<T>и System.Memory<T>,
  * распознаются на языке C#. Кроме того, интерфейсы,
  * такие как System.Collections.Generic.IEnumerable<T> распознаются на языке для перечисления элементов коллекции.
  * ССылка на документацию https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/collections
  */
  
 /*
  * List<T>: создание
  */

// List<int> numbers = new List<int>();            // пустой
// List<string> names = new List<string> { "Ana", "Ben", "Chloe" };   // с начальными значениями
// var scores = new List<int> { 90, 85, 70 };      // var: тип выводится
// List<int> copy = new List<int>(numbers);        // копия другого списка

/*
 * Add, AddRange: добавить в конец
 */

// var names = new List<string>();
// names.Add("Ana");
// names.Add("Ben");
// names.AddRange(new[] { "Chloe", "Dan" });       // сразу несколько
// Console.WriteLine(string.Join(", ", names));    // Ana, Ben, Chloe, Dan

/*
 * Insert: вставить по индексу, остальные сдвигаются вправо
 */

// var names = new List<string> { "Ana", "Chloe" };
// names.Insert(1, "Ben");                         // Ana, Ben, Chloe
// names.Insert(0, "Zed");                         // Zed, Ana, Ben, Chloe

/*
 * Remove, RemoveAt, RemoveAll, Clear
 */

// var nums = new List<int> { 5, 3, 5, 8, 1 };
//
// bool ok = nums.Remove(5);        // удаляет ПЕРВОЕ совпадение, вернёт true/false
// // теперь: 3, 5, 8, 1
//
// nums.RemoveAt(0);                // удалить по индексу: 5, 8, 1
// nums.RemoveAll(x => x > 5);      // удалить по условию: 5, 1
// nums.Clear();                    // очистить весь список

/*
 * Contains, IndexOf: поиск
 */

// var names = new List<string> { "Ana", "Ben", "Chloe" };
//
// Console.WriteLine(names.Contains("Ben"));     // True
// Console.WriteLine(names.Contains("Zed"));     // False
// Console.WriteLine(names.IndexOf("Chloe"));    // 2
// Console.WriteLine(names.IndexOf("Zed"));      // -1 (не найден)

/*
 * Count и индексатор []
 * У массива Length, у списка Count
 */

// var names = new List<string> { "Ana", "Ben", "Chloe" };
//
// Console.WriteLine(names.Count);    // 3
// Console.WriteLine(names[0]);       // Ana
// names[1] = "Boris";                // заменить элемент
// Console.WriteLine(names[names.Count - 1]);   // последний: Chloe
// Console.WriteLine(names[^1]);                // то же самое, короче
//
// Console.WriteLine(names[10]);      // ошибка ArgumentOutOfRangeException

/*
 * Перебор
 */

// var names = new List<string> { "Ana", "Ben", "Chloe" };
//
// foreach (string n in names)
// {
//     Console.WriteLine(n);
// }
//
// for (int i = 0; i < names.Count; i++)
// {
//     Console.WriteLine($"{i}: {names[i]}");
// }
//
// // В foreach нельзя добавлять и удалять элементы списка:
// // будет InvalidOperationException. Для удаления используйте for с конца или RemoveAll.

/*
 * Полезное: Sort, Reverse, ToArray
 */

// var nums = new List<int> { 5, 2, 9, 1 };
// nums.Sort();                       // 1, 2, 5, 9
// nums.Reverse();                    // 9, 5, 2, 1
// int[] arr = nums.ToArray();        // список в массив
// var list = arr.ToList();           // массив в список (нужен using System.Linq)

/*
 * Еще один распространенный тип коллекции представляют словари.
 * Словарь хранит объекты, которые представляют пару ключ-значение.
 * Класс словаря Dictionary<K, V> типизируется двумя типами:
 * параметр K представляет тип ключей,
 * а параметр V предоставляет тип значений.
 * ссылка на ресурс https://metanit.com/sharp/tutorial/4.9.php
 */

/*
 * Обязательно использовать импорт Using
 */

using System.Collections.Generic;

 /*
  * Создания и инициализация словаря
  */

// Dictionary<int, string> people = new Dictionary<int, string>();

/*
 * При определении словаря его сразу же можно инициализировать значениями
 */

 // var ages = new Dictionary<string, int>();
 // ages["Аня"]  = 25;
 // ages["Боря"] = 30;
 // ages["Вика"] = 22;
 //
 // Console.WriteLine(ages["Боря"]);  // 30
 // Console.WriteLine(ages.Count);   
 
/*
 * Создание
 */

// Dictionary<string, int> ages = new Dictionary<string, int>();
//
// var prices = new Dictionary<string, double>
// {
//     { "Хлеб", 5.5 },
//     { "Молоко", 12.0 }
// };
//
// var rooms = new Dictionary<int, string>   // инициализатор через индексатор
// {
//     [10] = "Kilo",
//     [9] = "Mila"
// };

/*
 * Add и индексатор []
 */

// var ages = new Dictionary<string, int>();
//
// ages.Add("Ana", 20);
// ages.Add("Ben", 25);
// // ages.Add("Ana", 30);        // ошибка ArgumentException: ключ уже есть
//
// ages["Chloe"] = 22;            // ключа нет: добавит
// ages["Ana"] = 21;              // ключ есть: перезапишет (без ошибки)
//
// Console.WriteLine(ages["Ben"]);       // 25
// // Console.WriteLine(ages["Zed"]);    // ошибка KeyNotFoundException

/*
 * ContainsKey, ContainsValue: проверка
 */

// Console.WriteLine(ages.ContainsKey("Ana"));      // True
// Console.WriteLine(ages.ContainsKey("Zed"));      // False
// Console.WriteLine(ages.ContainsValue(25));       // True (медленнее, перебирает все значения)

/*
 * TryGetValue: безопасное получение (как TryParse)
 * Возвращает true/false, значение кладёт в out-переменную
 */

// if (ages.TryGetValue("Ben", out int age))
// {
//     Console.WriteLine($"Возраст Ben: {age}");
// }
// else
// {
//     Console.WriteLine("Не найден");
// }
//
// // Если ключа нет, age будет 0 (default), но использовать её не нужно.

/*
 * Remove, Count, Clear
 */

// ages.Remove("Ana");                  // true, если удалил
// Console.WriteLine(ages.Count);       // количество пар
// ages.Clear();                        // очистить

/*
 * Перебор
 */

// var ages = new Dictionary<string, int> { { "Ana", 20 }, { "Ben", 25 } };
//
// // Пары целиком
// foreach (KeyValuePair<string, int> pair in ages)
// {
//     Console.WriteLine($"{pair.Key}: {pair.Value}");
// }
//
// // То же короче: var и деконструкция
// foreach (var (name, age) in ages)
// {
//     Console.WriteLine($"{name}: {age}");
// }
//
// // Только ключи или только значения
// foreach (string key in ages.Keys) Console.WriteLine(key);
// foreach (int value in ages.Values) Console.WriteLine(value);
//
// // Менять словарь внутри foreach нельзя (InvalidOperationException).

/*
 * Частая задача: подсчёт повторов
 */

// string[] words = { "a", "b", "a", "c", "a", "b" };
// var counts = new Dictionary<string, int>();
//
// foreach (string w in words)
// {
//     if (counts.ContainsKey(w))
//         counts[w]++;
//     else
//         counts[w] = 1;
// }
// // a: 3, b: 2, c: 1

/*
 * Queue<T>, Stack<T> 
 */
 
 
 /*
  * HashSet<T>: создание и Add
  * Add возвращает true, если элемент добавлен, и false, если он уже был
  */

// var tags = new HashSet<string>();
//
// Console.WriteLine(tags.Add("c#"));       // True
// Console.WriteLine(tags.Add("sql"));      // True
// Console.WriteLine(tags.Add("c#"));       // False (дубликат, не добавлен)
// Console.WriteLine(tags.Count);           // 2
//
// var nums = new HashSet<int> { 1, 2, 2, 3, 3, 3 };   // останется 1, 2, 3

/*
 * Contains, Remove: быстрый поиск (быстрее, чем у List на больших данных)
 */

// Console.WriteLine(tags.Contains("sql"));   // True
// tags.Remove("sql");
// Console.WriteLine(tags.Contains("sql"));   // False
//
// // Индексатора нет: tags[0] даст ошибку. Только foreach.
// foreach (string t in tags)
//     Console.WriteLine(t);

/*
 * Убрать дубликаты из списка или массива
 */

// int[] data = { 5, 3, 5, 1, 3, 8 };
// var unique = new HashSet<int>(data);
// Console.WriteLine(string.Join(", ", unique));   // 5, 3, 1, 8

/*
 * Операции над множествами
 */

// var a = new HashSet<int> { 1, 2, 3, 4 };
// var b = new HashSet<int> { 3, 4, 5 };
//
// a.UnionWith(b);          // объединение: 1, 2, 3, 4, 5 (изменяет a)
// a.IntersectWith(b);      // пересечение: 3, 4, 5 (изменяет a)
// a.ExceptWith(b);         // разность: убирает из a всё, что есть в b
// Console.WriteLine(a.IsSubsetOf(b));   // true/false: a целиком входит в b

// var bookedRooms = new HashSet<int> { 9, 10 };
//
// int room = 11;
// if (bookedRooms.Add(room))
//     Console.WriteLine("Номер забронирован");
// else
//     Console.WriteLine("Номер уже занят");

/*
 * Enqueue: в конец, Dequeue: взять с начала и удалить, Peek: посмотреть без удаления
 */

// var queue = new Queue<string>();
//
// queue.Enqueue("Ana");
// queue.Enqueue("Ben");
// queue.Enqueue("Chloe");
//
// Console.WriteLine(queue.Peek());       // Ana (остаётся в очереди)
// Console.WriteLine(queue.Dequeue());    // Ana (удалён)
// Console.WriteLine(queue.Dequeue());    // Ben
// Console.WriteLine(queue.Count);        // 1

/*
 * Dequeue и Peek на пустой очереди дают InvalidOperationException
 * Безопасно: TryDequeue / TryPeek или проверка Count
 */

// if (queue.TryDequeue(out string? next))
//     Console.WriteLine($"Обслуживаем: {next}");
// else
//     Console.WriteLine("Очередь пуста");
//
// // Перебор: foreach идёт от начала очереди, элементы не удаляются
// foreach (string s in queue)
//     Console.WriteLine(s);

/*
 * Push: положить сверху, Pop: взять сверху и удалить, Peek: посмотреть без удаления
 */

// var stack = new Stack<string>();
//
// stack.Push("a");
// stack.Push("b");
// stack.Push("c");
//
// Console.WriteLine(stack.Peek());    // c (остаётся)
// Console.WriteLine(stack.Pop());     // c (удалён)
// Console.WriteLine(stack.Pop());     // b
// Console.WriteLine(stack.Count);     // 1
//
// // Pop и Peek на пустом стеке: InvalidOperationException
// if (stack.TryPop(out string? top))
//     Console.WriteLine(top);
//
// // Перебор: foreach идёт от верхнего элемента к нижнему

/*
 * Пример: проверка скобок в строке
 */

// bool IsBalanced(string text)
// {
//     var stack = new Stack<char>();
//
//     foreach (char c in text)
//     {
//         if (c == '(')
//             stack.Push(c);
//         else if (c == ')')
//         {
//             if (stack.Count == 0) return false;
//             stack.Pop();
//         }
//     }
//
//     return stack.Count == 0;
// }
//
// Console.WriteLine(IsBalanced("(a + b) * (c)"));   // True
// Console.WriteLine(IsBalanced("(a + b))"));        // False

/*
 * enum: объявление и использование
 * По умолчанию значения нумеруются с 0: Free = 0, Booked = 1, Cancelled = 2
 */

// enum RoomStatus { Free, Booked, Cancelled }
//
// RoomStatus status = RoomStatus.Free;
// Console.WriteLine(status);              // Free (выводится имя, не число)
//
// status = RoomStatus.Booked;
// if (status == RoomStatus.Booked)
//     Console.WriteLine("Номер занят");
//
// // enum объявляют после top-level кода или в отдельном файле

/*
 * Свои значения
 */

// enum Level
// {
//     Low = 10,
//     Medium = 50,
//     High = 100
// }
//
// enum Day { Mon = 1, Tue, Wed }   // дальше нумерация идёт сама: Tue = 2, Wed = 3

/*
 * enum в int и обратно: явное приведение
 */

// RoomStatus s = RoomStatus.Booked;
// int code = (int)s;                    // 1
// RoomStatus back = (RoomStatus)2;      // Cancelled
//
// // Приведение не проверяет значение: (RoomStatus)99 не даст ошибки
// Console.WriteLine(Enum.IsDefined(typeof(RoomStatus), 99));   // False

/*
 * Строка в enum и обратно
 */

// string text = RoomStatus.Free.ToString();             // "Free"
//
// if (Enum.TryParse("Booked", out RoomStatus parsed))   // как int.TryParse
//     Console.WriteLine(parsed);                        // Booked
//
// Enum.TryParse("booked", true, out RoomStatus p2);     // true: игнорировать регистр
//
// // Перебор всех значений
// foreach (RoomStatus v in Enum.GetValues<RoomStatus>())
//     Console.WriteLine($"{v} = {(int)v}");

/*
 * switch по enum: классический
 */

// switch (status)
// {
//     case RoomStatus.Free:
//         Console.WriteLine("Свободен");
//         break;
//     case RoomStatus.Booked:
//         Console.WriteLine("Занят");
//         break;
//     default:
//         Console.WriteLine("Отменён");
//         break;
// }
//
// /*
//  * switch expression: короче, возвращает значение
//  */
//
// string text = status switch
// {
//     RoomStatus.Free => "Свободен",
//     RoomStatus.Booked => "Занят",
//     RoomStatus.Cancelled => "Отменён",
//     _ => "Неизвестно"
// };

// [Flags]
// enum Perm { None = 0, Read = 1, Write = 2, Delete = 4 }
//
// Perm p = Perm.Read | Perm.Write;
// Console.WriteLine(p);                        // Read, Write
// Console.WriteLine(p.HasFlag(Perm.Write));    // True

/*
 * Создание: безымянные и именованные элементы
 */

// (int, string) pair = (1, "Ana");
// Console.WriteLine(pair.Item1);       // 1
// Console.WriteLine(pair.Item2);       // Ana
//
// (int Id, string Name) user = (1, "Ana");
// Console.WriteLine(user.Id);          // 1
// Console.WriteLine(user.Name);        // Ana
//
// var person = (Name: "Ben", Age: 25); // var + имена
// Console.WriteLine($"{person.Name}, {person.Age}");
//
// person.Age = 26;                     // элементы кортежа можно менять

/*
 * Кортеж как возвращаемое значение метода
 */

// (int Min, int Max) MinMax(int[] arr)
// {
//     int min = arr[0], max = arr[0];
//     foreach (int n in arr)
//     {
//         if (n < min) min = n;
//         if (n > max) max = n;
//     }
//     return (min, max);
// }
//
// var result = MinMax(new[] { 4, 9, 1 });
// Console.WriteLine($"{result.Min} {result.Max}");   // 1 9

/*
 * Деконструкция: разложить кортеж по переменным
 */

// (int min, int max) = MinMax(new[] { 4, 9, 1 });
// Console.WriteLine($"{min} {max}");
//
// var (a, b) = (10, "text");            // var для всех сразу
// var (x, _) = MinMax(new[] { 4, 9 });  // _ значит: второе значение не нужно
//
// // Обмен значений без временной переменной
// int p = 1, q = 2;
// (p, q) = (q, p);                      // p = 2, q = 1

/*
 * Сравнение: кортежи равны, если равны все элементы
 */

// Console.WriteLine((1, "a") == (1, "a"));   // True

/*
 * Кортеж в списке и словаре
 */

// var rooms = new List<(int Number, RoomStatus Status)>
// {
//     (10, RoomStatus.Free),
//     (9, RoomStatus.Booked)
// };
//
// foreach (var (number, status) in rooms)
//     Console.WriteLine($"{number}: {status}");

// (bool Success, string Message) Book(int room, HashSet<int> booked)
// {
//     if (booked.Add(room))
//         return (true, "Номер успешно забронирован");
//     return (false, "Номер уже занят");
// }
//
// var (ok, message) = Book(11, new HashSet<int> { 9, 10 });
// Console.WriteLine(message);


/*
 * Лямбда: (параметры) => выражение
 * Читается как «параметры → результат»
 */

// Func<int, int> square = x => x * x;
// Console.WriteLine(square(5));            // 25
//
// Func<int, int, int> add = (a, b) => a + b;
// Console.WriteLine(add(2, 3));            // 5
//
// Action hello = () => Console.WriteLine("Привет");   // без параметров
// hello();
//
// // Тело в { }, если несколько строк (нужен return, если есть результат)
// Func<int, string> describe = n =>
// {
//     if (n < 0) return "минус";
//     return n == 0 ? "ноль" : "плюс";
// };


/*
 * Action: метод без результата
 */

// Action<string> print = text => Console.WriteLine($"> {text}");
// print("Привет");
//
// Action<string, int> repeat = (text, n) =>
// {
//     for (int i = 0; i < n; i++) Console.WriteLine(text);
// };
// repeat("Ура", 3);

/*
 * Func: метод с результатом. Последний тип в <> это тип результата
 */

// Func<double> pi = () => 3.14;                      // 0 параметров, double
// Func<string, int> length = s => s.Length;          // string → int
// Func<int, int, bool> isBigger = (a, b) => a > b;   // (int, int) → bool

/*
 * Predicate: проверка «подходит или нет»
 */

// Predicate<int> isEven = n => n % 2 == 0;
// Console.WriteLine(isEven(4));    // True
// Console.WriteLine(isEven(5));    // False


/*
 * Свой метод принимает Func
 */

// int[] Apply(int[] arr, Func<int, int> op)
// {
//     var result = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//         result[i] = op(arr[i]);
//     return result;
// }
//
// int[] nums = { 1, 2, 3 };
//
// Console.WriteLine(string.Join(", ", Apply(nums, x => x * 2)));    // 2, 4, 6
// Console.WriteLine(string.Join(", ", Apply(nums, x => x + 10)));   // 11, 12, 13

/*
 * Можно передать и обычный метод по имени
 */

// int Triple(int x) => x * 3;
//
// Console.WriteLine(string.Join(", ", Apply(nums, Triple)));        // 3, 6, 9

/*
 * Так работают методы List<T>: RemoveAll, FindAll, Find, Exists, Sort, ForEach
 */

// var list = new List<int> { 5, 12, 7, 20, 3 };
//
// list.RemoveAll(n => n < 6);                  // удалить подходящие: 12, 7, 20
// int first = list.Find(n => n > 10);          // первый подходящий: 12
// List<int> big = list.FindAll(n => n > 8);    // все подходящие: 12, 20
// bool any = list.Exists(n => n == 7);         // True
// list.Sort((a, b) => b.CompareTo(a));         // по убыванию: 20, 12, 7
// list.ForEach(n => Console.WriteLine(n));     // Action для каждого


// int factor = 10;
// Func<int, int> mul = x => x * factor;
// Console.WriteLine(mul(3));      // 30
//
// factor = 100;                   // лямбда читает переменную, а не копию
// Console.WriteLine(mul(3));      // 300

// int factor = 10;
// Func<int, int> mul = x => x * factor;
// Console.WriteLine(mul(3));      // 30
//
// factor = 100;                   // лямбда читает переменную, а не копию
// Console.WriteLine(mul(3));      // 300

// Action log = () => Console.WriteLine("Первый");
// log += () => Console.WriteLine("Второй");   // += добавляет ещё метод
// log();                                      // выполнятся оба по порядку


// var rooms = new List<(int Number, bool Booked)>
// {
//     (9, true), (10, false), (11, false)
// };
//
// var free = rooms.FindAll(r => !r.Booked);
// Console.WriteLine($"Свободно: {free.Count}");
//
// void ShowRooms(List<(int Number, bool Booked)> list, Predicate<(int Number, bool Booked)> filter)
// {
//     foreach (var r in list)
//         if (filter(r)) Console.WriteLine($"Номер {r.Number}");
// }
//
// ShowRooms(rooms, r => !r.Booked);   // только свободные
// ShowRooms(rooms, r => r.Number > 9);  // другой фильтр, тот же метод

// int[] nums = { 5, 12, 7, 20, 3, 12 };
// var names = new List<string> { "Ana", "Ben", "Chloe", "Dan" };

/*
 * Where: оставить элементы, для которых условие true
 */

// var big = nums.Where(n => n > 6);
// Console.WriteLine(string.Join(", ", big));          // 12, 7, 20, 12
//
// var shortNames = names.Where(n => n.Length <= 3);
// Console.WriteLine(string.Join(", ", shortNames));   // Ana, Ben, Dan

/*
 * Select: из каждого элемента сделать новое значение
 */

// var doubled = nums.Select(n => n * 2);
// Console.WriteLine(string.Join(", ", doubled));      // 10, 24, 14, 40, 6, 24
//
// var lengths = names.Select(n => n.Length);          // 3, 3, 5, 3
//
// var upper = names.Select(n => n.ToUpper());         // ANA, BEN, CHLOE, DAN
//
// // Можно вернуть кортеж или анонимный тип
// var info = names.Select(n => (Name: n, Len: n.Length));

/*
 * OrderBy по возрастанию, OrderByDescending по убыванию
 * Исходная коллекция не меняется, возвращается новая последовательность
 */

// var asc = nums.OrderBy(n => n);                     // 3, 5, 7, 12, 12, 20
// var desc = nums.OrderByDescending(n => n);          // 20, 12, 12, 7, 5, 3
//
// var byLength = names.OrderBy(n => n.Length);        // Ana, Ben, Dan, Chloe
//
// // Вторичная сортировка: ThenBy
// var sorted = names.OrderBy(n => n.Length).ThenBy(n => n);

/*
 * Агрегаты: из коллекции получить одно число
 */

// Console.WriteLine(nums.Sum());                      // 59
// Console.WriteLine(nums.Count());                    // 6
// Console.WriteLine(nums.Max());                      // 20
// Console.WriteLine(nums.Min());                      // 3
// Console.WriteLine(nums.Average());                  // 9.8333...
//
// // С условием или выбором поля
// Console.WriteLine(nums.Count(n => n > 6));          // 4
// Console.WriteLine(names.Sum(n => n.Length));        // 14
// Console.WriteLine(names.Max(n => n.Length));        // 5
//
// // У List есть свойство Count, у LINQ метод Count().
// // Для списка и массива свойство (Count / Length) быстрее.

/*
 * First: первый элемент (или первый, подходящий под условие)
 * Если нет подходящего, будет InvalidOperationException
 */

// Console.WriteLine(nums.First());                    // 5
// Console.WriteLine(nums.First(n => n > 10));         // 12
// Console.WriteLine(nums.Last());                     // 12
//
// // FirstOrDefault: если нет, вернёт значение по умолчанию (0, null)
// Console.WriteLine(nums.FirstOrDefault(n => n > 100));        // 0
// string? found = names.FirstOrDefault(n => n.StartsWith("Z"));   // null
//
// if (found == null)
//     Console.WriteLine("Не найдено");

/*
 * Any: есть ли хотя бы один подходящий (без условия: не пуста ли коллекция)
 * All: подходят ли все
 */

// Console.WriteLine(nums.Any());                      // True
// Console.WriteLine(nums.Any(n => n > 15));           // True
// Console.WriteLine(nums.All(n => n > 0));            // True
// Console.WriteLine(nums.All(n => n > 5));            // False
// Console.WriteLine(nums.Contains(7));                // True
//
// // Для пустой коллекции: Any = false, All = true

// nums.Distinct();                    // без дубликатов: 5, 12, 7, 20, 3
// nums.Take(3);                       // первые три: 5, 12, 7
// nums.Skip(2);                       // пропустить два: 7, 20, 3, 12
// nums.Reverse();                     // в обратном порядке
// nums.ToList();                      // в List<int>
// nums.ToArray();                     // в массив
// names.GroupBy(n => n.Length);       // группировка по длине

/*
 * Цепочка: фильтр → сортировка → преобразование
 */

// var result = nums
//     .Where(n => n > 5)              // 12, 7, 20, 12
//     .Distinct()                     // 12, 7, 20
//     .OrderByDescending(n => n)      // 20, 12, 7
//     .Select(n => $"№{n}")           // №20, №12, №7
//     .ToList();
//
// Console.WriteLine(string.Join(", ", result));
//
// // Подсчёт в конце цепочки
// int total = nums.Where(n => n % 2 == 0).Sum();     // 12 + 20 + 12 = 44
//
// // Сначала Where, потом сортировка: меньше элементов для сортировки

// var query = nums.Where(n => n > 6);      // пока ничего не посчитано
// var list = query.ToList();               // здесь выполнен, результат зафиксирован
//
// // Если перебирать query несколько раз, он пересчитывается каждый раз.
// // Нужен результат один раз и надолго: ToList() или ToArray().

// var q = from n in nums
//         where n > 6
//         orderby n descending
//         select n * 2;

// var rooms = new List<(int Number, string Owner, bool Booked)>
// {
//     (9, "Mila", true),
//     (10, "Kilo", false),
//     (11, "Fiae", false)
// };
//
// // Свободные номера, по возрастанию
// var free = rooms.Where(r => !r.Booked).OrderBy(r => r.Number).Select(r => r.Number);
// Console.WriteLine("Свободные: " + string.Join(", ", free));       // 10, 11
//
// // Сколько занято
// Console.WriteLine(rooms.Count(r => r.Booked));                    // 1
//
// // Есть ли свободные номера
// Console.WriteLine(rooms.Any(r => !r.Booked));                     // True
//
// // Найти номер по владельцу, может не найтись
// var mila = rooms.FirstOrDefault(r => r.Owner == "Mila");
// Console.WriteLine(mila.Number);                                   // 9


/* OOP начало */



/*
 * Класс = чертёж. Объект = экземпляр, созданный по чертежу через new.
 * Поля хранят данные объекта, методы описывают его действия.
 * Классы пишутся ПОСЛЕ top-level кода (или в отдельном файле).
 */


 // Person tom = new Person();
 //
 // string personName = tom.name;
 // int personAge = tom.age;
 // Console.WriteLine($"Name: {personName}, Age: {personAge}");
 //
 // tom.name = "Tom";
 // tom.age = 34;
 //
 // tom.Print();
 //
 // class Person
 // {
 //  public string name = "Unrefiend";
 //  public int age;
 //
 //  public void Print()
 //  {
 //   Console.WriteLine($"Name: {name}, Age: {age}");
 //  }
 // }



// var room1 = new Room();
// room1.Number = 10;
// room1.Booked = false;
// room1.Show();                 // Номер 10: свободен
//
// var room2 = new Room();       // отдельный объект, свои данные
// room2.Number = 9;
// room2.Booked = true;
// room2.Show();                 // Номер 9: занят
//
// class Room
// {
//     public int Number;        // поле
//     public bool Booked;       // поле
//
//     public void Show()        // метод
//     {
//         string state = Booked ? "занят" : "свободен";
//         Console.WriteLine($"Номер {Number}: {state}");
//     }
//
//     public void Book() => Booked = true;   // метод меняет поля своего объекта
// }

/*
 * Что делает new
 * 1. Выделяет память под объект
 * 2. Заполняет поля значениями по умолчанию (0, false, null)
 * 3. Вызывает конструктор
 * 4. Возвращает ссылку на объект
 */

// class Demo
// {
//     public int N;            // 0
//     public bool Flag;        // false
//     public string? Text;     // null
// }
//
// Demo d = new Demo();         // полная запись
// Demo d2 = new();             // короткая (C# 9+), тип берётся слева
// var d3 = new Demo();         // var, тип берётся справа

/*
 * Инициализатор объекта: задать поля сразу при создании
 */

// var room = new Room { Number = 11, Booked = true };

/*
 * Ссылочная природа: переменная хранит ССЫЛКУ на объект, а не сам объект
 */

// var a = new Room { Number = 1 };
// var b = a;                         // копируется ссылка, объект один
// b.Number = 99;
// Console.WriteLine(a.Number);       // 99, a и b указывают на один объект
//
// var c = new Room { Number = 1 };   // другой объект
// Console.WriteLine(a == c);         // False: сравниваются ссылки, а не содержимое
//
// // Сравнение с int (значимый тип): копируется значение
// int x = 1;
// int y = x;
// y = 99;
// Console.WriteLine(x);              // 1

/*
 * Передача объекта в метод: копируется ссылка
 */

// void Rename(Room r)
// {
//     r.Number = 500;                // изменение объекта видно снаружи
//     r = new Room { Number = 7 };   // переприсваивание снаружи НЕ видно
// }
//
// var room = new Room { Number = 1 };
// Rename(room);
// Console.WriteLine(room.Number);    // 500

/*
 * null: ссылка есть, объекта нет
 */

// Room? r = null;
// // r.Show();                       // NullReferenceException
// r?.Show();                         // безопасно: ничего не произойдёт
//
// if (r != null) r.Show();           // то же через проверку
// Console.WriteLine(r?.Number);      // пусто: ?. вернул null
// Console.WriteLine(r?.Number ?? -1);   // -1: значение по умолчанию

/*
 * Объекты в коллекциях: замена анонимных типов в программе бронирования
 */

// var rooms = new List<Room>
// {
//     new Room { Number = 9, Booked = true },
//     new Room { Number = 10 },
//     new Room { Number = 11 }
// };
//
// rooms[1].Book();
// foreach (var r in rooms) r.Show();
//
// var free = rooms.Where(r => !r.Booked).ToList();   // LINQ работает с объектами
// rooms.Add(new Room { Number = 12 });               // добавить можно, в отличие от анонимных типов

/*
 * Сборщик мусора: объект без ссылок удаляется автоматически
 */

// var temp = new Room { Number = 1 };
// temp = null;                       // объект больше никем не используется,
//                                    // память освободит сборщик мусора (GC)


 public class Smartphone
 {
  private int _batteryLife;

  // Метод заряжает батарею, но не имеет доступа к уровню заряда
  public void Charge(int amount)
  {
   // Устанавливаем свои правила для работы с переменной
   if (amount <= 0)
   {
    throw new ArgumentException("В метод для зарядки телефона передано значение меньше либо равное нулю");
   }
      
   _batteryLife += amount;
  }

  // Метод получает текущее значение, но не может его изменить
  public int GetBatteryLife()
  {
   return _batteryLife;
  }
 }