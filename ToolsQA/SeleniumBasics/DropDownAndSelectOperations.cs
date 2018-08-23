using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolsQA.SeleniumBasics
{
    class DropDownAndSelectOperations
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void Practice()
        {
            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-form/");

            IWebElement continentElement = driver.FindElement(By.Id("continents"));

            SelectElement selectContinent = new SelectElement(continentElement);

            selectContinent.SelectByIndex(1);

            selectContinent.SelectByText("Africa");

            IList<IWebElement> continents = driver.FindElements(By.Id("continents"));

            for (int i = 0; i < continents.Count; i++)
            {
                Console.WriteLine(continents.ElementAt(i).Text);
            }

            selectContinent.SelectByIndex(3);

            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
