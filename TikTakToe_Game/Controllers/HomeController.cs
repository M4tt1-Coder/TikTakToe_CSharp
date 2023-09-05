using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TikTakToe_Game.lib;
using TikTakToe_Game.Models;

namespace TikTakToe_Game.Controllers;

//https://www.youtube.com/watch?v=YYjCgsIQr3I

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    /// <summary>
    /// A instance of a local validator
    /// </summary>
    private readonly Checker _checker = new Checker();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    /// <summary>
    /// Main action result and only view returned -> leads to the homepage for the game
    /// </summary>
    /// <returns>View object of the homepage</returns>
    public IActionResult Index()
    {
        GameViewModel game = lib.TextFileNode.GetGame();
        
        _logger.LogDebug("game model created");
        
        return View(game);
    }

    
    [HttpPost]
    public IActionResult FirstFirst()
    {
        GameViewModel game = lib.TextFileNode.GetGame();

        if (game.Over)
        {
            return RedirectToAction("Index");
        }
        
        if (game.FirstLine[0] != ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set players selection
        if (game.Round % 2 == 0)
        {
            game.FirstLine[0] = 'O';
        }
        else
        {
            game.FirstLine[0] = 'X';
        }
        //check for a winner
        game = _checker.IsThereAWinner(game);
        
        //go to next round 
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        lib.TextFileNode.SaveGame(game);
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult FirstSecond()
    {
        GameViewModel game = lib.TextFileNode.GetGame();
        
        if (game.Over)
        {
            return RedirectToAction("Index");
        }
        
        if (game.FirstLine[1] != ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set players selection
        if (game.Round % 2 == 0)
        {
            game.FirstLine[1] = 'O';
        }
        else
        {
            game.FirstLine[1] = 'X';
        }

        //check for a winner
        game = _checker.IsThereAWinner(game);
        
        //go to next round 
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        lib.TextFileNode.SaveGame(game);
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult FirstThird()
    {
        GameViewModel game = lib.TextFileNode.GetGame();
        
        if (game.Over)
        {
            return RedirectToAction("Index");
        }
        
        if (game.FirstLine[2] != ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set players selection
        if (game.Round % 2 == 0)
        {
            game.FirstLine[2] = 'O';
        }
        else
        {
            game.FirstLine[2] = 'X';
        }

        //check for a winner
        game = _checker.IsThereAWinner(game);
        
        //go to next round 
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        lib.TextFileNode.SaveGame(game);
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult SecondFirst()
    {
        GameViewModel game = lib.TextFileNode.GetGame();
        
        if (game.Over)
        {
            return RedirectToAction("Index");
        }
        
        if (game.SecondLine[0] != ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set player selection
        if (game.Round % 2 == 0)
        {
            game.SecondLine[0] = 'O';
        }
        else
        {
            game.SecondLine[0] = 'X';
        }

        //check for a winner
        game = _checker.IsThereAWinner(game);
        
        //increase round counter
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        lib.TextFileNode.SaveGame(game);
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult SecondSecond()
    {
        GameViewModel game = lib.TextFileNode.GetGame();
        
        if (game.Over)
        {
            return RedirectToAction("Index");
        }
        
        if (game.SecondLine[1] != ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set player selection
        if (game.Round % 2 == 0)
        {
            game.SecondLine[1] = 'O';
        }
        else
        {
            game.SecondLine[1] = 'X';
        }

        //check for a winner
        game = _checker.IsThereAWinner(game);
        
        //increase round counter
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        lib.TextFileNode.SaveGame(game);
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult SecondThird()
    {
        GameViewModel game = lib.TextFileNode.GetGame();
        
        if (game.Over)
        {
            return RedirectToAction("Index");
        }
        
        if (game.SecondLine[2] != ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set player selection
        if (game.Round % 2 == 0)
        {
            game.SecondLine[2] = 'O';
        }
        else
        {
            game.SecondLine[2] = 'X';
        }

        //check for a winner
        game = _checker.IsThereAWinner(game);
        
        //increase round counter
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        lib.TextFileNode.SaveGame(game);        
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult ThirdFirst()
    {
        GameViewModel game = lib.TextFileNode.GetGame();
        
        if (game.Over)
        {
            return RedirectToAction("Index");
        }
        
        if (game.ThirdLine[0] != ' ')
        {
            return RedirectToAction("Index");
        }        
        
        //setting
        if (game.Round % 2 == 0)
        {
            game.ThirdLine[0] = 'O';
        }
        else
        {
            game.ThirdLine[0] = 'X';
        }
        
        //a winner?
        game = _checker.IsThereAWinner(game);
        
        //round counter
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        lib.TextFileNode.SaveGame(game);
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult ThirdSecond()
    {
        GameViewModel game = lib.TextFileNode.GetGame();
        
        if (game.Over)
        {
            return RedirectToAction("Index");
        }
        
        if (game.ThirdLine[1] != ' ')
        {
            return RedirectToAction("Index");
        }        
        
        //setting
        if (game.Round % 2 == 0)
        {
            game.ThirdLine[1] = 'O';
        }
        else
        {
            game.ThirdLine[1] = 'X';
        }
        
        //a winner?
        game = _checker.IsThereAWinner(game);
        
        //round counter
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        lib.TextFileNode.SaveGame(game);
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult ThirdThird()
    {
        GameViewModel game = lib.TextFileNode.GetGame();
        
        if (game.Over)
        {
            return RedirectToAction("Index");
        }
        
        if (game.ThirdLine[2] != ' ')
        {
            return RedirectToAction("Index");
        }        
        
        //setting
        if (game.Round % 2 == 0)
        {
            game.ThirdLine[2] = 'O';
        }
        else
        {
            game.ThirdLine[2] = 'X';
        }
        
        //a winner?
        game = _checker.IsThereAWinner(game);
        
        //round counter
        game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        lib.TextFileNode.SaveGame(game);
        
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult ResetGame()
    {
        lib.TextFileNode.ResetGame();

        return RedirectToAction("Index");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}