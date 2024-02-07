using System.ComponentModel.DataAnnotations;

namespace EfcDataAccess.Entities;

public class Episode
{
    
    public string Title { get; set; }
    public int Runtime { get; set; }
    [Key]
    public string SeasonId { get; set; }
    public string ShowTitle { get; set; }
    
    public Episode()
    {
        
    }
        
}