int grade = Convert.ToInt32(Console.ReadLine());

if (grade < 3)
{
    Console.WriteLine("неудовлетворительно");
}
else if (grade == 3)
{
    Console.WriteLine("удовлетворительно");
}
else if (grade == 4)
{
    Console.WriteLine("хорошо");
}
else if (grade == 5)
{
    Console.WriteLine("отлично");
}