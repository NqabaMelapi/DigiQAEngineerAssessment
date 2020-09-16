using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Test.Automation.Web.Screens.Betway
{
    public class Home : Core.Automation.Web.Selenium.WebDriver
    {
        public Home() { }

        static IWebElement signUpBtn => remoteWebDriver.FindElement(By.Id("SignUp"));
        static IWebElement signUp2Btn => remoteWebDriver.FindElement(By.ClassName("BtnCont"));

        public static void ClickSignUp()
        {
            
            Click(signUpBtn);
            Click(signUp2Btn);
        }
    }
}
