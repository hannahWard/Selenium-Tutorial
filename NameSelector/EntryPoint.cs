using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NameSelector
{
    class EntryPoint
    {
        static void Main()
        {
            string url = "http://testing.todorvachev.com/selector/id";
            string ID = "testImage";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.Id(ID));

            if (element.Displayed)
            {
                GreenMessage("Yes, I can see it");
            }
            else
            {
                RedMessage("Nope, it's not there");
            }
        }

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
