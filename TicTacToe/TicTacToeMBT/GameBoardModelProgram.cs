using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Modeling;

namespace TicTacToeMBT
{
    static class GameBoardModelProgram
    {
        public enum GameState
        {
            Move1, Move2, Move3, Move4, Move5, Move6, Move7, Move8, Move9,
            XWinH, XWinD, XWinV, OWinH, OWinD, OWinV, Draw
        }
        public enum TurnState { PlayerX, PlayerO }
        public enum BoxValue { Empty, X, O }

        public class BoxCoordinate
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        static GameState gameState = GameState.Move1;
        static TurnState currentTurnState = TurnState.PlayerX;
        static BoxValue currentBoxValue = BoxValue.X;
        static int[][] gameBoard = new int[3][]
            {
                new int[3] {(int)BoxValue.Empty,(int)BoxValue.Empty,(int)BoxValue.Empty},
                new int[3] {(int)BoxValue.Empty,(int)BoxValue.Empty,(int)BoxValue.Empty},
                new int[3] {(int)BoxValue.Empty,(int)BoxValue.Empty,(int)BoxValue.Empty}
            };
        static int xWins = 0;
        static decimal xRecord = 0;
        static int oWins = 0;
        static decimal oRecord = 0;
        static int catWins = 0;
        static decimal catRecord = 0;

        [Probe]
        public static string status()
        {
            // Printing
            string status = "";
            if (gameBoard != null)
            {
                if (gameState == GameState.Draw || gameState == GameState.OWinD || gameState == GameState.XWinD
                 || gameState == GameState.OWinH || gameState == GameState.OWinV || gameState == GameState.XWinV
                 || gameState == GameState.XWinH)
                    status = status + gameState.ToString() + "\n";

                for (int i = 0; i < 3; i++)
                {
                    if (gameBoard[i] != null)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            switch (gameBoard[i][j])
                            {
                                case (int)BoxValue.X: status = status + "X";
                                    break;
                                case (int)BoxValue.O: status = status + "O";
                                    break;
                                case (int)BoxValue.Empty: status = status + "e";
                                    break;
                            }
                        }
                        status = status + "\n";
                    }
                }
            }
            return status;
        }

        [Rule(Action = "Move1(x,y)")]
        static void Move1(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Move1);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);
            gameState = GameState.Move2;

            // Mark box as Player Value
            gameBoard[x][y] = (int)currentBoxValue;

            CheckWinOrDraw();

            SwitchTurn();
        }

        [Rule(Action = "Move2(x,y)")]
        static void Move2(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Move2);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);
            gameState = GameState.Move3;

            // Mark box as Player Value
            gameBoard[x][y] = (int)currentBoxValue;

            CheckWinOrDraw();

            SwitchTurn();
        }

        [Rule(Action = "Move3(x,y)")]
        static void Move3(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Move3);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);
            gameState = GameState.Move4;

            // Mark box as Player Value
            gameBoard[x][y] = (int)currentBoxValue;

            CheckWinOrDraw();

            SwitchTurn();
        }

        [Rule(Action = "Move4(x,y)")]
        static void Move4(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Move4);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);
            gameState = GameState.Move5;

            // Mark box as Player Value
            gameBoard[x][y] = (int)currentBoxValue;

            CheckWinOrDraw();

            SwitchTurn();
        }

        [Rule(Action = "Move5(x,y)")]
        static void Move5(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Move5);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);
            gameState = GameState.Move6;

            // Mark box as Player Value
            gameBoard[x][y] = (int)currentBoxValue;

            CheckWinOrDraw();

            SwitchTurn();
        }

        [Rule(Action = "Move6(x,y)")]
        static void Move6(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Move6);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);
            gameState = GameState.Move7;

            // Mark box as Player Value
            gameBoard[x][y] = (int)currentBoxValue;

            CheckWinOrDraw();

            SwitchTurn();
        }

        [Rule(Action = "Move7(x,y)")]
        static void Move7(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Move7);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);
            gameState = GameState.Move8;

            // Mark box as Player Value
            gameBoard[x][y] = (int)currentBoxValue;

            CheckWinOrDraw();

            SwitchTurn();
        }

        [Rule(Action = "Move8(x,y)")]
        static void Move8(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Move8);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);
            gameState = GameState.Move9;

            // Mark box as Player Value
            gameBoard[x][y] = (int)currentBoxValue;

            CheckWinOrDraw();

            SwitchTurn();
        }

        [Rule(Action = "Move9(x,y)")]
        static void Move9(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Move9);
            Condition.IsTrue(gameBoard[x][y] == (int)BoxValue.Empty);

            // Mark box as Player Value
            gameBoard[x][y] = (int)currentBoxValue;

            CheckWinOrDraw();

            SwitchTurn();
        }

        static void PlayerXWin()
        {
            xWins++;
            UpdateScoreRecords();
        }

        static void PlayerOWin()
        {
            oWins++;
            UpdateScoreRecords();
        }

        static void PlayerDraw()
        {
            catWins++;
            UpdateScoreRecords();
        }

        static void SwitchTurn()
        {
            if (currentTurnState == TurnState.PlayerX)
            {
                currentTurnState = TurnState.PlayerO;
                currentBoxValue = BoxValue.O;
            }
            else
            {
                currentTurnState = TurnState.PlayerX;
                currentBoxValue = BoxValue.X;
            }
        }

        static void CheckWinOrDraw()
        {
            // Check Draw
            if (CheckDraw())
            {
                gameState = GameState.Draw;
                PlayerDraw();
            }

            // Check Player win

            if (currentTurnState == TurnState.PlayerX)
            {
                if (CheckWinHorizontal(currentBoxValue))
                    gameState = GameState.XWinH;
                else if (CheckWinVertical(currentBoxValue))
                    gameState = GameState.XWinV;
                else if (CheckWinDiagonal(currentBoxValue))
                    gameState = GameState.XWinD;
                PlayerXWin();
            }
            else if (currentTurnState == TurnState.PlayerO)
            {
                if (CheckWinHorizontal(currentBoxValue))
                    gameState = GameState.OWinH;
                else if (CheckWinVertical(currentBoxValue))
                    gameState = GameState.OWinV;
                else if (CheckWinDiagonal(currentBoxValue))
                    gameState = GameState.OWinD;
                PlayerOWin();
            }
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
                if (countVal == 3)
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
                if (countVal == 3)
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
            // Check all boxes are not empty
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