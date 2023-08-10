using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TikTakToe_Game.Models;

namespace TikTakToe_Game.Controllers;

//https://www.youtube.com/watch?v=YYjCgsIQr3I

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //default field stats
        var first = new int[3] { 0, 0, 0 };
        var second = new int[3] { 0, 0, 0 };
        var third = new int[] { 0, 0, 0 };

        var model = new GameViewModel(first, second, third, 1);     
        
        return View();
    }

    [HttpPost]
    public IActionResult SetPlayerChoice()
    {
        
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}