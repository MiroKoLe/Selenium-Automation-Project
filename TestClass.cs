using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Selenium_Automation_Project
{
    public class TestClass
    {
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void LoginTest() 
        {jhgjghjghjgh
            var url = "http://saucedemo.com";
            var expected_url = url;
            driver.Navigate().GoToUrl(url);

            Assert.AreEqual(expected_url, url);

            var username_input = driver.FindElement(By.Id("user-name"));
            var password_input = driver.FindElement(By.Id("password"));

            username_input.SendKeys("standard_user");
            password_input.SendKeys("secret_sauce");

            var login_button = driver.FindElement(By.Id("login-button"));
            login_button.Click();

        }
    }
}
