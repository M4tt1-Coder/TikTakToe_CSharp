using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TikTakToe_Game.lib;
using TikTakToe_Game.Models;

namespace TikTakToe_Game.Controllers;

//https://www.youtube.com/watch?v=YYjCgsIQr3I

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly Checker _checker = new Checker();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //default field stats
        var first = new char[3] { ' ', ' ', ' ' };
        var second = new char[3] { ' ', ' ', ' ' };
        var third = new char[3] { ' ', ' ', ' ' };

        var model = new GameViewModel(first, second, third, 1);     
        _logger.LogDebug("game model created");
        
        return View(model);
    }

    
    [HttpPost("firstline/{symbolId}&&{index:int}")]
    public IActionResult ChoiceInFirstLine(char symbolId, int index, GameViewModel game)
    {
        //set players selection
        game.FirstLine[index] = symbolId;

        //check for a winner
        _checker.IsThereAWinner(game);
        
        //go to next round 
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost("secondline/{symbolId}&&{index:int}")]
    public IActionResult ChoiceInSecondLine(char symbolId, int index, GameViewModel game)
    {
        //set player selection
        game.SecondLine[index] = symbolId;

        //check for a winner
        _checker.IsThereAWinner(game);
        
        //increase round counter
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost("thirdline/{symbolId}&&{index:int}")]
    public IActionResult ChoiceInThirdLine(char symbolId, int index, GameViewModel game)
    {
        //setting
        game.ThirdLine[index] = symbolId;

        //a winner?
        _checker.IsThereAWinner(game);
        
        //round counter
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}