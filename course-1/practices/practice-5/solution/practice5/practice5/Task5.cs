class Transport
{
    public virtual void Drive()
    {
        Console.WriteLine("Транспорт движется");
    }
}

class Car : Transport
{
    public override void Drive()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}

class ElectricCar : Car
{
    public override void Drive()
    {
        Console.WriteLine("Электромобиль тихо едет по дороге");
    }
}