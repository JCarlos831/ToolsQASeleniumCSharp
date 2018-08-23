using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolsQA.SeleniumBasics
{
    [TestFixture]
    class PrintMultipleWindowHandles
    {
        [Test]
        public void MultiWindowPrintTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-switch-windows/");

            // Store the parent window of the driver
            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

            IWebElement clickElement = driver.FindElement(By.Id("button1"));

            // Mulitple click to open mulitple window
            for (var i = 0; i < 3; i++)
            {
                clickElement.Click();
                Thread.Sleep(2000);
            }

            // Store all the opened windows into the list
            // Print each item of the list
            List<string> listWindow = driver.WindowHandles.ToList();
            foreach (var handle in listWindow)
            {
                Console.WriteLine(handle); ;
            }
        }
    }
}