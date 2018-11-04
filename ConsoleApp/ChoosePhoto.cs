using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.App
{
    public class ChoosePhoto

    {
        private IWebDriver driver;

        public ChoosePhoto(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ChoosePhotos()
        {
            IWebElement photo = driver.FindElement(By.XPath("//img[@class='_11kf img']"));
            photo.Click();
        }

        public void LikePhotos()

        {
          
            for (int i = 0; i<=6; i++)
            {
                driver.FindElement(By.XPath("//form[contains(@class,'fbPhotosSnowliftFeedbackForm')]//a[contains(@class,'UFILikeLink')]")).Click();
                Thread.Sleep(500);
                driver.FindElement(By.ClassName("snowliftPager")).Click();
                Thread.Sleep(1000);

            }

        }
    }
}



