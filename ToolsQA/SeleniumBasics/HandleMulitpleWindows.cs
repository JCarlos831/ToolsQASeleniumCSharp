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
    class HandleMulitpleWindows
    {
        [Test]
        public void MultiWindowSwitchTest()
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
            List<string> listWindow = driver.WindowHandles.ToList();

            // Traverse each and every window
            foreach (var handle in listWindow)
            {
                Console.WriteLine("Switching to window -> " + handle);
                Console.WriteLine("Navigating to google.com");

                // Switch to the desired window first and then execute commands using driver
                driver.SwitchTo().Window(handle);
                driver.Navigate().GoToUrl("https://www.google.com");
            }

        }
    }
}
