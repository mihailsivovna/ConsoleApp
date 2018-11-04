using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
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

            }

            public void Login()
            {
                IWebElement closenotification = driver.FindElement(By.Id("loginbutton"));
                closenotification.Click();
            }
        }
    }





