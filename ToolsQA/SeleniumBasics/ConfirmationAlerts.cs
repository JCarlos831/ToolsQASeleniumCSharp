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
    class ConfirmationAlerts
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();

            // Go to website
            driver.Navigate().GoToUrl("http://toolsqa.com/handling-alerts-using-selenium-webdriver/");

            // This will produce alert on screen
            driver.FindElement(By.XPath("//*[@id='content']/p[8]/button")).Click();
            Thread.Sleep(2000);

            // Switch the control of 'driver' to the Alert from the main window
            IAlert confirmationAlert = driver.SwitchTo().Alert();

            // Get the text from Alert
            string alertText = confirmationAlert.Text;
            Console.WriteLine("This is the alert text: " + alertText);

            // '.Dismiss()' is used to cancel the alert '(click on the Cancel button)'
            confirmationAlert.Dismiss();
            Thread.Sleep(1000);

            // Quit the browser
            driver.Quit();
        }
    }
}
