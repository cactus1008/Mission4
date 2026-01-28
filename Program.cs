// Method Signatures:

/* 
 * Welcome the user to the game
 * Create a game board array to store the players’ choices
 * Ask each player in turn for their choice and update the game board array
 * Print the board by calling the method in the supporting class
 * Check for a winner by calling the method in the supporting class, and notify the players
 *      when a win has occurred and which player won the game
 *      
 * 2) The supporting class (with whichever name you choose) will:
 * Receive the “board” array from the driver class
 * Contain a method that prints the board based on the information passed to it
 * Contain a method that receives the game board array as input and returns if there is a winner and who it was
 */

// Welcome the user to the game
using Mission4;
using System.Threading.Tasks;

bool gameOver = false;
int position = 0;
char[] gameBoard = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
string tempPosition = "";

TicTools tt = new TicTools();

Console.WriteLine("Welcome to Tic-Tac-Toe!");

// Game flow
do
{
    tt.PrintBoard(gameBoard);
    // Ask each player in turn for their choice and update the game board array
    Console.WriteLine("Player 1 (X's), choose a position:");
    tempPosition = Console.ReadLine();
    if(int.TryParse(tempPosition, out position) && (position > 0) && (position < 10))
    {
        gameBoard[position - 1] = 'X';
    }
    else
    {
        Console.WriteLine("Not a valid position. Please enter a valid integer");
    }


    // After player 2:

    tt.PrintBoard(gameBoard);
    tt.CheckWinner(gameBoard);
} while (!gameOver);

// Method signature #1

// Method signature #2
public string CheckWinner(char[] boardArray);
{
    // Method implementation
}