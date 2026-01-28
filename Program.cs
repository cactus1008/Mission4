//Mission 4 Assignment
// Dawson Broadbent, Joaquin Elizalde, Michael Jones, Garrett Safsten

//Using Statement
using Mission4;
using System.Threading.Tasks;

//Variable declarations
bool gameOver = false;
int position = 0;
char player = 'X';
int turnNumber = 1;
char[] gameBoard = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
string tempPosition = "";
List<int> chosen = new List<int>();

//Declare and instantiate an instance of our class
TicTools tt = new TicTools();

// Welcome the user to the game
Console.WriteLine("Welcome to Tic-Tac-Toe!");
tt.PrintBoard(gameBoard);

// Game flow
do
{
    if (turnNumber % 2 == 1)
    {
        player = 'X';
    }
    else
    {
        player = 'O';
    }
    
    //Print Updated Game Board
    tt.PrintBoard(gameBoard);
    
    // Ask each player in turn for their choice and update the game board array
    Console.WriteLine($"Player {player}'s turn, choose a position:");
    tempPosition = Console.ReadLine();
    
    //Check for a valid selection
    bool isValid = int.TryParse(tempPosition, out position) && (position > 0) && (position < 10) && (!chosen.Contains(position));
    if(!isValid)
    {
        //Error message if invalid
        if (chosen.Contains(position))
        {
            Console.WriteLine("This position has already been chosen");
        }
        else
        {
            Console.WriteLine("Not a valid position. Please enter a valid integer");
        }
    }

    //Game Logic
    else
    {
        //Replace position with X or O based on player
        gameBoard[position - 1] = player; 
        chosen.Add(position);
        
        //Increment turn
        turnNumber++;
        
        //Check for winners
        tt.CheckWinner(gameBoard);
    }
} while (!gameOver);


/*
* 2) The supporting class (with whichever name you choose) will:
* Receive the “board” array from the driver class
* Contain a method that prints the board based on the information passed to it
    * Contain a method that receives the game board array as input and returns if there is a winner and who it was
    */
// Method signature #1
//public string PrintBoard(char[] boardArray);
{
    // Method implementation
}
// Method signature #2
//public string CheckWinner(char[] boardArray);
{
    // Method implementation
}