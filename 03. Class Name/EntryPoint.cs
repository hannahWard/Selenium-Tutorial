using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace _03._Class_Name
{
    class EntryPoint
    {
        static void Main()
        {
            //Better to use CSS selector bc better supported by the browser & usually works faster
            string url = "http://testing.todvachev.com/selectors/css-path/";
            string cssPath = "#search-2 > form > label > iut";
            string xPath = "//*[@id=\"search-2\"]/form/label/input";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            IWebElement cssPathElement;
            IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

            try
            {
                cssPathElement = driver.FindElement(By.CssSelector(cssPath));

                if (cssPathElement.Displayed)
                {
                    GreenMessage("I can see the CSS Path Element");
                }

            }
            catch (NoSuchElementException)
            {

                RedMessage("CSS Path Element is not there");
            }

            //if (cssPathElement.Displayed)
            //{
            //    GreenMessage("I can see the CSS Path Element");
            //}
            //else
            //{
            //    RedMessage("CSS Path Element is not there");
            //}

            //if (xPathElement.Displayed)
            //{
            //    GreenMessage("I can see the X Path Element");
            //}
            //else
            //{
            //    RedMessage("X Path Element is not there");
            //}

            driver.Quit();
        }

        //static void Main()
        //{
        //    string url = "http://testing.todorvachev.com/selectors/class-name/";
        //    string className = "testClass";

        //    IWebDriver driver = new ChromeDriver();

        //    driver.Navigate().GoToUrl(url);

        //    IWebElement element = driver.FindElement(By.ClassName(className));

        //    Console.WriteLine(element.Text);

        //    driver.Quit();
        //}

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
