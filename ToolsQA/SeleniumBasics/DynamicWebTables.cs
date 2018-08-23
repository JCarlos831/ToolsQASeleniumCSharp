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
    class DynamicWebTables
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void WebTablePractice()
        {
            // Go to website
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites");

            // Create the object of the table
            IWebElement tableElement = driver.FindElement(By.CssSelector("#mw-content-text > div > table:nth-child(2)"));

            // Get all the Rows from the tableElement variable
            List<IWebElement> listTrElement = new List<IWebElement>(tableElement.FindElements(By.TagName("tr")));
            String strRowData = "";

            // Traverse each row
            foreach (var trElement in listTrElement)
            {
                // Get the columns from a particular row
                List<IWebElement> listTdElement = new List<IWebElement>(trElement.FindElements(By.TagName("td")));
                if(listTdElement.Count > 0)
                {
                    // Traverse each column
                    foreach (var tdElement in listTdElement)
                    {
                        strRowData = strRowData + tdElement.Text + "\t\t";
                    }
                }
                else
                {
                    Console.WriteLine("This is Header Row");
                    Console.WriteLine(listTrElement[0].Text.Replace(" ", "\t\t"));
                }
                Console.WriteLine(strRowData);
                strRowData = string.Empty;
            }
            Console.WriteLine("");
            driver.Quit();
        }
    }
}
