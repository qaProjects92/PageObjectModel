using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
    public class LoginPage
    {

        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement usernameField;


        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordField;


        [FindsBy(How = How.Id, Using = "login-button")]
        private IWebElement submitLoginForm;

        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void login(string username, string password)
        {
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
            submitLoginForm.Click();
        }

    }
}
