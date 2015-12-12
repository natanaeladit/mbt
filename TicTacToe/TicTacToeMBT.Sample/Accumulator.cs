using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace TicTacToeMBT.Implementation
{
    public enum Player { X, O }

    /// <summary>
    /// An implementation that do conform to the model.
    /// </summary>
    public class Accumulator
    {
        static IWebDriver driver;
        static string url = "http://ostermiller.org/calc/tictactoe.html";
        static string currentOTurn;
        static string currentXTurn;

        public static void XTurn(string squareId)
        {
            IWebElement square = driver.FindElement(By.Name(squareId));
            square.Click();
            currentXTurn = squareId;
        }
        public static void OTurn(string squareId)
        {
            IWebElement square = driver.FindElement(By.Name(squareId));
            square.Click();
            currentOTurn = squareId;
        }
        public static void Start()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(url);
            SelectHumanVsHuman();
        }
        public static void Stop()
        {
            driver.Quit();
            driver.Dispose();
            driver = null;
        }
        public static void XasFirstPlayer()
        {
            IWebElement xRadio = driver.FindElement(By.Name("firstMove"));
            xRadio.Click();
        }
        public static void OasFirstPlayer()
        {
            IList<IWebElement> firstMoveRadios = driver.FindElements(By.Name("firstMove"));
            IWebElement oRadio = firstMoveRadios[1];
            oRadio.Click();
        }
        public static void ClearStats()
        {
            IWebElement clearStatsBtn = driver.FindElement(By.Name("newgame"));
            clearStatsBtn.Click();
        }
        public static void NewGame()
        {
            IList<IWebElement> inputs = driver.FindElements(By.XPath("//input[@value=\"New Game\"]"));
            IWebElement newGameBtn = inputs[0];
            newGameBtn.Click();
        }
        public static void SelectHumanVsHuman()
        {
            IWebElement player = driver.FindElement(By.Name("p1"));
            var selectElement = new SelectElement(player);
            selectElement.SelectByText("Human");

            player = driver.FindElement(By.Name("p2"));
            selectElement = new SelectElement(player);
            selectElement.SelectByText("Human");
        }
        public static int GetOWins()
        {
            int oWins = 0;
            IWebElement element = driver.FindElement(By.Name("oWon"));
            oWins = int.Parse(element.GetAttribute("value"));
            return oWins;
        }
        public static decimal GetORecord()
        {
            decimal oRecord = 0;
            IWebElement element = driver.FindElement(By.Name("oWonPer"));
            string value = element.GetAttribute("value");
            // Remove %
            oRecord = decimal.Parse(value.Replace("%", ""));
            return oRecord;
        }
        public static int GetXWins()
        {
            int xWins = 0;
            IWebElement element = driver.FindElement(By.Name("xWon"));
            xWins = int.Parse(element.GetAttribute("value"));
            return xWins;
        }
        public static decimal GetXRecord()
        {
            decimal xRecord = 0;
            IWebElement element = driver.FindElement(By.Name("xWonPer"));
            string value = element.GetAttribute("value");
            // Remove %
            xRecord = decimal.Parse(value.Replace("%", ""));
            return xRecord;
        }
        public static int GetCatWins()
        {
            int catWins = 0;
            IWebElement element = driver.FindElement(By.Name("catsGame"));
            catWins = int.Parse(element.GetAttribute("value"));
            return catWins;
        }
        public static decimal GetCatRecord()
        {
            decimal catRecord = 0;
            IWebElement element = driver.FindElement(By.Name("catsGamePer"));
            string value = element.GetAttribute("value");
            // Remove %
            catRecord = decimal.Parse(value.Replace("%", ""));
            return catRecord;
        }
        public static string GetSquareValue(string squareId)
        {
            string value = "";
            IWebElement square = driver.FindElement(By.Name(squareId));
            value = square.GetAttribute("value");
            return value;
        }
        public static string GetValueFromLastTurn(Player player)
        {
            string value = "";
            IWebElement square = null;
            if (player == Player.X)
            {
                square = driver.FindElement(By.Name(currentXTurn));
            }
            else if (player == Player.O)
            {
                square = driver.FindElement(By.Name(currentOTurn));
            }
            value = square.GetAttribute("value");
            return value;
        }
        public static object GetDriver()
        {
            return driver;
        }
        public static bool IsXAsFirstPlayer()
        {
            bool isSelected = false;

            IWebElement xRadio = driver.FindElement(By.Name("firstMove"));
            isSelected = xRadio.Selected;

            return isSelected;
        }
        public static bool IsOAsFirstPlayer()
        {
            bool isSelected = false;

            IList<IWebElement> firstMoveRadios = driver.FindElements(By.Name("firstMove"));
            IWebElement oRadio = firstMoveRadios[1];
            isSelected = oRadio.Selected;

            return isSelected;
        }
    }
}
