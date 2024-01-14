using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PageObjectModel.Test
{
    public class LoginTest
    {

        private IWebDriver driver;

        [SetUp]
        public void setUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test]
        public void loginTest() {
        
            LoginPage loginPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            loginPage.login("standard_user", "secret_sauce");
            Assert.True(driver.Title.Contains("Swag Labs"));
        }

        [TearDown] public void tearDown()
        {
            driver.Quit();
        }
    }
}
