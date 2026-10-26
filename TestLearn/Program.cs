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

