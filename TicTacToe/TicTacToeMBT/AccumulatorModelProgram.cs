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
        static int[][] gameBoard = new int[3][];
        static int xWins = 0;
        static decimal xRecord = 0;
        static int oWins = 0;
        static decimal oRecord = 0;
        static int catWins = 0;
        static decimal catRecord = 0;

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

            // Check X win horizontal
            if (CheckWinHorizontal(BoxValue.X))
            {
                gameState = GameState.XWin;
                return;
            }

            // Check X win vertical
            if (CheckWinVertical(BoxValue.X))
            {
                gameState = GameState.XWin;
                return;
            }

            // Check X win diagonal
            if (CheckWinDiagonal(BoxValue.X))
            {
                gameState = GameState.XWin;
                return;
            }

            // Check Draw
            if (CheckDraw())
            {
                gameState = GameState.Draw;
                return;
            }
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

            // Check O win horizontal
            if (CheckWinHorizontal(BoxValue.O))
            {
                gameState = GameState.OWin;
                return;
            }

            // Check O win vertical
            if (CheckWinVertical(BoxValue.O))
            {
                gameState = GameState.OWin;
                return;
            }

            // Check O win diagonal
            if (CheckWinDiagonal(BoxValue.O))
            {
                gameState = GameState.OWin;
                return;
            }

            // Check Draw
            if (CheckDraw())
            {
                gameState = GameState.Draw;
                return;
            }
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
            Condition.IsTrue(gameState == GameState.Running);
            gameState = GameState.NotRunning;
        }

        [Rule(Action = "SelectXasFirstPlayer()")]
        static void SelectXasFirstPlayer()
        {
            Condition.IsTrue(gameState == GameState.Running);
            turnState = TurnState.PlayerX;

            // Reset game
            InitializeGameBoard();
        }

        [Rule(Action = "SelectOasFirstPlayer()")]
        static void SelectOasFirstPlayer()
        {
            Condition.IsTrue(gameState == GameState.Running);
            turnState = TurnState.PlayerO;

            // Reset game
            InitializeGameBoard();
        }

        [Rule(Action = "UpdateScorePlayerXwin()")]
        static void UpdateScorePlayerXwin()
        {
            Condition.IsTrue(gameState == GameState.XWin);
            xWins++;
            UpdateScoreRecords();
        }

        [Rule(Action = "UpdateScorePlayerOwin()")]
        static void UpdateScorePlayerOwin()
        {
            Condition.IsTrue(gameState == GameState.OWin);
            oWins++;
            UpdateScoreRecords();
        }

        [Rule(Action = "UpdateScorePlayerDraw()")]
        static void UpdateScorePlayerDraw()
        {
            Condition.IsTrue(gameState == GameState.Draw);
            catWins++;
            UpdateScoreRecords();
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
