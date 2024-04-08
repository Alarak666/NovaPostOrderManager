namespace Core.Model;

public class Status
{
    public int Id { get; set; }
    public string Description { get; set; }

    public Status(int id, string description)
    {
        Id = id;
        Description = description;
    }
}