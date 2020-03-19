using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace _05.Check_Box
{
    class EntryPoint
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement checkBox;
        static IWebElement checkBox2;

        static void Main(string[] args)
        {
            string url = "http://testing.todorvachev.com/special-elements/check-button-test-3/";
            string option = "1";
            string option2 = "3";

            driver.Navigate().GoToUrl(url);

            checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));
            checkBox2 = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option2 + ")"));

            checkBox.Click();
            checkBox2.Click();

            

            //display the value of the chosen checkbox
            //Console.WriteLine(checkBox.GetAttribute("value"));

            //option = "3";
            //checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));

            //Console.WriteLine(checkBox.GetAttribute("value"));


            //display if chosen option is clicked t/f
            //if (checkBox.GetAttribute("checked") == "true")
            //{
            //    Console.WriteLine("Is Checked");
            //}
            //else
            //{
            //    Console.WriteLine("Not Checked");
            //}

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
