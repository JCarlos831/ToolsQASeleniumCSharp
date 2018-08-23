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
    class PromptAlerts
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();

            // Go to website
            driver.Navigate().GoToUrl("http://toolsqa.com/handling-alerts-using-selenium-webdriver/");

            // Scroll down by pixels
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");

            // This will produce alert on screen
            driver.FindElement(By.XPath("//*[@id=\"content\"]/p[11]/button")).Click();

            // Switch the control of 'driver' to Alert from main window
            IAlert promptAlert = driver.SwitchTo().Alert();

            // Get the text from the alert
            String alertText = promptAlert.Text;
            Console.WriteLine("This is the text from the alert: {0}.", alertText);

            // '.SendKeys()' to enter the text in to the textbox of the alert
            promptAlert.SendKeys("Accepting the Alert");

            Thread.Sleep(2000);

            // '.Accept()' to accept the alert '(click on the Ok button)'
            promptAlert.Accept();

            // Quit the browser
            driver.Quit();
        }
    }
}
