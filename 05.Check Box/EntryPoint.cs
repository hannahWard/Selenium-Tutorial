using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace _05.Check_Box
{
    class EntryPoint
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement checkBox;

        static void Main(string[] args)
        {
            string url = "http://testing.todorvachev.com/special-elements/check-button-test-3/";

            driver.Navigate().GoToUrl(url);


            driver.Quit();
        }
    }
}
