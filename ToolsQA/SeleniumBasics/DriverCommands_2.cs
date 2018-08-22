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
    class DriverCommands_2
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        [Parallelizable]
        public void PracticeExercise2()
        {
            // Go to URL
            driver.Navigate().GoToUrl("http://demoqa.com/frames-and-windows");

            // Find New Window Button
            driver.FindElement(By.CssSelector("#ui-id-1")).Click();

            // Quit browser
            driver.Quit();
        }
    }
}
