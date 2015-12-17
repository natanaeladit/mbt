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

        static string currentPlayerTurn;
        static string currentWin;

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


        /* 
         * Game Board Model Accumulator
        */

        public static void Move1(int x, int y)
        {
            Start();
            Move(y, x);
        }
        public static void Move2(int x, int y)
        {
            Move(y, x);
        }
        public static void Move3(int x, int y)
        {
            Move(y, x);
        }
        public static void Move4(int x, int y)
        {
            Move(y, x);
        }
        public static void Move5(int x, int y)
        {
            Move(y, x);
        }
        public static void Move6(int x, int y)
        {
            Move(y, x);
        }
        public static void Move7(int x, int y)
        {
            Move(y, x);
        }
        public static void Move8(int x, int y)
        {
            Move(y, x);
        }
        public static void Move9(int x, int y)
        {
            Move(y, x);
        }
        public static bool IsDraw()
        {
            bool isDraw = false;

            // All squares are not empty
            IWebElement element;
            string c1, c2, c3, c4, c5, c6, c7, c8, c9;
            element = driver.FindElement(By.Name("c7")); c7 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c8")); c8 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c9")); c9 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c4")); c4 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c5")); c5 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c6")); c6 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c1")); c1 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c2")); c2 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c3")); c3 = element.GetAttribute("value");
            if (c1 != "" && c2 != "" && c3 != "" && c4 != "" && c5 != "" && c6 != "" && c7 != ""
                && c8 != "" && c9 != "" && !IsPlayerWinDiagonal() && !IsPlayerWinHorizontal()
                && !IsPlayerWinVertical())
                isDraw = true;

            return isDraw;
        }
        public static bool IsPlayerWinHorizontal()
        {
            bool isHorizontal = false;
            IWebElement element;
            string c1, c2, c3, c4, c5, c6, c7, c8, c9;
            element = driver.FindElement(By.Name("c7")); c7 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c8")); c8 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c9")); c9 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c4")); c4 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c5")); c5 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c6")); c6 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c1")); c1 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c2")); c2 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c3")); c3 = element.GetAttribute("value");

            // Check O
            if (c1 == Player.O.ToString() && c2 == Player.O.ToString() && c3 == Player.O.ToString())
            { isHorizontal = true; currentWin = Player.O.ToString(); }
            else if (c4 == Player.O.ToString() && c5 == Player.O.ToString() && c6 == Player.O.ToString())
            { isHorizontal = true; currentWin = Player.O.ToString(); }
            else if (c7 == Player.O.ToString() && c8 == Player.O.ToString() && c9 == Player.O.ToString())
            { isHorizontal = true; currentWin = Player.O.ToString(); }

            // Check X
            if (c1 == Player.X.ToString() && c2 == Player.X.ToString() && c3 == Player.X.ToString())
            { isHorizontal = true; currentWin = Player.X.ToString(); }
            else if (c4 == Player.X.ToString() && c5 == Player.X.ToString() && c6 == Player.X.ToString())
            { isHorizontal = true; currentWin = Player.X.ToString(); }
            else if (c7 == Player.X.ToString() && c8 == Player.X.ToString() && c9 == Player.X.ToString())
            { isHorizontal = true; currentWin = Player.X.ToString(); }

            return isHorizontal;
        }
        public static bool IsPlayerWinVertical()
        {
            bool isVertical = false;
            IWebElement element;
            string c1, c2, c3, c4, c5, c6, c7, c8, c9;
            element = driver.FindElement(By.Name("c7")); c7 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c8")); c8 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c9")); c9 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c4")); c4 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c5")); c5 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c6")); c6 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c1")); c1 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c2")); c2 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c3")); c3 = element.GetAttribute("value");

            // Check O
            if (c1 == Player.O.ToString() && c4 == Player.O.ToString() && c7 == Player.O.ToString())
            { isVertical = true; currentWin = Player.O.ToString(); }
            else if (c2 == Player.O.ToString() && c5 == Player.O.ToString() && c8 == Player.O.ToString())
            { isVertical = true; currentWin = Player.O.ToString(); }
            else if (c3 == Player.O.ToString() && c6 == Player.O.ToString() && c9 == Player.O.ToString())
            { isVertical = true; currentWin = Player.O.ToString(); }

            // Check X
            if (c1 == Player.X.ToString() && c4 == Player.X.ToString() && c7 == Player.X.ToString())
            { isVertical = true; currentWin = Player.X.ToString(); }
            else if (c2 == Player.X.ToString() && c5 == Player.X.ToString() && c8 == Player.X.ToString())
            { isVertical = true; currentWin = Player.X.ToString(); }
            else if (c3 == Player.X.ToString() && c6 == Player.X.ToString() && c9 == Player.X.ToString())
            { isVertical = true; currentWin = Player.X.ToString(); }

            return isVertical;
        }
        public static bool IsPlayerWinDiagonal()
        {
            bool isDiagonal = false;

            IWebElement element;
            string c1, c2, c3, c4, c5, c6, c7, c8, c9;
            element = driver.FindElement(By.Name("c7")); c7 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c8")); c8 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c9")); c9 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c4")); c4 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c5")); c5 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c6")); c6 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c1")); c1 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c2")); c2 = element.GetAttribute("value");
            element = driver.FindElement(By.Name("c3")); c3 = element.GetAttribute("value");

            // Check O
            if (c3 == Player.O.ToString() && c5 == Player.O.ToString() && c7 == Player.O.ToString())
            { isDiagonal = true; currentWin = Player.O.ToString(); }
            else if (c1 == Player.O.ToString() && c5 == Player.O.ToString() && c9 == Player.O.ToString())
            { isDiagonal = true; currentWin = Player.O.ToString(); }

            // Check X
            if (c3 == Player.X.ToString() && c5 == Player.X.ToString() && c7 == Player.X.ToString())
            { isDiagonal = true; currentWin = Player.X.ToString(); }
            else if (c1 == Player.X.ToString() && c5 == Player.X.ToString() && c9 == Player.X.ToString())
            { isDiagonal = true; currentWin = Player.X.ToString(); }

            return isDiagonal;
        }
        public static string GetCurrentPlayerWin()
        {
            return currentWin;
        }

        /*
         * SUT Game Board
         * xy 00 10 20
         * 00 c7 c8 c9
         * 01 c4 c5 c6
         * 02 c1 c2 c3
         * */
        private static void Move(int x, int y)
        {
            string squareId = "";
            if (x == 0 && y == 2)
                squareId = "c1";
            else if (x == 1 && y == 2)
                squareId = "c2";
            else if (x == 2 && y == 2)
                squareId = "c3";
            else if (x == 0 && y == 1)
                squareId = "c4";
            else if (x == 1 && y == 1)
                squareId = "c5";
            else if (x == 2 && y == 1)
                squareId = "c6";
            else if (x == 0 && y == 0)
                squareId = "c7";
            else if (x == 1 && y == 0)
                squareId = "c8";
            else if (x == 2 && y == 0)
                squareId = "c9";
            IWebElement square = driver.FindElement(By.Name(squareId));
            square.Click();
            currentPlayerTurn = squareId;
        }
    }
}
