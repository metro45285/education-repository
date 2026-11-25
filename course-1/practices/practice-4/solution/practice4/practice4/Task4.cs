public class User
{
    public string Login { get; set; }
    private string password;
    public string Password
    {
        get => password;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                password = value;
                Console.WriteLine("Пароль обновлен");
            }
            else
                Console.WriteLine("Пароль не может быть пустым");
        }
    }
    public bool CheckPassword(string password)
    {
        return password == Password;
    }
}
