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
    class Alerts
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://toolsqa.com/handling-alerts-using-selenium-webdriver/");

            // This will produce alert on screen
            driver.FindElement(By.XPath("//*[@id=\"content\"]/p[4]/button")).Click();

            //Once alert is present, try to clik on any button on the page
            driver.FindElement(By.CssSelector("#content > p:nth-child(13) > button"));
        }
    }
}
