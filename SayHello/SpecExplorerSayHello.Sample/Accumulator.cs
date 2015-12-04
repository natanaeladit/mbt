using System;
using System.Collections.Generic;
using System.Text;

namespace SpecExplorerSayHello.Sample
{
    /// <summary>
    /// An implementation that doesn't conform to the model (testing should fail).
    /// </summary>
    public class Accumulator
    {
        public static void Start()
        {
        }
        public static void Stop()
        {
        }
        public static void SayHello(string message)
        {
        }
        public static void Clear()
        {
        }
    }
}
