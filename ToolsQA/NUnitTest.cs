using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;
        
        [SetUp]
        public void Initialize()
        {
            // Instantiate the chrome driver
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenTestApp()
        {
            // Go to demo qa site
            driver.Navigate().GoToUrl("http://www.demoqa.com");
        }

        [TearDown]
        public void EndTest()
        {
            // Quit the browser
            driver.Quit();
        }
    }
}
