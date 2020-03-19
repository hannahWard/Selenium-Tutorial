using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace _06._Radio_Buttons
{
    class EntryPoint
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement radioButton;

        static void Main(string[] args)
        {
            string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
            string option = "1";

            driver.Navigate().GoToUrl(url);
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child("+ option +")"));

            if (radioButton.GetAttribute("checked") == "true") 
            {
                Console.WriteLine("Is Checked");
            }
            else
            {
                Console.WriteLine("Not Checked");
            }

            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
