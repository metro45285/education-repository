// Конвертор температуры
Console.WriteLine("Введите температуру в градусах цельсия");
int C = Convert.ToInt32(Console.ReadLine());
int F = C * 9 / 5 + 32;
Console.Write("Температура по шкале форенгейта: ");
Console.Write(F);

Thread.Sleep(1000);
Console.Clear();

// Среднее арифметическое 
Console.WriteLine("Введите 3 числа каждое в новой строке");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

float average = (a + b + c) / 3;
Console.Write("Среднее арифметическое: ");
Console.Write(average);

Thread.Sleep(1000);
Console.Clear();

// Калькулятор
Console.WriteLine("Введите 2 числа каждое в новой строке");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма чисел:");
Console.WriteLine(num1+num2);
Console.WriteLine("Произведение чисел:");
Console.WriteLine(num1*num2);
Console.WriteLine("Отношение чисел:");
Console.WriteLine(num1/num2);
Console.WriteLine("Разность чисел:");
Console.WriteLine(num1-num2);