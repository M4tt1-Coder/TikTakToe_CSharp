using TikTakToe_Game.Models;

namespace TikTakToe_Game.lib;

//layout for txt: 0,0,0/0,0,0/0,0,0/1

public static class TextFileNode
{
    /// <summary>
    /// Represents the directory path to the storage file
    /// </summary>
    /// <returns>path to txt-file</returns>
    private static string Path()
    {
        return "./lib/GameStorage.txt";
    }

    /// <summary>
    /// - checks if the file exists, if not then it creates a new one in the path 
    /// - loads all lines stored in the text file -> fails after three attemps to access the file
    /// </summary>
    /// <returns>list of all lines in a file</returns>
    private static List<string> LoadContent()
    {
        if(!File.Exists(Path()))
        {
            File.Create(Path());
        }
        //load lines
        int tries = 3;

        //-> if empty save default case
        if (File.ReadAllText(Path()).Length == 0)
        {
            File.WriteAllLines(Path(), new List<string>() {" , , | , , | , , |1|false|false"});
        }
        
        for (var i = 0; i < tries; i++)
        {
            try
            {
                return File.ReadAllLines(Path()).ToList();
            }
            catch(IOException e)
            {
                Thread.Sleep(500);
            }
        }

        return new List<string>();
    }
    
    /// <summary>
    /// gets all lines in text file
    /// creates new game instance
    /// </summary>
    /// <returns>returns the game</returns>
    public static GameViewModel GetGame()
    {
        List<string> lines = LoadContent();
        //create new game model
        List<GameViewModel> games = new List<GameViewModel>();
        
        foreach (var line in lines)
        {
            GameViewModel game = GameViewModel.NewGame();

            string[] columns = line.Split('|');
            
            game.FirstLine = GetLine(columns[0]);
            game.SecondLine = GetLine(columns[1]);
            game.ThirdLine = GetLine(columns[2]);
            game.Round = Convert.ToInt32(columns[3]);
            game.Over = Convert.ToBoolean(columns[4]);
            game.Full = Convert.ToBoolean(columns[5]);
            
            games.Add(game);
        }
        //return
        return games[0];
    }

    /// <summary>
    /// deletes all contents of the storage text file
    /// </summary>
    public static void ResetGame()
    {
        File.WriteAllText(Path(), String.Empty);
    }
    
    public static void SaveGame(GameViewModel game)
    {
        string line = $"{ConvertLine(game.FirstLine)}|" +
                      $"{ConvertLine(game.SecondLine)}|" +
                      $"{ConvertLine(game.ThirdLine)}|" +
                      $"{game.Round.ToString()}|" +
                      $"{game.Over.ToString()}|" +
                      $"{game.Full.ToString()}";

        List<string> content = new List<string>() { line };
        
        File.WriteAllLines(Path(), content);
    }

    private static string ConvertLine(char[] line)
    {
        string output = "";

        if (line.Length == 0)
        {
            return "";
        }

        foreach (var c in line)
        {
            output += $"{c},";
        }

        output = output.Substring(0, output.Length - 1);

        return output;
    }
    
    private static char[] GetLine(string line)
    {
        List<char> l = new List<char>();
        
        foreach (var c in line)
        {
            if (c == ' ' || c == 'X' || c == 'O' || c == '❌' || c == '⭕')
            {
                l.Add(c);
            }
        }

        return l.ToArray();
    }
}

