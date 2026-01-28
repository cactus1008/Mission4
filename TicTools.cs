using System;
using System.Collections.Generic;
using System.Text;

namespace Mission4
{
    internal class TicTools
    {

        // Method signature #1
        public static void PrintBoard(char[] position)
        {

            // This is the output of the tictac toe board
            Console.WriteLine(" ┌───┬───┬───┐");
            Console.WriteLine($" │ {position[0]} │ {position[1]} │ {position[2]} │");
            Console.WriteLine(" ├───┼───┼───┤");
            Console.WriteLine($" │ {position[3]} │ {position[4]} │ {position[5]} │");
            Console.WriteLine(" ├───┼───┼───┤");
            Console.WriteLine($" │ {position[6]} │ {position[7]} │ {position[8]} │");
            Console.WriteLine(" └───┴───┴───┘");  
        }
        // Method signature #2
        public (bool gameOver, string winner) CheckWinner(char[] boardArray)
        {
            // All possible winning combination indexes
            int[][] winCombos =
            {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 0, 3, 6 },
                new int[] { 1, 4, 7 },
                new int[] { 2, 5, 8 },
                new int[] { 0, 4, 8 },
                new int[] { 2, 4, 6 }
            };

            for (int i = 0; i < winCombos.Length; i++)
            {
                // Identifies one character in the combo
                // (if they are all identical it doesn't matter which one)
                char charToCheck = boardArray[winCombos[i][0]];

                // Checks to see if the items at the winning combo indexes are identical
                // Ex. If winCombos[2][1] = 7, check boardArray[7] for an X or O
                if (boardArray[winCombos[i][0]] == boardArray[winCombos[i][1]]
                    && boardArray[winCombos[i][1]] == boardArray[winCombos[i][2]])
                {
                    // Player 1 wins if the winning combo had all X's
                    if (charToCheck == 'X')
                    {
                        return (true, "1");
                    }
                    // Player 2 wins if the winning combo had all O's
                    if (charToCheck == 'O')
                    {
                        return (true, "2");
                    }
                }
            }

            // Looks for unclaimed areas on the board, returns a false if found
            for (int i = 0; i < boardArray.Length; i++)
            {
                if (boardArray[i] != 'X' && boardArray[i] != 'O')
                {
                    return (false, "");
                }
            }

            // If no winning combo was found and all areas are claimed
            return (true, "");
        }
    }
}
