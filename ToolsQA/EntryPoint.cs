using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.SeleniumBasics;

namespace ToolsQA
{
    class EntryPoint
    {
        static void Main()
        {
            // Instantiate Driver
            IWebDriver driver = new ChromeDriver();

            // Navigate to DemoQA site
            driver.Navigate().GoToUrl("http://www.demoqa.com");

            // Close the browser
            driver.Quit();
        }
    }
}
