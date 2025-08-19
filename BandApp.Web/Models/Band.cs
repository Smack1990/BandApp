namespace BandApp.Web.Models;

public class Band
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

}
