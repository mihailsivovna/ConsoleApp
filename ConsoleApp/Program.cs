using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.instagram.com/");
            Console.WriteLine(driver.Title);
            

            IWebElement Phone = driver.FindElement(By.Name("emailOrPhone"));
            Phone.SendKeys("mihailsivovna12@gmail.com");

            IWebElement Name = driver.FindElement(By.Name("fullName"));
            Name.SendKeys("Михаил Сивовна");

            IWebElement UserName = driver.FindElement(By.Name("username"));
            UserName.SendKeys("mihail_sivovna");

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("mihail2018");

            IWebElement registration = driver.FindElement(By.CssSelector("button[type=submit]"));
            registration.Click();

        }
    }
}
