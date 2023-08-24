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
            HorizontalLine(game.FirstLine, symbolId, game);
            
            //second line
            HorizontalLine(game.SecondLine, symbolId, game);
            
            //third line
            HorizontalLine(game.ThirdLine, symbolId, game);
            
            //diagonal 
            DiagonalLine(game,
                symbolId
                );
            
            //vertical
            VerticalLine(
                game.FirstLine,
                game.SecondLine,
                game.ThirdLine,
                symbolId,
                game
                );
        }
        lib.TextFileNode.SaveGame(game);
        return game;
    }

    private void VerticalLine(char[] first, char[] second, char[] third, char symbolId, GameViewModel game)
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

            game.Over = true;
        }
        
        //the case:
        //_ X _
        //_ X _ 
        //_ X _
        if (first[1] == symbolId && second[1] == symbolId && third[1] == symbolId)
        {
            if (symbolId == 'X')
            {
                first[1] = '❌';
                second[1] = '❌';
                third[1] = '❌';
            }
            else
            {
                first[1] = '⭕';
                second[1] = '⭕';
                third[1] = '⭕';
            }
    
            game.Over = true;
        }
        
        //the case:
        //_ _ X
        //_ _ X
        //_ _ X
        if (first[2] == symbolId && second[2] == symbolId && third[2] == symbolId)
        {
            if (symbolId == 'X')
            {
                first[2] = '❌';
                second[2] = '❌';
                third[2] = '❌';
            }
            else
            {
                first[2] = '⭕';
                second[2] = '⭕';
                third[2] = '⭕';
            }

            game.Over = true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="game.FirstLine[0]"></param>
    /// <param name="game.FirstLine[2]"></param>
    /// <param name="game.SecondLine[1]"></param>
    /// <param name="game.ThirdLine[0]"></param>
    /// <param name="game.ThirdLine[2]"></param>
    /// <param name="game"></param>
    /// <param name="symbolId"></param>
    /// <param name="over"></param>
    private void DiagonalLine(GameViewModel game, char symbolId)
    {
        //checking for this ...
        //X 
        // X
        //  X
        //...layout
        if (game.FirstLine[0] == symbolId && game.SecondLine[1] == symbolId && game.ThirdLine[2] == symbolId)
        {
            if (symbolId == 'X')
            {
                game.FirstLine[0] = '❌';
                game.SecondLine[1] = '❌';
                game.ThirdLine[2] = '❌';
            }
            else
            {
                game.FirstLine[0] = '⭕';
                game.SecondLine[1] = '⭕';
                game.ThirdLine[2] = '⭕';
            }

            game.Over = true;
        }
        
        //checking for this ...
        //  X 
        // X
        //X
        //...layout
        if (game.FirstLine[2] == symbolId && game.SecondLine[1] == symbolId && game.ThirdLine[0] == symbolId)
        {
            if (symbolId == 'X')
            {
                game.FirstLine[2] = '❌';
                game.SecondLine[1] = '❌';
                game.ThirdLine[0] = '❌';
            }
            else
            {
                game.FirstLine[2] = '⭕';
                game.SecondLine[1] = '⭕';
                game.ThirdLine[0] = '⭕';
            }

            game.Over = true;
        }
    }
    
    /// <summary>
    /// checks if a player won a horizontal line
    /// </summary>
    /// <param name="line">1. || 2. || 3. line</param>
    /// <param name="symbolId">if it checks for X || O</param>
    /// <returns></returns>
    private char[] HorizontalLine(char[] line, char symbolId, GameViewModel game)
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

            game.Over = true;
        }

        return line;
    }
}