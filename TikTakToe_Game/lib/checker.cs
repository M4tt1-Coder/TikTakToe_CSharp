using TikTakToe_Game.Models;

namespace TikTakToe_Game.lib;

public class checker
{
    /// <summary>
    /// Looks if a player won the game with a three repetition
    /// X   
    /// 0 X 
    /// 0   x
    /// like these ...
    /// replaces the fields with a winning number for X = 4 or O = 5
    /// </summary>
    /// <param name="game">represents the current game; to see more look in declaration</param>
    /// <returns>overwritten game if some player won</returns>
    public GameViewModel IsThereAWinner(GameViewModel game)
    {
        //1 = X AND 2 = O
        int[] symbolIDs = { 1, 2 };
        //TODO - check all possible winning situation

        return game;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <param name="pos3"></param>
    /// <param name="pos4"></param>
    /// <param name="pos5"></param>
    /// <param name="symbolId"></param>
    private void VerticalLine(int pos1, int pos2, int pos3, int pos4, int pos5, int symbolId)
    {
        //checking for this ...
        //X 
        // X
        //  X
        //...layout
        if (pos1 == symbolId && pos3 == symbolId && pos5 == symbolId)
        {
            if (symbolId == 1)
            {
                pos1 = 4;
                pos3 = 4;
                pos5 = 4;
            }
            else
            {
                pos1 = 5;
                pos3 = 5;
                pos5 = 5;
            }            
        }
        
        //checking for this ...
        //  X 
        // X
        //X
        //...layout
        if (pos2 == symbolId && pos3 == symbolId && pos4 == symbolId)
        {
            if (symbolId == 1)
            {
                pos2 = 4;
                pos3 = 4;
                pos4 = 4;
            }
            else
            {
                pos2 = 5;
                pos3 = 5;
                pos4 = 5;
            }            
        }
    }
    
    /// <summary>
    /// checks if a player won a horizontal line
    /// </summary>
    /// <param name="line">1. || 2. || 3. line</param>
    /// <param name="symbolId">if it checks for X || O</param>
    /// <returns></returns>
    private int[] HorizontalLine(int[] line, int symbolId)
    {
        if (line[0] == symbolId && line[1] == symbolId && line[2] == symbolId)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (symbolId == 1)
                {
                    line[i] = 4;
                }
                else
                {
                    line[i] = 5;
                }
            }
        }

        return line;
    }
}