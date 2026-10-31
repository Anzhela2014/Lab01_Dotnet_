// // // // See https://aka.ms/new-console-template for more information
// // // Console.WriteLine("ПРИВЕТ ОТ исп-242");
// // // Console.WriteLine("Авторы: Резник и Каменнова");
// // // Console.WriteLine("год 2026");
// // // int age = 20;
// // // double gpa = 4.5;
// // // bool isStudent = true;
// // // string name = "Иван";
// // // Console.WriteLine(name);
// // // Console.WriteLine(age);
// // // Console.WriteLine(gpa);
// // // Console.WriteLine(isStudent);
// // // var city = "Москва";
// // // var year = 2026;
// // // var pi = 3.14159;
// // // var isActive = true;
// // // string myName = "Lika Conya";
// // // int myAge = 18;
// // // string myGroup = "ИСП-242";
// // // Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");
// // // Console.Write("Введите ваше имя: ");
// // // string name2 = Console.ReadLine();
// // // Console.WriteLine($"Привет, {name2}!");
// // // Console.Write("Введите ваш возраст: ");
// // // string input = Console.ReadLine();
// // // int age2 = int.Parse(input);
// // // Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");
// // // int x = 10;
// // // int y = 3;
// // // Console.WriteLine(x + y);
// // // Console.WriteLine(x - y);
// // // Console.WriteLine(x * y);
// // // Console.WriteLine(x / y);
// // // Console.WriteLine(x % y);
// // // Информация о студенте
// // // string firstName = "Лика и Софья";
// // // string lastName = "Резник и Каменнова";
// // // string group = "ИСП-242";
// // // int birthYear = 2008;
// // // double gpa = 4.5;
// // // bool hasScholarship = true; 
// // // int currentYear = 2026;
// // // int age = currentYear - birthYear;
// // // Console.WriteLine("Студенческое удостоверение");
// // // Console.WriteLine($"Имя: {firstName} {lastName}");
// // // Console.WriteLine($"Группа: {group}");
// // // Console.WriteLine($"Возраст: {age} лет");
// // // Console.WriteLine($"Средний балл: {gpa}");
// // // Console.WriteLine($"Стипендия: {hasScholarship}");
// // // Console.Write("\nВведите ваш любимый предмет: ");
// // // string subject = Console.ReadLine();
// // // Console.WriteLine($"Отлично! {firstName} любит {subject}.");
// // // int a = 15;
// // // int b = 4;
// // // Console.WriteLine($"Сумма: {a + b}");
// // // Console.WriteLine($"Разность: {a - b}");
// // // Console.WriteLine($"Произведение: {a * b}");
// // // Console.WriteLine($"Частное (int): {a / b}");
// // // Console.WriteLine($"Остаток: {a % b}");
// // // double result = (double)a / b;
// // // Console.WriteLine($"Частное (double): {result}");
// // // Console.WriteLine();
// // // Console.WriteLine(Math.Abs(-5));
// // // Console.WriteLine(Math.Pow(2, 10));
// // // Console.WriteLine(Math.Sqrt(144));
// // // Console.WriteLine(Math.Max(10, 25));
// // // Console.WriteLine(Math.Min(10, 25));
// // // Console.WriteLine(Math.Round(3.567, 2));
// // Console.WriteLine("Калькулятор");
// // Console.Write("Введите первое число: ");
// // double num1 = double.Parse(Console.ReadLine());
// // Console.Write("Введите второе число: ");
// // double num2 = double.Parse(Console.ReadLine());

// // Console.WriteLine($"Сумма: {num1 + num2}");
// // Console.WriteLine($"Разность: {num1 - num2}");
// // Console.WriteLine($"Произведение: {num1 * num2}");
// // if (num2 != 0)
// //     Console.WriteLine($"Частное: {num1 / num2}");
// // else
// //     Console.WriteLine("Деление на ноль невозможно!");
// // Console.WriteLine(int.MaxValue);
// // Console.WriteLine(int.MinValue);
// // Console.WriteLine(double.MaxValue);
// // Console.WriteLine(double.MinValue);
// // Console.Write("n1: ");
// // double n1 = double.Parse(Console.ReadLine());
// // Console.Write("n2: ");
// // double n2 = double.Parse(Console.ReadLine());
// // Console.WriteLine($"Сумма: {n1 + n2}");
// // Console.WriteLine($"Разность: {n1 - n2}");
// // Console.WriteLine($"Произведение: {n1 * n2}");
// // if (n2 != 0)
// // {
// //     Console.WriteLine($"Частное: {n1 / n2}");
// // }
// // else
// // {
// //     Console.WriteLine("На 0 делить нельзя!");
// // }
// Console.Write("Введите ваше имя: ");
// string name = Console.ReadLine();

// Console.Write("Введите вашу фамилию: ");
// string surname = Console.ReadLine();

// Console.Write("Введите вашу группу: ");
// string group = Console.ReadLine();

// Console.Write("Введите ваш год рождения: ");
// int birthYear = int.Parse(Console.ReadLine());

// Console.Write("Введите ваш средний балл (например, 4.5): ");
// double gpa = double.Parse(Console.ReadLine());

// int currentYear = 2026;
// int age = currentYear - birthYear;
// bool isExcellent = gpa >= 4.5;

// string status;
// if (isExcellent == true) status = "Отличник";
// else status = "Хорошист";

// Console.WriteLine("\nВаша анкета");
// Console.WriteLine($"Имя: {name} {surname}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Статус: {status}");
// Console.WriteLine($"Лет до 30: {30 - age}");
// Задание 1
string game = "Minecraft";
int num = 7;
double pi = 3.14159;
char lit = 'A';

Console.WriteLine(game);
Console.WriteLine(num);
Console.WriteLine(pi);
Console.WriteLine(lit);
Console.WriteLine();

// Задание 2
Console.WriteLine("I");
Console.WriteLine("need");
Console.WriteLine("more");
Console.WriteLine("power!");
Console.WriteLine();

// Задание 3
Console.WriteLine("\"Hello There\"");
Console.WriteLine();

// Задание 4
int m = int.Parse(Console.ReadLine());
int s = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int mys = int.Parse(Console.ReadLine());

int res = (m + s + k + mys) * 3;
Console.WriteLine(res);
Console.WriteLine();

// Задание 5
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
double f = 3 * Math.Pow(a + b, 3) + 275 * Math.Pow(b, 2) - 127 * a - 41;
Console.WriteLine(f);
Console.WriteLine();

// Задание 6
double c = double.Parse(Console.ReadLine());
double fahr = c * 1.8 + 32;
Console.WriteLine($"Температура: {fahr}°F");