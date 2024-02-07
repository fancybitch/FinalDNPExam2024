namespace WebAPI.Entities;

public class UserStory
{
    private int Id { get; set; }
    private string Description { get; set; }
    private int Estimate { get; set; }
    
    public UserStory(int id, string description, int estimate)
    {
        Id = id;
        Description = description;
        Estimate = estimate;
    }
}