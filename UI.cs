using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Othelo
{
    class UI
    {
        public class UIGame
        {
            private bool m_IsQuit = true;
            public void RunMenu()
            {
                Console.WriteLine("Hello! Welcome to Othello game");
                Console.WriteLine("===============================");
                Console.WriteLine("Please Enter name of player 1: ");
                Player player1 = new Player(Console.ReadLine(),"X");
                Console.WriteLine("Press P for two players game or C to play against the computer");
                string PlayerChoose = Console.ReadLine();

                Console.WriteLine("Please choose the size of the board: press 6 for 6x6 , press 8 for 8x8:");
                int ChosenSize = int.Parse(Console.ReadLine());
                Game NewGame = new Game(ChosenSize, PlayerChoose);
                Console.WriteLine("Please Enter the first player name: ");
                NewGame.AddPlayer(0, Console.ReadLine(), "X");

                if (PlayerChoose == "P")
                {    
                    Console.WriteLine("Please Enter the second player name: ");
                    NewGame.AddPlayer(1, Console.ReadLine(), "O");                    
                }
                else
                {
                    NewGame.AddPlayer(1, "Computer" , "O");
                }
            }

            public void StartGame()
            {


            }
          /*  public void StartGame1()
            {
                this.m_boardGame(askForBoardSize());
                this.m_Players[0] = addPlayer();
                this.m_stateOfGame = UI.askForState();
                this.m_endOfGame = false;
                if (m_stateOfGame)
                {
                    this.m_Players[1] = UI.addPlayer();
                }
                else
                {
                    this.m_Players[1] = UI.addComputerPlayer();
                }

                UIBoard.BuildBoard(m_boardGame);

                while (!m_endOfGame)
                {
                    m_Players[0].MakeAMove();
                    Ex02.ConsoleUtils.Screen.Clear();
                    m_boardGame.printBoard();

                    if (m_stateOfGame)
                    {
                        m_Players[1].MakeAMove();
                    }
                    else
                    {
                        m_Players[1].MakeARendomMove();
                    }
                    Ex02.ConsoleUtils.Screen.Clear();
                    m_boardGame.printBoard();
                }

                UI.CongratsTheWinner(m_Players);
                UI.askForAnotherGame();
            }*/
        }

        public class UIBoard
        {
            public static void PrintBoard(Board i_gameBoard)
            {
                printLetters(i_gameBoard.ScreenBoard.GetLength(0));
                printTable(i_gameBoard.ScreenBoard.GetLength(0), i_gameBoard);

            }

            public static void printLetters(int i_boardSize)
            {
                Console.Write("      ");
                for (int i = 0; i < i_boardSize; i++)
                {
                    char c = Convert.ToChar('A' + i);
                    Console.Write(c + "     ");
                }

                Console.WriteLine();
                printSeparators(i_boardSize);

            }

            public static void printSeparators(int i_boardSize)
            {
                Console.Write("   ");
                for (int i = 0; i < i_boardSize; i++)
                {
                    Console.Write("======");
                }
                Console.WriteLine("=");
            }

            public static void printTable(int i_boardsize, Board i_ScreenBoard)
            {
                for (int i = 0; i < i_boardsize; i++)
                {
                    Console.Write(i + 1);
                    for (int j = 0; j < i_boardsize; j++)
                    {
                        Console.Write("  |  ");
                        Console.Write(i_ScreenBoard.ScreenBoard[i, j]);
                    }

                    Console.WriteLine("  |");
                    printSeparators(i_boardsize);
                }
            }

        }
    }

}
