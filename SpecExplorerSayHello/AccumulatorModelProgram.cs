using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Microsoft.Modeling;

namespace SpecExplorerSayHello
{
    public enum State { running, notRunning }

    static class AccumulatorModelProgram
    {
        static string textBox = "";
        static State state = State.notRunning;

        [Probe]
        public static string status()
        {
            return "status:" + state.ToString();
        }

        [Rule(Action = "Start()")]
        static void Start()
        {
            Condition.IsTrue(state == State.notRunning);
            state = State.running;
        }

        [Rule(Action = "Stop()")]
        static void Stop()
        {
            Condition.IsTrue(state == State.running);
            textBox = "";
            state = State.notRunning;
        }

        [Rule(Action = "SayHello(message)")]
        static void SayHello(string message)
        {
            Condition.IsTrue(state == State.running);
            // Enter a message
            textBox = "Hello " + message;
        }

        [Rule(Action = "Clear()")]
        static void Clear()
        {
            Condition.IsTrue(state == State.running);
            textBox = "";
        }
    }
}
