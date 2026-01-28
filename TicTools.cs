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
        public string CheckWinner(string[] boardArray);
        {
            // Method implementation
        }
    }
}
