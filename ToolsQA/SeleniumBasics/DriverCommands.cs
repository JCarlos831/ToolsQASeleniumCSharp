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
    public class DriverCommands
    {
        IWebDriver driver = new ChromeDriver();
        
        [Test]
        [Parallelizable]
        public void PracticeExercise1()
        {
            driver.Navigate().GoToUrl("http://www.store.demoqa.com");

            // Page Title name and length
            string pageTitle = driver.Title;
            int pageTitleLength = pageTitle.Length;
            Console.WriteLine("The page title is: {0}. The page length is: {1}.", pageTitle, pageTitleLength);

            // URL name and length
            string urlName = driver.Url;
            int urlNameLength = urlName.Length;
            Console.WriteLine("The name of the URL is: {0}. The URL length is: {1}.", urlName, urlNameLength);

            // Page source data and its length
            string pageSource = driver.PageSource;
            int pageSourceLength = pageSource.Length;
            Console.WriteLine("Here is the page source data: {0}. Its length is {1}.", pageSource, pageSourceLength);

            // Quit the browser
            driver.Quit();
        }
    }
}
