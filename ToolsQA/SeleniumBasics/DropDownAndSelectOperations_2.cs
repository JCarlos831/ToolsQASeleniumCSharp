using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolsQA.SeleniumBasics
{
    [TestFixture]
    class DropDownAndSelectOperations_2
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void MultiSelect()
        {
            // Open automation practice form
            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-form/");

            // Select 'Selenium Commands' Mulitplie selection box (Use Name locator to identify the element)
            SelectElement seleniumCommandsOptions = new SelectElement(driver.FindElement(By.Name("selenium_commands")));

            // Select option 'Browser Commands' and then deselect it (Use SelectByIndex and DeselectByIndex)
            seleniumCommandsOptions.SelectByIndex(0);
            Thread.Sleep(1000);
            seleniumCommandsOptions.DeselectByIndex(0);

            // Select option 'Navigation Commands' and then deselect it (Use SelectByText and DeselectByText)
            seleniumCommandsOptions.SelectByText("Navigation Commands");
            Thread.Sleep(1000);
            seleniumCommandsOptions.DeselectByText("Navigation Commands");

            // Print and select all the options for the selected Mulitple selection list.
            IList<IWebElement> seleniumCommandsOptionsSize = seleniumCommandsOptions.Options;
            int iListSeleniumCommandsOptionsSize = seleniumCommandsOptionsSize.Count;

            for (int i = 0; i < iListSeleniumCommandsOptionsSize; i++)
            {
                // Storing the value of the option
                String sValue = seleniumCommandsOptions.Options.ElementAt(i).Text;

                // Printing the stored value
                Console.WriteLine(sValue);

                // Selecting all the elements one by one
                seleniumCommandsOptions.SelectByIndex(i);

                Thread.Sleep(2000);
            }

            // Deselect all options
            seleniumCommandsOptions.DeselectAll();
            Thread.Sleep(2000);

            // Close the browser
            driver.Quit();
        }
    }
}
