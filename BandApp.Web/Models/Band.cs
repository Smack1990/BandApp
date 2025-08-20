namespace BandApp.Web.Models;

public class Band
{
    //public Band(int id, string name, string? description, string? picture, string? video, List<string>? album)
    //{
    //    Id = id;
    //    Name = name;
    //    Description = description;
    //    Picture = picture;
    //    Video = video;
    //    Album = album;
    //}

    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? Picture { get; set; }
    public string? Video { get; set; }
    public List<string>? Album { get; set; }

}
