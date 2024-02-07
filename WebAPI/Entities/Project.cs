namespace WebAPI.Entities;

public class Project
{ 
    private int Id { get; set; }
    private string Title { get; set; }
    private string Status { get; set; }
    private string Responsible { get; set; }
    
    private List<UserStory> UserStories { get; set; }


    public Project(int id, string title, string status, string responsible, List<UserStory> userStories)
    {
        Id = id;
        Title = title;
        Status = status;
        Responsible = responsible;
        UserStories = userStories;
    }
   
}