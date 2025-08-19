using BandApp.Web.Models;

namespace BandApp.Web.Services;

public class BandService
{
    List<Band> products =
        [
        new Band {Id = 1, Name = "Mötley Crüe", Description = "Glam metal band from LA"},
        new Band {Id = 3, Name = "Sabaton", Description = "Swedish powermetal band that sing about war stories."},
        new Band {Id = 5, Name = "Jonas brothers", Description = "An american pop band from jersey"},

        ];

    public Band GetBandById(int Id) => products.FirstOrDefault(x => x.Id == Id);

    public Band[] GetBands() => products
        .OrderByDescending(x => x.Name)
        .ToArray();
}
