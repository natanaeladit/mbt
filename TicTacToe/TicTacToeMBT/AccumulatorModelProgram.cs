using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Microsoft.Modeling;

namespace TicTacToeMBT
{
    public enum GameState { Running, NotRunning, XWin, OWin, Draw }
    public enum TurnState { PlayerX, PlayerO }
    public enum BoxValue { Empty, X, O }

    static class AccumulatorModelProgram
    {
        static GameState gameState = GameState.NotRunning;
        static TurnState turnState = TurnState.PlayerX;
        static TurnState firstPlayer = TurnState.PlayerX;
        static int[][] gameBoard = new int[3][];
        static int xWins = 0;
        static decimal xRecord = 0;
        static int oWins = 0;
        static decimal oRecord = 0;
        static int catWins = 0;
        static decimal catRecord = 0;

        [Probe]
        public static string status()
        {
            return "gameState:" + gameState.ToString();
        }

        [Rule(Action = "PlayerXClick(x,y)")]
        static void PlayerXClick(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Running);
            Condition.IsTrue(turnState == TurnState.PlayerX);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);

            // Update turn state
            turnState = TurnState.PlayerO;

            // Mark box as X
            gameBoard[x][y] = (int)BoxValue.X;
        }

        [Rule(Action = "PlayerXWinHorizontal")]
        static void PlayerXWinHorizontal()
        {
            Condition.IsTrue(gameState == GameState.Running);

            Condition.IsTrue(CheckWinHorizontal(BoxValue.X));
            gameState = GameState.XWin;
        }

        [Rule(Action = "PlayerXWinVertical")]
        static void PlayerXWinVertical()
        {
            Condition.IsTrue(gameState == GameState.Running);

            Condition.IsTrue(CheckWinVertical(BoxValue.X));
            gameState = GameState.XWin;
        }

        [Rule(Action = "PlayerXWinDiagonal")]
        static void PlayerXWinDiagonal()
        {
            Condition.IsTrue(gameState == GameState.Running);

            Condition.IsTrue(CheckWinDiagonal(BoxValue.X));
            gameState = GameState.XWin;
        }

        [Rule(Action = "PlayerXWin()")]
        static void PlayerXWin()
        {
            Condition.IsTrue(gameState == GameState.XWin);
            xWins++;
            UpdateScoreRecords();
        }

        [Rule(Action = "PlayerOClick(x,y)")]
        static void PlayerOClick(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Running);
            Condition.IsTrue(turnState == TurnState.PlayerO);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);

            // Update turn state
            turnState = TurnState.PlayerX;

            // Mark box as O
            gameBoard[x][y] = (int)BoxValue.O;
        }

        [Rule(Action = "PlayerOWinHorizontal")]
        static void PlayerOWinHorizontal()
        {
            Condition.IsTrue(gameState == GameState.Running);

            Condition.IsTrue(CheckWinHorizontal(BoxValue.O));
            gameState = GameState.OWin;
        }

        [Rule(Action = "PlayerOWinVertical")]
        static void PlayerOWinVertical()
        {
            Condition.IsTrue(gameState == GameState.Running);

            Condition.IsTrue(CheckWinVertical(BoxValue.O));
            gameState = GameState.OWin;
        }

        [Rule(Action = "PlayerOWinDiagonal")]
        static void PlayerOWinDiagonal()
        {
            Condition.IsTrue(gameState == GameState.Running);

            Condition.IsTrue(CheckWinDiagonal(BoxValue.O));
            gameState = GameState.OWin;
        }

        [Rule(Action = "PlayerOWin()")]
        static void PlayerOWin()
        {
            Condition.IsTrue(gameState == GameState.OWin);
            oWins++;
            UpdateScoreRecords();
        }

        [Rule(Action = "PlayerDraw()")]
        static void PlayerDraw()
        {
            Condition.IsTrue(gameState == GameState.Running);
            Condition.IsTrue(CheckDraw());
            gameState = GameState.Draw;
        }

        [Rule(Action = "Draw()")]
        static void Draw()
        {
            Condition.IsTrue(gameState == GameState.Draw);
            catWins++;
            UpdateScoreRecords();
        }

        [Rule(Action = "Start()")]
        static void Start()
        {
            Condition.IsTrue(gameState == GameState.NotRunning);
            gameState = GameState.Running;

            // Initialize game board
            InitializeGameBoard();
        }

        [Rule(Action = "Stop()")]
        static void Stop()
        {
            Condition.IsTrue(gameState == GameState.Running
                           | gameState == GameState.Draw
                           | gameState == GameState.XWin
                           | gameState == GameState.OWin);

            gameState = GameState.NotRunning;
        }

        [Rule(Action = "SelectXasFirstPlayer()")]
        static void SelectXasFirstPlayer()
        {
            Condition.IsTrue(gameState == GameState.Running
                           | gameState == GameState.Draw
                           | gameState == GameState.XWin
                           | gameState == GameState.OWin);

            // Enable to change if only current first player is O
            Condition.IsTrue(firstPlayer == TurnState.PlayerO);
            
            firstPlayer = TurnState.PlayerX;
            turnState = TurnState.PlayerX;

            // Reset game
            InitializeGameBoard();
        }

        [Rule(Action = "SelectOasFirstPlayer()")]
        static void SelectOasFirstPlayer()
        {
            Condition.IsTrue(gameState == GameState.Running
                           | gameState == GameState.Draw
                           | gameState == GameState.XWin
                           | gameState == GameState.OWin);

            // Enable to change if only current first player is X
            Condition.IsTrue(firstPlayer == TurnState.PlayerX);
            
            firstPlayer = TurnState.PlayerO;
            turnState = TurnState.PlayerO;

            // Reset game
            InitializeGameBoard();
        }

        [Rule(Action = "ClearStatsClick()")]
        static void ClearStatsClick()
        {
            Condition.IsTrue(gameState == GameState.Running
                           | gameState == GameState.Draw
                           | gameState == GameState.XWin
                           | gameState == GameState.OWin);

            xWins = 0;
            xRecord = 0;
            oWins = 0;
            oRecord = 0;
            catWins = 0;
            catRecord = 0;
        }

        [Rule(Action = "NewGameClick()")]
        static void NewGameClick()
        {
            Condition.IsTrue(gameState == GameState.Running
                           | gameState == GameState.Draw
                           | gameState == GameState.XWin
                           | gameState == GameState.OWin);

            // Reset game
            InitializeGameBoard();
        }

        static void UpdateScoreRecords()
        {
            int totalPlay = xWins + oWins + catWins;
            xRecord = (xWins / totalPlay) * 100;
            oRecord = (oWins / totalPlay) * 100;
            catRecord = (catWins / totalPlay) * 100;
        }

        static void InitializeGameBoard()
        {
            gameBoard[0] = new int[3];
            gameBoard[1] = new int[3];
            gameBoard[2] = new int[3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i][j] = (int)BoxValue.Empty;
                }
            }
        }

        /* GAME BOARD
         *   0 1 2 j
         * 0 . . .
         * 1 . . .
         * 2 . . .
         * i 
        */
        static bool CheckWinHorizontal(BoxValue boxValue)
        {
            bool isPlayerWin = false;
            for (int i = 0; i < 3; i++)
            {
                int countVal = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[i][j] == (int)boxValue)
                    {
                        countVal++;
                    }
                }
                if (countVal == 2)
                {
                    isPlayerWin = true;
                    return isPlayerWin;
                }
            }
            return isPlayerWin;
        }

        static bool CheckWinVertical(BoxValue boxValue)
        {
            bool isPlayerWin = false;
            for (int i = 0; i < 3; i++)
            {
                int countVal = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[j][i] == (int)boxValue)
                    {
                        countVal++;
                    }
                }
                if (countVal == 2)
                {
                    isPlayerWin = true;
                    return isPlayerWin;
                }
            }
            return isPlayerWin;
        }

        static bool CheckWinDiagonal(BoxValue boxValue)
        {
            bool isPlayerWin = false;
            if (gameBoard[0][0] == (int)boxValue)
            {
                if (gameBoard[1][1] == (int)boxValue)
                {
                    if (gameBoard[2][2] == (int)boxValue)
                    {
                        isPlayerWin = true;
                        return isPlayerWin;
                    }
                }
            }
            if (gameBoard[2][0] == (int)boxValue)
            {
                if (gameBoard[1][1] == (int)boxValue)
                {
                    if (gameBoard[0][2] == (int)boxValue)
                    {
                        isPlayerWin = true;
                        return isPlayerWin;
                    }
                }
            }
            return isPlayerWin;
        }

        static bool CheckDraw()
        {
            bool isDraw = true;
            // Check all box are not empty
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[i][j] == (int)BoxValue.Empty)
                    {
                        isDraw = false;
                        return isDraw;
                    }
                }
            }
            return isDraw;
        }
    }
}
