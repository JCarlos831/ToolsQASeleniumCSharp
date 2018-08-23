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
    class ClosingAllWindows
    {
        [Test]
        public void ClosingAllWindowsTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-switch-windows/");

            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent Window Handle: " + parentWindowHandle);

            IWebElement clickElement = driver.FindElement(By.Id("button1"));

            for (var i = 0; i < 3; i++)
            {
                clickElement.Click();
                Thread.Sleep(3000);
            }

            List<string> lstWindow = driver.WindowHandles.ToList();
            String lastWindowHandle = "";

            foreach (var handle in lstWindow)
            {
                Console.WriteLine("Switching to window -> " + handle);
                Console.WriteLine("Navigating to google.com");

                //Switch to the deesired window first and then execute commands using driver
                driver.SwitchTo().Window(handle);

                driver.Navigate().GoToUrl("https://www.google.com");
            }

            // Switch to parent window
            driver.SwitchTo().Window(parentWindowHandle);

            // Close the parent window
            driver.Close();

            // There is no focused window so need to explicitly switch back to a window
            driver.SwitchTo().Window(lastWindowHandle);

            driver.Url = "http://toolsqa.com";
            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
