Player[] players =
{
    new Player("Player1", 12),
    new Player("Player1", 12),

};

players[0].PrintInfo();
Console.WriteLine(players[0] == players[1]);
Console.WriteLine(players[1].Equals(players[0]));

Thread.Sleep(1000);
Console.Clear();


User user1 = new User { Login = "Volodya" };
user1.Password = "password";
Console.WriteLine(user1.CheckPassword("password"));
user1.Password = "";

Thread.Sleep(1000);
Console.Clear();

Point p1 = new Point(3,6);
var p2 = p1;
p1.Move(3, 6);
Console.WriteLine($"{p1.x} "+ $"{p1.y}");
Console.WriteLine($"{p2.x} " + $"{p2.y}");
