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
        foreach (var symbolID in symbolIDs)
        {
            //first line check
            HorizontalLine(game.FirstLine, symbolID);
            
            //second line
            HorizontalLine(game.SecondLine, symbolID);
            
            //third line
            HorizontalLine(game.ThirdLine, symbolID);
            
            //diagonal 
            DiagonalLine(game.FirstLine[0],
                game.FirstLine[2],
                game.SecondLine[1],
                game.ThirdLine[0],
                game.ThirdLine[2],
                symbolID);
            
            //
        }
        //TODO - check all possible winning situation

        return game;
    }

    private void VerticalLine(int[] first, int[] second, int[] third, int symbolId)
    {
        //the case:
        //X _ _
        //X _ _ 
        //X _ _
        if (first[0] == symbolId && second[0] == symbolId && third[0] == symbolId)
        {
            if (symbolId == 1)
            {
                first[0] = 4;
                second[0] = 4;
                third[0] = 4;
            }
            else
            {
                first[0] = 5;
                second[0] = 5;
                third[0] = 5;
            }
        }
        
        //the case:
        //_ X _
        //_ X _ 
        //_ X _
        if (first[1] == symbolId && second[1] == symbolId && third[1] == symbolId)
        {
            if (symbolId == 1)
            {
                first[0] = 4;
                second[0] = 4;
                third[0] = 4;
            }
            else
            {
                first[0] = 5;
                second[0] = 5;
                third[0] = 5;
            }
        }
        
        //the case:
        //_ _ X
        //_ _ X
        //_ _ X
        if (first[2] == symbolId && second[2] == symbolId && third[2] == symbolId)
        {
            if (symbolId == 1)
            {
                first[0] = 4;
                second[0] = 4;
                third[0] = 4;
            }
            else
            {
                first[0] = 5;
                second[0] = 5;
                third[0] = 5;
            }
        }
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
    private void DiagonalLine(int pos1, int pos2, int pos3, int pos4, int pos5, int symbolId)
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