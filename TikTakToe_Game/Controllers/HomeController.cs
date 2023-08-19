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

    //when IActionResult function is called the game instance gets reseted 
    //-> store game in txt file and delete it afterwards (like database)
    //-> maybe extern lib to hold the instance 
    
    private GameViewModel _defaultgame = new GameViewModel(
        new char[3] { 'X', ' ', ' ' },
        new char[3] { ' ', ' ', ' ' },
        new char[3] { ' ', ' ', ' ' },
        1
        );

    private GameViewModel _game;
    
    public IActionResult Index()
    {
        if (_game == null)
        {
            _game = _defaultgame;
        }
        _logger.LogDebug("_game model created");
        //TODO - set the model outside of the index method 
        
        return View(_game);
    }

    
    [HttpPost]
    public IActionResult FirstFirst()
    {
        if (_game.FirstLine[0] != ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set players selection
        if (_game.Round % 2 == 0)
        {
            _game.FirstLine[0] = 'O';
        }
        else
        {
            _game.FirstLine[0] = 'X';
        }

        //check for a winner
        _checker.IsThereAWinner(_game);
        
        //go to next round 
        _game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult FirstSecond()
    {
        if (_game.FirstLine[1] == ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set players selection
        if (_game.Round % 2 == 0)
        {
            _game.FirstLine[1] = 'O';
        }
        else
        {
            _game.FirstLine[1] = 'X';
        }

        //check for a winner
        _checker.IsThereAWinner(_game);
        
        //go to next round 
        _game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult FirstThird()
    {
        if (_game.FirstLine[2] == ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set players selection
        if (_game.Round % 2 == 0)
        {
            _game.FirstLine[2] = 'O';
        }
        else
        {
            _game.FirstLine[2] = 'X';
        }

        //check for a winner
        _checker.IsThereAWinner(_game);
        
        //go to next round 
        _game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult SecondFirst()
    {
        if (_game.SecondLine[0] == ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set player selection
        if (_game.Round % 2 == 0)
        {
            _game.SecondLine[0] = 'O';
        }
        else
        {
            _game.SecondLine[0] = 'X';
        }

        //check for a winner
        _checker.IsThereAWinner(_game);
        
        //increase round counter
        _game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult SecondSecond()
    {
        if (_game.SecondLine[1] == ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set player selection
        if (_game.Round % 2 == 0)
        {
            _game.SecondLine[1] = 'O';
        }
        else
        {
            _game.SecondLine[1] = 'X';
        }

        //check for a winner
        _checker.IsThereAWinner(_game);
        
        //increase round counter
        _game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult SecondThird()
    {
        if (_game.SecondLine[2] == ' ')
        {
            return RedirectToAction("Index");
        }
        
        //set player selection
        if (_game.Round % 2 == 0)
        {
            _game.SecondLine[2] = 'O';
        }
        else
        {
            _game.SecondLine[2] = 'X';
        }

        //check for a winner
        _checker.IsThereAWinner(_game);
        
        //increase round counter
        _game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult ThirdFirst()
    {
        if (_game.ThirdLine[0] == ' ')
        {
            return RedirectToAction("Index");
        }        
        
        //setting
        if (_game.Round % 2 == 0)
        {
            _game.ThirdLine[0] = 'O';
        }
        else
        {
            _game.ThirdLine[0] = 'X';
        }
        
        //a winner?
        _checker.IsThereAWinner(_game);
        
        //round counter
        _game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult ThirdSecond()
    {
        if (_game.ThirdLine[1] == ' ')
        {
            return RedirectToAction("Index");
        }        
        
        //setting
        if (_game.Round % 2 == 0)
        {
            _game.ThirdLine[1] = 'O';
        }
        else
        {
            _game.ThirdLine[1] = 'X';
        }
        
        //a winner?
        _checker.IsThereAWinner(_game);
        
        //round counter
        _game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult ThirdThird()
    {
        if (_game.ThirdLine[2] == ' ')
        {
            return RedirectToAction("Index");
        }        
        
        //setting
        if (_game.Round % 2 == 0)
        {
            _game.ThirdLine[2] = 'O';
        }
        else
        {
            _game.ThirdLine[2] = 'X';
        }
        
        //a winner?
        _checker.IsThereAWinner(_game);
        
        //round counter
        _game.Round += 1;
        
        _logger.LogInformation("new symbol set");
        
        return RedirectToAction("Index");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}