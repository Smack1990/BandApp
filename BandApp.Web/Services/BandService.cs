using BandApp.Web.Models;

namespace BandApp.Web.Services;

public class BandService
{
    List<Band> products =
        [
        new Band {Id = 1, Name = "Mötley Crüe", Description = "Glam metal band from LA", Picture = "https://www.emp-shop.se/dw/image/v2/BBQV_PRD/on/demandware.static/-/Sites-master-emp/default/dwfe64817a/images/2/1/9/1/219102.jpg?sfrm=png", Video = "https://www.youtube.com/embed/CmXWkMlKFkI?si=T-xygjYwdin3BejK&autoplay=1", Album = new List<string>{ "Girls, Girls, Girls", "Dr. Feelgood", "Theatre of Pain" } },
        new Band {Id = 3, Name = "Sabaton", Description = "Swedish powermetal band that sing about war stories.", Picture = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSnY7nXkYLg9TEibLwI1AVgJEDkvrg91t-VI3YnhhH2OE2LmGV3kW11rH9dsqWW5xrdMqNfmz5-WzEoALYF1CZB8Q", Video = "https://www.youtube.com/embed/WBs3G1PvyfM?si=nUCtB0yAgZprvycH&autoplay=1", Album = new List<string>{"Primo Victoria", "Attero Dominatus", "Metalizer" } },
        new Band {Id = 5, Name = "Jonas brothers", Description = "An american pop band from jersey", Picture = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQhqhVNa4SW-vqLawXQGNP3XvWznSv5zH14GyhfU6sj-hO5opWGc0_DarRTxuPLF4jtpxHLTf7Z83Za2AZc2Jck2A", Video = "https://www.youtube.com/embed/3S56SxpSTvk?si=dgZoX7ZPx7goZUQ7&autoplay=1", Album = new List<string>{ "It's About Time", "A Little Bit Longer", "Lines, Vines and Trying Times" }}

        ];

    public Band GetBandById(int Id) => products.FirstOrDefault(x => x.Id == Id);

    public Band[] GetBands() => products
        .OrderByDescending(x => x.Name)
        .ToArray();
}
