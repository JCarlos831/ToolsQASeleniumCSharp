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
    class FindElementCommands_2
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void PracticeExercise2()
        {
            // Go to automation practice form page
            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-form/");

            // Click on the Link "Partial Link Test" using partial linnk locator and search by Partial
            driver.FindElement(By.PartialLinkText("Partial")).Click();

            // Identify the Submit button with 'TagName' and convert it into a string and print on the console
            string tagName = driver.FindElement(By.TagName("button")).ToString();
            Console.WriteLine(tagName);

            // Click on the Link "Link Test" using the "LinkTest" locator
            driver.FindElement(By.LinkText("Link Test")).Click();
            Console.WriteLine("Clicked");

            // Quit the browser
            driver.Quit();

        }
    }
}
