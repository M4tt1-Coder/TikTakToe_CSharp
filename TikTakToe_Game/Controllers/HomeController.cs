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
        //TODO - set the model outside of the index method 
        
        return View(model);
    }

    
    [HttpPost("/firstline/{index:int}")]
    public IActionResult ChoiceInFirstLine(int index, GameViewModel game)
    {
        //TODO - Add check if field was already chosen
        //set players selection
        if (game.Round % 2 == 0)
        {
            game.FirstLine[index] = 'O';
        }
        else
        {
            game.FirstLine[index] = 'X';
        }

        //check for a winner
        _checker.IsThereAWinner(game);
        
        //go to next round 
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost("/secondline/{index:int}")]
    public IActionResult ChoiceInSecondLine(int index, GameViewModel game)
    {
        //set player selection
        if (game.Round % 2 == 0)
        {
            game.SecondLine[index] = 'O';
        }
        else
        {
            game.SecondLine[index] = 'X';
        }

        //check for a winner
        _checker.IsThereAWinner(game);
        
        //increase round counter
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost("/thirdline/{index:int}")]
    public IActionResult ChoiceInThirdLine(int index, GameViewModel game)
    {
        //setting
        if (game.Round % 2 == 0)
        {
            game.ThirdLine[index] = 'O';
        }
        else
        {
            game.ThirdLine[index] = 'X';
        }
        
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