using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA.SeleniumBasics
{ 
    [TestFixture]
    class BrowserNavigation
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void Practice()
        {
            // Go to demo qa site
            driver.Navigate().GoToUrl("http://www.demoqa.com");

            // Click on Registration Link
            driver.FindElement(By.CssSelector("#menu-item-374 > a")).Click();

            // Go back to home page
            driver.Navigate().Back();

            // Go back to registration page
            driver.Navigate().Forward();

            // Go back to home page
            driver.Navigate().GoToUrl("http://www.demoqa.com");

            // Refresh the browser
            driver.Navigate().Refresh();

            // Quit the browser
            driver.Quit();
        }
    }
}
