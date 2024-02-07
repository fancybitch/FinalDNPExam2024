using WebAPI.Entities;

namespace WebAPI.Services;

public interface IDataService
{ 
  Task<Project> CreateProjectAsync(Project project);
  public void  AddUserStoryToProjectAsync(UserStory userstory, int projectId);
  
  Task<Project> GetProjectByIdAsync(int projectId);
  
  
}