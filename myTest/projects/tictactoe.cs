using System;

namespace Hello_world
{
    class TicTacToe
    {
        //X for player 1 and O to player 2
        static char figure;

        /* the variable times will increase every time we call the Check method, if it's divisible by 2 and it's not 1,
         it means that the currentPlayer is 2 because 'times' is 1 when player 1 starts the game */
        static int times;
        static int currentPlayer;
        static char currentMove;

        //This is used inside the Check method to know if the player has entered the expected input
        static bool check;

        //While this remains true, the game will continuously run
        static bool startOver = true;

        /* In order to know if a tie occurs, we can make a turns counter, so if it reaches 9, which is the max amount of turns,
        then no more moves will be possible */
        static int counter;

        //We create a shape that's going to be changing along the game
        static char[,] shape =
        {
            {'7','8','9'},
            {'4','5','6'},
            {'1','2','3'}
        };

        //We'll need to restart the shape at some point, so we use this method
        static char[,] MakeDefault(char[,] shape)
        {
            shape = new char[3, 3]
            {
                {'7','8','9'},
                {'4','5','6'},
                {'1','2','3'}
            };
            return shape;
        }

        //Prints out the current shape for the game
        static void Print(char[,] shape)
        {
            Console.WriteLine("\n  {0}  |  {1}  |  {2}\n-----------------\n  {3}  |  {4}  |  {5}\n-----------------\n  {6}  |  {7}  |  {8}\n",
                 shape[0, 0], shape[0, 1], shape[0, 2], shape[1, 0], shape[1, 1], shape[1, 2],
                 shape[2, 0], shape[2, 1], shape[2, 2]);
        }

        /*It analysis which player is currently playing, checks that the input is of one character only and returns X or O
        depending on the current player */
        static char Check()
        {
            times +=  1;
            check = false;

            if (times % 2 == 0 && times != 1) currentPlayer = 2;
            else currentPlayer = 1;

            while (!check)
            {
                Console.WriteLine("Player {0}, select the position you wish to draw by entering the corresponding number:\n", currentPlayer);
                string rawPlayerMove = Console.ReadLine();

                //We check that the player entered only 1 character
                check = char.TryParse(rawPlayerMove, out currentMove);

                if (!check)
                {
                    Console.Clear();
                    Print(shape);
                }
            }

            if (currentPlayer == 1) return 'X';
            else return 'O';
        }

        //Modifies the current shape according to the position requested by the player
        static char[,] Make(char[,] currentShape, char playerMove)
        {
            switch (playerMove)
            {
                case '1':
                    currentShape[2, 0] = figure;
                    break;

                case '2':
                    currentShape[2, 1] = figure;
                    break;

                case '3':
                    currentShape[2, 2] = figure;
                    break;

                case '4':
                    currentShape[1, 0] = figure;
                    break;

                case '5':
                    currentShape[1, 1] = figure;
                    break;

                case '6':
                    currentShape[1, 2] = figure;
                    break;

                case '7':
                    currentShape[0, 0] = figure;
                    break;

                case '8':
                    currentShape[0, 1] = figure;
                    break;

                case '9':
                    currentShape[0, 2] = figure;
                    break;
            }
            return currentShape;
        }
        
        //This will be looking for a victory pattern in the shape and return true when found
        static bool WinOrNot(char[,] currentShape)
        {
            //Looks for the horizontal victory pattern
            for (int i = 0; i < currentShape.GetLength(0); i++)
                if (currentShape[i,0] == currentShape[i, 1] && currentShape[i, 0] == currentShape[i, 2])
                {
                    return true;
                }

            //Looks for the vertical victory pattern
            for (int i = 0; i < currentShape.GetLength(0); i++)
            {
                if (currentShape[0, i] == currentShape[1, i] && currentShape[0, i] == currentShape[2, i])
                {
                    return true;
                }
            }

            //Both of these will look for the two diagonal patterns
            if (currentShape[0, 0] == currentShape[1, 1] && currentShape[0, 0] == currentShape[2, 2]) return true;

            if (currentShape[0, 2] == currentShape[1, 1] && currentShape[0, 2] == currentShape[2, 0]) return true;

            //If any victory pattern is found, it'll return false
            return false;
        }
        
        static void Main(string[] args)
        {
            while (startOver)
            {
                Console.Clear();

                //When Victory or Tie occurs, we set all to default to restart the game
                if (WinOrNot(shape))
                {
                    Print(shape);
                    counter = 0;
                    times = 0;
                    shape = MakeDefault(shape);
                    if (currentPlayer == 1)
                    {
                        Console.WriteLine("Player 1 has won\n\nPress ENTER to play again.");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 has won\n\nPress ENTER to play again.");
                    }
                    Console.Read();
                    Console.Clear();
                }
                else if (counter == 9)
                {
                    Print(shape);
                    counter = 0;
                    times = 0;
                    shape = MakeDefault(shape);
                    Console.WriteLine("TIE\n\nNone of the players managed to get the victory.\n\nPress ENTER to play again.");
                    Console.Read();
                    Console.Clear();
                }

                Print(shape);
                figure = Check();
                shape = Make(shape, currentMove);
                counter++;
            }       
        }
    }
}
