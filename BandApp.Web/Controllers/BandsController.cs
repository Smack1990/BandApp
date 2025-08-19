using BandApp.Web.Models;
using BandApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BandApp.Web.Controllers;

public class BandsController : Controller
{
    BandService bandService = new BandService();

    [Route("")]
    public IActionResult Index()
    {
        Band[] model = bandService.GetBands();
        return View(model);
    }
    [Route("bands/{id}")]
    public IActionResult Details(int id)
    {
        Band model = bandService.GetBandById(id);
        if (model == null)
        {
            return NotFound();
        }
        return View(model);
    }

}
