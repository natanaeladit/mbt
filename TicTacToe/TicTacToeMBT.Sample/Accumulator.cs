using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;

namespace TicTacToeMBT.Sample
{
    /// <summary>
    /// A dummy implementation that doesn't conform to the model (testing should fail).
    /// </summary>
    public class Accumulator
    {
        static IWebDriver driver;
        static string url = "http://ostermiller.org/calc/tictactoe.html";

        public static void PlayerXClick()
        {
        }
        public static void PlayerOClick()
        {
        }
        public static void Start()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(url);
        }
        public static void Stop()
        {
        }
        public static void SelectXasFirstPlayer()
        {
        }
        public static void SelectOasFirstPlayer()
        {
        }
        public static void PlayerXWin()
        {
        }
        public static void PlayerOWin()
        {
        }
        public static void PlayerDraw()
        {
        }
        public static void ClearStatsClick()
        {
        }
        public static void NewGameClick()
        {
        }
    }
}
