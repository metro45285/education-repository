class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Создано животное: {Name}");
    }
    public void Eat()
    {
        Console.WriteLine($"{Name} ест");
    }
    public virtual void Speak()
    {
        Console.WriteLine($"{Name} издает звук");
    }
    public virtual void Move()
    {
        Console.WriteLine($"{Name} двигается");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public void Bark()
    {
        Console.WriteLine($"{Name} лает");
    }
    public override void Speak()
    {
        Console.WriteLine($"{Name} говорит гав-гав");
    }
    public override void Move()
    {
        base.Move();
        Console.WriteLine($"{Name} бежит по дороге");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        Console.WriteLine($"Создана кошка по имени: {Name}");
    }
    public void Meow()
    {
        Console.WriteLine($"{Name} мяукает");
    }
    public override void Speak()
    {
        Console.WriteLine($"{Name} говорит мяу-мяу");
    }
}