using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.App
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Open()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Console.WriteLine(driver.Title);
        }

        public void EnterLogin(string login)
        {
            IWebElement username = driver.FindElement(By.Name("email"));
            username.SendKeys(login);
        }

        public void EnterPassword(string pass)
        {
            IWebElement password = driver.FindElement(By.Name("pass"));
            password.SendKeys(pass);
            Thread.Sleep(2000);
        }

        public void Login()
        {
            IWebElement closenotification = driver.FindElement(By.Id("loginbutton"));
            closenotification.Click();
        }
    }
}