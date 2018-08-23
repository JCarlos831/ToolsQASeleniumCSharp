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
    class FindElementCommands
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void PracticeExercise1()
        {
            // Go to contact form
            driver.Navigate().GoToUrl("http://demoqa.com/contact");

            // Type name and last name using Name locator
            driver.FindElement(By.Name("your-name")).SendKeys("John Smith");

            // Type email address using Css locator
            driver.FindElement(By.CssSelector("#wpcf7-f375-p28-o1 > form > p:nth-child(3) > span > input")).SendKeys("johnsmith@email.com");

            // Type subject using xpath
            driver.FindElement(By.XPath("//*[@id=\"wpcf7-f375-p28-o1\"]/form/p[3]/span/input")).SendKeys("Test");

            // Type in message box using name
            driver.FindElement(By.Name("your-message")).SendKeys("testing");

            // Click on Submit Button
            driver.FindElement(By.CssSelector("#wpcf7-f375-p28-o1 > form > p:nth-child(6) > input")).Submit();

            // Quit the browser session
            driver.Quit();
        }
    }
}
