void SayHello(string message)
{
    Console.WriteLine(message);
}

SayHello("Привет, мир");
SayHello("Привет, мир");
SayHello("Привет, мир");

Thread.Sleep(1000);
Console.Clear();
string Greet(string name)
{
    string d = "Привет, " + name;
    return d;
}

Console.WriteLine(Greet("Саша"));
Console.WriteLine(Greet("Коля"));
Console.WriteLine(Greet("Света"));

Thread.Sleep(1000);
Console.Clear();

string PrintPerson(string name, int age, string city)
{
    return "Имя-" + name + " Возраст-" + age + " Город-" + city;
}

Console.WriteLine(PrintPerson("Артем", 16, "Симферополь"));
Console.WriteLine(PrintPerson("Коля", 23, "Алушта"));

Thread.Sleep(1000);
Console.Clear();

string PrintPerson2(string name, int age = 18, string hobby = "Не указано")
{
    return "Имя-" + name + " Возраст-" + age + " Хобби-" + hobby;
}

Console.WriteLine(PrintPerson2("Артем"));
Console.WriteLine(PrintPerson2("Кирилл", 17, "Программирование"));

Thread.Sleep(1000);
Console.Clear();

int Square(int x)
{
    return x * x;
}

Console.WriteLine(Square(5));