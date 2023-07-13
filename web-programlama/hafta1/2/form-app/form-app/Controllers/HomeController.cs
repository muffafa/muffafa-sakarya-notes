using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using form_app.Models;

namespace form_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public string OgrKaydet(string ogrAd, string ogrSoyad, string ogrNo) {
        return ogrAd + ogrSoyad + ogrNo;
    }

    public string OgrKaydetGet()
    {
        return HttpContext.Request.Query["ogrAd"] + HttpContext.Request.Query["ogrSoyad"] + HttpContext.Request.Query["ogrNo"];
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

