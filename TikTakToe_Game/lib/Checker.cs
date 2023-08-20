using TikTakToe_Game.Models;

namespace TikTakToe_Game.lib;

public class Checker
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
        char[] symbolIDs = { 'X', 'O' };
        foreach (var symbolId in symbolIDs)
        {
            //first line check
            HorizontalLine(game.FirstLine, symbolId, game.Over);
            
            //second line
            HorizontalLine(game.SecondLine, symbolId, game.Over);
            
            //third line
            HorizontalLine(game.ThirdLine, symbolId, game.Over);
            
            //diagonal 
            DiagonalLine(game.FirstLine[0],
                game.FirstLine[2],
                game.SecondLine[1],
                game.ThirdLine[0],
                game.ThirdLine[2],
                symbolId,
                game.Over
                );
            
            //vertical
            VerticalLine(
                game.FirstLine,
                game.SecondLine,
                game.ThirdLine,
                symbolId,
                game.Over
                );
        }
        
        return game;
    }

    private void VerticalLine(char[] first, char[] second, char[] third, char symbolId, bool over)
    {
        //the case:
        //X _ _
        //X _ _ 
        //X _ _
        if (first[0] == symbolId && second[0] == symbolId && third[0] == symbolId)
        {
            if (symbolId == 'X')
            {
                first[0] = '❌';
                second[0] = '❌';
                third[0] = '❌';
            }
            else
            {
                first[0] = '⭕';
                second[0] = '⭕';
                third[0] = '⭕';
            }

            over = true;
        }
        
        //the case:
        //_ X _
        //_ X _ 
        //_ X _
        if (first[1] == symbolId && second[1] == symbolId && third[1] == symbolId)
        {
            if (symbolId == 'X')
            {
                first[0] = '❌';
                second[0] = '❌';
                third[0] = '❌';
            }
            else
            {
                first[0] = '⭕';
                second[0] = '⭕';
                third[0] = '⭕';
            }

            over = true;
        }
        
        //the case:
        //_ _ X
        //_ _ X
        //_ _ X
        if (first[2] == symbolId && second[2] == symbolId && third[2] == symbolId)
        {
            if (symbolId == 'X')
            {
                first[0] = '❌';
                second[0] = '❌';
                third[0] = '❌';
            }
            else
            {
                first[0] = '⭕';
                second[0] = '⭕';
                third[0] = '⭕';
            }

            over = true;
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
    private void DiagonalLine(char pos1, char pos2, char pos3, char pos4, char pos5, char symbolId, bool over)
    {
        //checking for this ...
        //X 
        // X
        //  X
        //...layout
        if (pos1 == symbolId && pos3 == symbolId && pos5 == symbolId)
        {
            if (symbolId == 'X')
            {
                pos1 = '❌';
                pos3 = '❌';
                pos5 = '❌';
            }
            else
            {
                pos1 = '⭕';
                pos3 = '⭕';
                pos5 = '⭕';
            }

            over = true;
        }
        
        //checking for this ...
        //  X 
        // X
        //X
        //...layout
        if (pos2 == symbolId && pos3 == symbolId && pos4 == symbolId)
        {
            if (symbolId == 'X')
            {
                pos2 = '❌';
                pos3 = '❌';
                pos4 = '❌';
            }
            else
            {
                pos2 = '⭕';
                pos3 = '⭕';
                pos4 = '⭕';
            }

            over = true;
        }
    }
    
    /// <summary>
    /// checks if a player won a horizontal line
    /// </summary>
    /// <param name="line">1. || 2. || 3. line</param>
    /// <param name="symbolId">if it checks for X || O</param>
    /// <returns></returns>
    private char[] HorizontalLine(char[] line, char symbolId, bool over)
    {
        if (line[0] == symbolId && line[1] == symbolId && line[2] == symbolId)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (symbolId == 'X')
                {
                    line[i] = '❌';
                }
                else
                {
                    line[i] = '⭕';
                }
            }

            over = true;
        }

        return line;
    }
}