using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ToolsQA.SeleniumBasics
{
    [TestFixture]
    class CheckBoxAndRadioButtonOperators
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void PracticeExercise()
        {
            // Go to automation practice form
            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-form/");

            // Challenge One - Selected the deslected Radio Button (Female) for category Sex (Use Selected method)
            IList<IWebElement> rdBtn_Sex = driver.FindElements(By.Name("sex"));
            bool bValue = false;

            bValue = rdBtn_Sex.ElementAt(0).Selected;

            if (bValue == false)
                rdBtn_Sex.ElementAt(1).Click();
            else
                rdBtn_Sex.ElementAt(0).Click();
            Assert.AreEqual("Female", rdBtn_Sex.ElementAt(1).GetAttribute("value"));

            // Challenge Two - Selected the Third radio button for cateofry 'Year of Exp' (Use Id attribute to select Radio Button)
            driver.FindElement(By.Id("exp-2")).Click();

            // Challenge Three - Check the Check Box 'Automation Tester' for category 'Profession' (Use Value attribute to match the selection)
            IList<IWebElement> checkBoxProfession = driver.FindElements(By.Name("profession"));

            if (checkBoxProfession.ElementAt(0).GetAttribute("value") == "Automation Tester")
                checkBoxProfession.ElementAt(0).Click();
            else
                checkBoxProfession.ElementAt(1).Click();


            // Challenge Four - Check the Check Box 'Selenium IDE' for category 'Automation Tool' (Use CssSelector)
            driver.FindElement(By.CssSelector("#tool-1")).Click();

            // Quit browser session
            driver.Quit();
        }

    }
}
