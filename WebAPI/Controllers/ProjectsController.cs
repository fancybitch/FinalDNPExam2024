using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;
using WebAPI.Services;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectsController: ControllerBase
{
    private readonly IDataService dataService;
    
    public ProjectsController(IDataService dataService)
    {
        this.dataService = dataService;
    }
    
    [HttpPost]
    public async Task<ActionResult<Project>> Create([FromBody] Project project)
    {
        try
        { 
            dataService.CreateProjectAsync(project);
           return Created($"/projects/{project}", project);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    [HttpPut]
    public void AddUserStoryToProject([FromBody] UserStory userStory,[FromRoute] int id)
    {
        try
        {
            Project project = await dataService.AddUserStoryToProjectAsync(userStory, id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Project>> GetProjectById([FromRoute] int id)
    {
        try
        {
            Project project = await dataService.GetProjectByIdAsync(id);
            return Ok(project);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    
}