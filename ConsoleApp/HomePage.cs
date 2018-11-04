using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.App
{
    public class HomePage
    
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickProfile()
        {
            IWebElement profile = driver.FindElement(By.ClassName("_1vp5"));
            profile.Click();
        }

        public void ClickFriend()
        {
            IWebElement friends = driver.FindElement(By.XPath("//a[@data-tab-key='friends']"));
            friends.Click();

        }

        public void ChooseFriend()
        {
            IWebElement friend = driver.FindElement(By.XPath("//div[@class ='fsl fwb fcb']"));
            friend.Click();
        }

    }
}





