// Калькулятор

double Add(double a, double b)
{
    return a + b;
}
double Substract(double a, double b)
{
    return a - b;
}
double Multiply(double a, double b)
{
    return (a * b);
}
double Divide(double a, double b)
{
    return a / b;
}

while (true)
{
    Console.Write("Введите выражение: ");
    string expression = Console.ReadLine();
    if (expression == "exit")
    {
        Console.WriteLine("Программа завершенна");
        break;
    }
    string[] allParts = expression.Split(' ');
    double a = double.Parse(allParts[0]);
    double b = double.Parse(allParts[2]);
    string action = allParts[1];
    double result = 0;

    if (action == "+")
        result = Add(a, b);
    if (action == "-")
        result = Substract(a, b);
    if (action == "*")
        result = Multiply(a, b);
    if (action == "/")
        result = Divide(a, b);

    Console.WriteLine($"Результат: {result}");
}

Thread.Sleep(1000);
Console.Clear();
// Телефон

var phone = new Phone { model = "Samsung" };
Console.WriteLine(phone.model);
phone.Charge(115);
Console.WriteLine(phone.battery);
phone.Use(1234);
Console.WriteLine(phone.battery);
public class Phone
{
    public string model;
    public int battery = 0;

    public void Charge(int charge)
    {
        if (battery + charge <= 100)
            battery += charge;
        else
           battery = 100;
    }
    public void Use(int charge)
    {
        if (battery >= charge)
            battery -= charge;
        else
            battery = 0;
    }

}


