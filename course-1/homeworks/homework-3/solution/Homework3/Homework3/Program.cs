// Калькулятор оценок
int[] grades = [4, 5, 3, 2, 3, 5, 4];
int average = 0;
int kolvo5 = 0;
int kolvo2 = 0;

for (int i = 0; i < grades.Length; i++)
{
    if(grades[i] == 5)
    {
        kolvo5++;
    }

    if(grades[i] == 2)
    {
        kolvo2++;
    }

    average += grades[i];
}

Console.Write("Среднее арифметиеское: ");
Console.Write(average/grades.Length);
Console.WriteLine();
Console.Write("Количество пятерок: ");
Console.Write(kolvo5);
Console.WriteLine();
Console.Write("Количество двоек: ");
Console.Write(kolvo2);
Thread.Sleep(1000);
Console.Clear();

//Переворот массива
int[] a = [0, 1, 2, 3, 4];

Console.Write("Массив из чисел: ");
for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i]);
}

Console.WriteLine();
Console.Write("Перевернутый массив из чисел: ");
for (int i = 4; i < a.Length && i >= 0; i--)
{
    Console.Write(a[i]);
}

Thread.Sleep(1000);
Console.Clear();

//Вывод четных чисел
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
    else
        continue;
}

Thread.Sleep(1000);
Console.Clear();

//Ввод пароля с ограниенными попытками
string correctPassword = "1234";
int attempt = 1;

do
{
    Console.WriteLine("Введите пароль:");
    string Password = Console.ReadLine();

    if (attempt == 3)
    {
        Console.WriteLine("Попробуйте снова позже");
        break;
    }

    if (correctPassword == Password)
    {
        Console.WriteLine("Доступ разрешен");
        break;
    }
    else
    {
        Console.WriteLine("Доступ запрещен");
    }

    attempt++;
}
while (attempt < 4);

