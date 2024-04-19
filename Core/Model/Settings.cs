namespace Core.Model;

public class Settings
{
    public string ApiKey { get; set; }
    public string Server { get; set; }
    public UserData UserData { get; set; } = new UserData();
}