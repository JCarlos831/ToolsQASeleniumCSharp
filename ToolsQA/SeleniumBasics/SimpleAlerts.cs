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
    class SimpleAlerts
    {
        [Test]
        public void SimpleAlertsTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://toolsqa.com/handling-alerts-using-selenium-webdriver/");

            // This will produce alert on screen
            driver.FindElement(By.XPath("//*[@id=\"content\"]/p[4]/button")).Click();
            Thread.Sleep(2000);

            // Switch the control of 'driver' to the Alert from main window
            IAlert alert = driver.SwitchTo().Alert();

            // '.Text' is used to get the text from the alert
            String alertText = alert.Text;
            Console.WriteLine("The alert text is: " + alertText);

            // '.Accept()' is used to accept the alert '(click on the Ok button)'
            alert.Accept();
            Thread.Sleep(2000);

            // Quit the browser
            driver.Quit();
        }
    }
}
