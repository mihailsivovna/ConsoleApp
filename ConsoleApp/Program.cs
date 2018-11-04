using Automation.App;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        

        public static void Main(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            LoginPage login = new LoginPage(driver);
            login.Open();
            login.EnterLogin("");
            login.EnterPassword("");
            login.Login();

            HomePage profile = new HomePage(driver);
            profile.ClickProfile();
            profile.ClickFriend();
            profile.ChooseFriend();

            Thread.Sleep(2000);
            ChoosePhoto photo = new ChoosePhoto(driver);
            Thread.Sleep(2000);
            photo.ChoosePhotos();
            Thread.Sleep(2000);
            photo.LikePhotos();
            Thread.Sleep(2000);

            driver.Quit();

        }

    }
}
