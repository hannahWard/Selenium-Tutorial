using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace _04._Input_Text_Box
{
    class EntryPoint
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement textBox;

        static void Main(string[] args)
        {
            string url = "http://testing.todorvachev.com/special-elements/text-input-field/";

            driver.Navigate().GoToUrl(url);

            textBox = driver.FindElement(By.Name("username"));
            textBox.SendKeys("Test Text");
            Thread.Sleep(3000);

            Console.WriteLine(textBox.GetAttribute("value"));
            Thread.Sleep(3000); 

            driver.Quit();
        }
    }
}
