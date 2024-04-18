using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Automation_Project
{
    public class Login
    {
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void LoginTest()
        {
            var url = "http://saucedemo.com";
            var expected_url = url;
            driver.Navigate().GoToUrl(url);

            Assert.AreEqual(expected_url, url);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string screenShootsDirectory = Directory.GetCurrentDirectory() + @"\screenshots";


            if (Directory.Exists(screenShootsDirectory))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshot");
            }

            screenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshot\googlescreenshot.png");

            var username_input = driver.FindElement(By.Id("user-name"));
            var password_input = driver.FindElement(By.Id("password"));

            username_input.SendKeys("standard_user");
            password_input.SendKeys("secret_sauce");

            var login_button = driver.FindElement(By.Id("login-button"));
            login_button.Click();

        }
    }
}
