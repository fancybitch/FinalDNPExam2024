using Microsoft.AspNetCore.Http.HttpResults;
using WebAPI.Entities;

namespace WebAPI.Services;

public class DataService: IDataService
{
    static List<Project> projects= new()
    {
        new Project( 1, "Project 1", "In Progress", "Aleksandra",
            new List<UserStory> 
                {new UserStory(1, "User Story 1", 11), new UserStory(2, "User Story 2", 22)}),
        new Project( 2, "Project 2", "In Progress", "Mikkel",
            new List<UserStory>
                {new UserStory(3, "User Story 3", 13), new UserStory(4, "User Story 4", 22)}),
        new Project( 3, "Project 3", "In Progress", "Aleksandra",
            new List<UserStory>
                {new UserStory(5, "User Story 5", 15), new UserStory(6, "User Story 6", 44)}),
    };


    public async Task<Project> CreateProjectAsync(Project project)
    {
       
        projects.Add(project);
        return project;
    }

    public void AddUserStoryToProjectAsync(UserStory userstory, int projectId)
    {
        Project? project = projects.FirstOrDefault(p => p.Id == projectId);
        if (project == null)
        {
           Console.WriteLine($"Project with ID {projectId} not found."
        }
        project.UserStories.Add(userstory);
        
    }

    public async Task<Project> GetProjectByIdAsync(int projectId)
    {
        Project? project = projects.FirstOrDefault(p => p.Id == projectId);
        if (project == null)
        {
            Console.WriteLine($"Project with ID {projectId} not found."
        }
        return project;
    }
}
}