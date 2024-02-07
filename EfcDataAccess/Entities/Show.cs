using System.ComponentModel.DataAnnotations;

namespace EfcDataAccess.Entities;

public class Show
{
    [Key]
    public string Title { get; set; }
    public short Year { get; set; }
    public string Genre { get; set; }
    
    public ICollection<Episode> Episodes { get; set; }
    
    public Show()
    {
        
    }
}