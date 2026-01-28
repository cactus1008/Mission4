using System;
using System.Collections.Generic;
using System.Text;

namespace Mission4
{
    internal class TicTools
    {

        // Method signature #1
        public string[9] PrintBoard(string[] boardArray, int position, bool xo);
        {
            // Method implementation
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
                char charToCheck = boardArray[winCombos[i][0]];
                // Checks to see if the items at the winning combo indexes are identical
                if (boardArray[winCombos[i][0]] == boardArray[winCombos[i][1]]
                    && boardArray[winCombos[i][1]] == boardArray[winCombos[i][2]])
                {
                    if (charToCheck == 'X')
                    {
                        return (true, "1");
                    }
                    if (charToCheck == 'O')
                    {
                        return (true, "2");
                    }
                }
            }

            for (int i = 0; i < boardArray.Length; i++)
            {
                if (boardArray[i] != 'X' && boardArray[i] != 'O')
                {
                    return (false, "");
                }
            }

            return (true, "");
        }
    }
}
