public class Player
{
    public string name;
    public int level;
    public Player(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}\n" +
            $"Уровень: {level}");
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj is Player player)
        {
            return this.name == player.name && this.level == player.level;
        }

        return false;
    }
}
