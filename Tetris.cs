using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Program
{

    //TODO: https://www.youtube.com/watch?v=0-WOuN0qqI0 finish lesson if you want 2:32:56
    // video lesson from telerik academy - Niki - https://www.youtube.com/watch?v=0-WOuN0qqI0
    static void PlaySound()
    {
        const int soundLength = 100;
        Console.Beep(1320, soundLength*4);
        Console.Beep(990, soundLength*2);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(1188, soundLength * 2);
        Console.Beep(1320, soundLength);
        Console.Beep(1188, soundLength );
        Console.Beep(1056, soundLength * 2);
        Console.Beep(990, soundLength * 2);
        Console.Beep(880, soundLength * 4);
        Console.Beep(880, soundLength * 2);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(1320, soundLength * 4);
        Console.Beep(1188, soundLength * 2);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(990, soundLength*6) ;
        Console.Beep(1056, soundLength * 2);
        Console.Beep(1188, soundLength * 4);
        Console.Beep(1320, soundLength * 4);
        Console.Beep(1056, soundLength * 4);
        Console.Beep(880, soundLength * 4);
        Console.Beep(880, soundLength * 4);
        Thread.Sleep(soundLength * 2);
        Console.Beep(1188, soundLength * 4);
        Console.Beep(1408, soundLength * 2);
        Console.Beep(1760, soundLength * 4);
        Console.Beep(1584, soundLength * 2);
        Console.Beep(1408, soundLength * 2);
        Console.Beep(1320, soundLength * 6);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(1320, soundLength * 4);
        Console.Beep(1188, soundLength * 2);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(990, soundLength * 4);
        Console.Beep(990, soundLength * 2);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(1188, soundLength * 4);
        Console.Beep(1320, soundLength * 4);
        Console.Beep(1056, soundLength * 4);
        Console.Beep(880, soundLength * 4);
        Console.Beep(880, soundLength * 4);
        Thread.Sleep(soundLength * 4);
        Console.Beep(1320, soundLength * 4);
        Console.Beep(990, soundLength * 2);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(1188, soundLength * 2);
        Console.Beep(1320, soundLength);
        Console.Beep(1188, soundLength );
        Console.Beep(1056, soundLength * 2);
        Console.Beep(990, soundLength * 2);
        Console.Beep(880, soundLength *4) ;
        Console.Beep(880, soundLength * 2) ;
        Console.Beep(1056, soundLength * 2);
        Console.Beep(1320, soundLength * 4);
        Console.Beep(1188, soundLength * 2);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(990, soundLength * 6) ;
        Console.Beep(1056, soundLength * 2);
        Console.Beep(1188, soundLength * 4);
        Console.Beep(1320, soundLength * 4);
        Console.Beep(1056, soundLength * 4);
        Console.Beep(880, soundLength * 4);
        Console.Beep(880, soundLength * 4);
        Thread.Sleep(soundLength * 2);
        Console.Beep(1188, soundLength * 4);
        Console.Beep(1408, soundLength * 2);
        Console.Beep(1760, soundLength * 4);
        Console.Beep(1584, soundLength * 2);
        Console.Beep(1408, soundLength * 2);
        Console.Beep(1320, soundLength * 6);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(1320, soundLength * 4);
        Console.Beep(1188, soundLength * 2);
        Console.Beep(1056, soundLength * 2);
        Console.Beep(990, soundLength * 4);
        Console.Beep(990, soundLength * 2);
        Console.Beep(1056, soundLength * 4);
        Console.Beep(1188, soundLength * 4);
        Console.Beep(1320, soundLength * 4);
        Console.Beep(1056, soundLength * 4);
        Console.Beep(880, soundLength * 4);
        Console.Beep(880, soundLength * 4);
        Thread.Sleep(soundLength * 4);
        Console.Beep(660, soundLength * 8);
        Console.Beep(528, soundLength * 8);
        Console.Beep(594, soundLength * 8);
        Console.Beep(495, soundLength * 8);
        Console.Beep(528, soundLength * 8);
        Console.Beep(440, soundLength * 8);
        Console.Beep(419, soundLength * 8);
        Console.Beep(495, soundLength * 8);
        Console.Beep(660, soundLength * 8);
        Console.Beep(528, soundLength * 8);
        Console.Beep(594, soundLength * 8);
        Console.Beep(495, soundLength * 8);
        Console.Beep(528, soundLength * 4);
        Console.Beep(660, soundLength * 4);
        Console.Beep(880, soundLength * 8);
        Console.Beep(838, soundLength * 8);
        Console.Beep(660, soundLength * 8);
        Console.Beep(528, soundLength * 8);
        Console.Beep(594, soundLength * 8);
        Console.Beep(495, soundLength * 8);
        Console.Beep(528, soundLength * 8);
        Console.Beep(440, soundLength * 8);
        Console.Beep(419, soundLength * 8);
        Console.Beep(495, soundLength * 8);
        Console.Beep(660, soundLength * 8);
        Console.Beep(528, soundLength * 8);
        Console.Beep(594, soundLength * 8);
        Console.Beep(495, soundLength * 8);
        Console.Beep(528, soundLength * 4);
        Console.Beep(660, soundLength *4);
        Console.Beep(880, soundLength * 8);
        Console.Beep(838, soundLength * 16);
    } // tetris song => find it in internet

    static void Print(int row, int col, object data) // print ot the screen
    {
        Console.SetCursorPosition(col, row);// row col
        Console.Write(data);
    }


    const int TetrisWidth = 10; // tetris width
    const int TetrisHeight = 16; // tetris height
    const int InfoPanelWidth = 10; // info panel with
    const int GameWidth = TetrisWidth + InfoPanelWidth + 3;//23; // game width
    const int GameHeight = TetrisHeight + 2; //18; // game height
    const char BorderChar = (char)219;
    static int Score = 1; // player's score
    static int Level = 1; // player's level 1 : 9
    #region Figures 
    static bool[][,] Figures= new bool[7][,] // array with 7 elements that has dual array in it
    {
        new bool[,] // I
        {
            {true, true, true, true}
        },
        new bool[,] // J
        {
            {true, true, true},
            {false, false, true}
        },
        new bool[,] // L
        {
            {true, true, true},
            {true, false, false}
        },
        new bool[,] // O
        {
            {true, true},
            {true, true}
        },
        new bool[,] //S
        {
            {false, true, true},
            {true, true, false}
        },
        new bool[,] //T
        {
            {true, true, true},
            {false, true, false}
        },
        new bool[,] //Z
        {
            {true, true, false},
            {false, true, true}
        }
    };
    #endregion
    static bool[,] currentFigure; // current figure
    static int currentFigureRow = 0; // current figure row equals one at the begining of the game
    static int currentFigureCol = 4; // current figure col equals four at the begining of the game
    static bool[,] nextFigure; // next figure
    static Random random = new Random(); // object random
    static bool[,] gameState = new bool[TetrisHeight, TetrisWidth]; // array to save game state
    


    static void PrintBorders()
    {
        for (int col = 0; col < GameWidth; col++)
        {
            Print(0, col, BorderChar); // upper border
            Print(GameHeight-1, col, BorderChar); // lower border
        }
        for (int row = 0; row < GameHeight; row++)
        {
            Print(row, 0, BorderChar); // left border
            Print(row, TetrisWidth + 1, BorderChar); // tetris right border
            Print(row, TetrisWidth + 1 + InfoPanelWidth + 1, BorderChar);
        }
    }

    static void PrintInfoPanel() // print the info in the info panel   
    {
        Print(1, TetrisWidth + 4,"Next: "); // prints word Next
        for (int i = 2; i <= 5; i++) // cleans next field
        {
            Print(i, TetrisWidth + 2, "         ");
        }
        PrintFigure(nextFigure, 2, TetrisWidth + 5); // Prints next random figure
        Print(6, TetrisWidth + 4, "Score: "); // prints Score 
        int scoreStartPossition = InfoPanelWidth / 2 - (Score.ToString().Length - 1) / 2; // position to print the score number calculations 1.
        scoreStartPossition += TetrisWidth + 2; // position to print the score number calculations 2.
        Print(7, scoreStartPossition -1, Score); // prints score number
        Print(9, TetrisWidth + 4, "Level: "); // level
        Print(10, TetrisWidth + 6, Level); // prints level number
        Print(12, TetrisWidth + 3, "Controls" ); // controls 
        Print(14, TetrisWidth + 2, "   < >   ");
        Print(15, TetrisWidth + 2, "    v   ");
        Print(16, TetrisWidth + 2, "  Space   ");

    }

    static void StartNewGame() // takes random figure
    {
        currentFigure = Figures[random.Next(0, Figures.Length)];
        nextFigure = Figures[random.Next(0, Figures.Length)];
    }

    static void PrintFigure(bool[,] figure, int row, int col) // prints figure on the screen
    {
        for (int x = 0; x < figure.GetLength(0); x++)
        {
            for (int y = 0; y < figure.GetLength(1); y++)
            {
                if (figure[x, y] == true)
                {
                    Print(row + x, col + y, '*');
                }
            }
        }
    }

    static void PrintGameField() // Clear spaces where we don't have e drawing
    {
        for(int row = 1; row <=TetrisHeight; row++)
        {
            for (int col = 1; col < TetrisWidth; col++)
            {
                if (gameState[row - 1, col - 1] == true) //if we have figure print it
                {
                    Print(row, col, '*');
                }
                else // else don't print it
                {
                    Print(row, col, ' ');
                }
            }
        }
    }

    static bool CollisionDetection() // check collisium
    {
        var currentFigureLowerstRow = currentFigureRow + currentFigure.GetLength(0);
        if (currentFigureLowerstRow > TetrisHeight) // check for tetris heigth
        {
            return true;
        }
         // colide existing figure
        for(int figRow = 0; figRow < currentFigure.GetLength(0); figRow++)
        {
            for (int figCol = 0; figCol < currentFigure.GetLength(1); figCol++)
            {
                var row = currentFigureRow + figRow;
                var col = currentFigureCol - 1 + figCol;

                if (row < 0)
                {
                    continue;
                }

                if(gameState[row, col] == true && currentFigure[figRow,figCol] == true)
                {
                    return true;
                }
            }
        }

        return false;
    }

    static void PlaceCurrentFigure()
    {
        for (int figRow = 0; figRow < currentFigure.GetLength(0); figRow++)
        {
            for (int figCol = 0; figCol < currentFigure.GetLength(1); figCol++)
            {
                var row =currentFigureRow - 1 + figRow;
                var col = currentFigureCol - 1 + figCol;

                if (currentFigure[figRow, figCol])
                {
                    gameState[row, col] = true;
                }
            }
        }
    }

    static int CheckForFullLines()
    {
        int linesRemoved = 0;

        for (int row = 0; row < gameState.GetLength(0); row++)
        {
            bool isFullLine = true;
            for (int col = 0; col < gameState.GetLength(1); col++)
            {
                if (gameState[row, col] == false)
                {
                    isFullLine = false;
                    break;
                }
            }

            if (isFullLine)
            {
                for (int nextLine = gameState.GetLength(0) - 2; nextLine >= 0 ; nextLine--)
                {
                    //gameState[nextLine - 1] = gameState[nextLine];
                    if (row < 0)
                    {
                        continue;
                    }
                    for (int colFromNextLine = 0; colFromNextLine < gameState.GetLength(1); colFromNextLine++)
                    {
                        gameState[nextLine + 1, colFromNextLine] = gameState[nextLine, colFromNextLine];
                    }
                }

                for (int colLastLine = 0; colLastLine < gameState.GetLength(1); colLastLine++)
                {
                    gameState[0, colLastLine] = false;
                }

                linesRemoved++;
            }
        }
        return linesRemoved;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.GetEncoding("windows-1252");//change encoding
        Console.CursorVisible = false; // remove the cursor
        Console.Title = "Tetris"; // change window title
        Console.WindowWidth = GameWidth; // window width .. write it before consolebuffer
        Console.BufferWidth = GameWidth; // console bufer width
        Console.WindowHeight = GameHeight +1; // setting window height 
        Console.BufferHeight = GameHeight + 1; // seting buffer heigt and removing scrollbar
        PrintBorders(); // Prints the borsders of the game
        //PrintInfoPanel(); // Prints the infto in the info panel -> moved to while(true) game logic
        StartNewGame();
        //PrintFigure(currentFigure, 1, 4); // Prints random figure -> moved to while(true) game logic
        //PrintFigure(nextFigure, 2, TetrisWidth + 5); // Prints next random figure -> moved to while(true) game logic


        // multithreading
        Task.Run(() =>
            {
                while (true)
                {
                    //PlaySound();// this code is runnig with the other code
                }
            });

        
        // multithreading or sort of ... 
        while (true) 
        {

            if (Console.KeyAvailable) // buttons movement
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (currentFigureCol > 1)
                    {
                        currentFigureCol--;
                    }
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (currentFigureCol + currentFigure.GetLength(1)  < TetrisWidth)
                    {
                        currentFigureCol++;
                    }
                }
            }


            if (CollisionDetection()) // if has a collsion on the bottom
            {
                // current = next
                // generate new figure
                // set figure row, col
                PlaceCurrentFigure();
                int removedLines = CheckForFullLines();
                //TODO: Add to score
                currentFigure = nextFigure;
                nextFigure = Figures[random.Next(0, Figures.Length)];
                currentFigureRow = 1;
                currentFigureCol = 4;
                
            }
            else
            {
                currentFigureRow++;
            }

            PrintInfoPanel(); // Prints the infto in the info panel
            PrintGameField();
            PrintFigure(currentFigure, currentFigureRow, currentFigureCol); // Prints random figure
            //not here PrintFigure(nextFigure, 2, TetrisWidth + 5); // Prints next random figure

            Thread.Sleep(200);
        }
        Console.WriteLine();
    }
}

