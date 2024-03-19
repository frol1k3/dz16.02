User user = new("12345", "Alex", false);
user.print();
user.setAdmin();
user.print();
user.relogin("Alexandr");
user.print();

class User
{
    private string login;
    private string password;
    private string last_login;
    private bool admin;

    public User(string password, string login, bool admin)
    {
        Password = password;
        Login = login;
        Last_login = login;
        Admin = admin;
    }

    public string Password { get => password; set => password = value; }
    public string Login { get => login; set => login = value; }
    public string Last_login { get => last_login; set => last_login = value; }
    public bool Admin { get => admin; set => admin = value; }

    public void print()
    {
        if (this.Admin)
        {
            Console.WriteLine($"Логин: {this.Login}, предыдущий логин: {this.Last_login}, роль: Админ");
        }
        else
        {
            Console.WriteLine($"Логин: {this.Login}, предыдущий логин: {this.Last_login}, роль: Пользователь");
        }
    }
    public void setAdmin()
    {
        this.Admin = true;
    }

    public void relogin(string login)
    {
        this.Last_login = this.Login;
        this.Login = login;
    }
}