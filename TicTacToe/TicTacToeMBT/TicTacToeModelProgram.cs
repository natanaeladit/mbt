using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Microsoft.Modeling;

namespace TicTacToeMBT
{
    public enum GameState { Running, NotRunning }
    public enum TurnState { X, O }

    static class TicTacToeModelProgram
    {
        static GameState gameState = GameState.NotRunning;
        static TurnState turnState = TurnState.X;
        static TurnState firstPlayer = TurnState.X;

        [Probe]
        public static string status()
        {
            return "TurnState:" + turnState.ToString();
        }

        [Rule(Action = "XTurn(squareId)")]
        static void XTurn(string squareId)
        {
            Condition.IsTrue(gameState == GameState.Running);
            Condition.IsTrue(turnState == TurnState.X);

            // Update turn state
            turnState = TurnState.O;
        }

        [Rule(Action = "OTurn(squareId)")]
        static void OTurn(string squareId)
        {
            Condition.IsTrue(gameState == GameState.Running);
            Condition.IsTrue(turnState == TurnState.O);

            // Update turn state
            turnState = TurnState.X;
        }

        [Rule(Action = "Start()")]
        static void Start()
        {
            Condition.IsTrue(gameState == GameState.NotRunning);
            gameState = GameState.Running;
        }

        [Rule(Action = "Stop()")]
        static void Stop()
        {
            Condition.IsTrue(gameState == GameState.Running);

            gameState = GameState.NotRunning;
        }

        [Rule(Action = "XasFirstPlayer()")]
        static void SelectXasFirstPlayer()
        {
            Condition.IsTrue(gameState == GameState.Running);

            // Enable to change if only current first player is O
            Condition.IsTrue(firstPlayer == TurnState.O);

            firstPlayer = TurnState.X;
            turnState = TurnState.X;
        }

        [Rule(Action = "OasFirstPlayer()")]
        static void SelectOasFirstPlayer()
        {
            Condition.IsTrue(gameState == GameState.Running);

            // Enable to change if only current first player is X
            Condition.IsTrue(firstPlayer == TurnState.X);

            firstPlayer = TurnState.O;
            turnState = TurnState.O;
        }

        [Rule(Action = "ClearStats()")]
        static void ClearStats()
        {
            Condition.IsTrue(gameState == GameState.Running);
        }

        [Rule(Action = "NewGame()")]
        static void NewGame()
        {
            Condition.IsTrue(gameState == GameState.Running);

            gameState = GameState.Running;
            turnState = firstPlayer;
        }
    }
}
