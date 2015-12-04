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
        static int[,] gameBoard = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        [Rule(Action = "PlayerXClick(x,y)")]
        static void PlayerXClick(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Running);
            Condition.IsTrue(turnState == TurnState.PlayerX);

            // Update turnState
            turnState = TurnState.PlayerO;

            // Mark board as X
            gameBoard[x, y] = (int)BoxValue.X;
        }

        [Rule(Action = "PlayerOClick(x,y)")]
        static void PlayerOClick(int x, int y)
        {
            Condition.IsTrue(gameState == GameState.Running);
            Condition.IsTrue(turnState == TurnState.PlayerO);
            turnState = TurnState.PlayerX;
        }

        [Rule(Action = "Start()")]
        static void Start()
        {
            Condition.IsTrue(gameState == GameState.NotRunning);
            gameState = GameState.Running;

            // Set game board empty
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = (int)BoxValue.Empty;
                }
            }
        }

        [Rule(Action = "Stop()")]
        static void Stop()
        {
            Condition.IsTrue(gameState == GameState.Running);
            gameState = GameState.NotRunning;

            // Calculate score
        }
    }
}
