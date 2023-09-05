namespace TikTakToe_Game.Models;

public class GameViewModel
{
    //constructor
    public GameViewModel(char[] firstLine, char[] secondLine, char[] thirdLine, int round, bool over)
    {
        FirstLine = firstLine;
        SecondLine = secondLine;
        ThirdLine = thirdLine;
        Round = round;
        Over = over;
    }
    /// <summary>
    /// represents in what we are currently in 
    /// </summary>
    public int Round { get; set; }
    
    /// <summary>
    /// defines if a X or O symbol are shown in line 1
    /// </summary>
    public char[] FirstLine { get; set; }
    
    /// <summary>
    /// defines if a X or O symbol are shown in line 2
    /// </summary>
    public char[] SecondLine { get; set; }
    
    /// <summary>
    /// defines if a X or O symbol are shown in line 3
    /// </summary>
    public char[] ThirdLine { get; set; }

    /// <summary>
    /// state of the game
    /// </summary>
    public bool Over { get; set; }

    /// <summary>
    /// is true when all fields are taken
    /// </summary>
    public bool Full { get; set; }
    
    public static GameViewModel NewGame()
    {
        return new GameViewModel(
            new char[3] { ' ', ' ', ' ' },
            new char[3] { ' ', ' ', ' ' },
            new char[3] { ' ', ' ', ' ' },
            1,
            false
            );
    }
}