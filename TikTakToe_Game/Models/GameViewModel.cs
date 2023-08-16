namespace TikTakToe_Game.Models;

public class GameViewModel
{
    //constructor
    public GameViewModel(char[] firstLine, char[] secondLine, char[] thirdLine, int round)
    {
        FirstLine = firstLine;
        SecondLine = secondLine;
        ThirdLine = thirdLine;
        Round = round;
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
}