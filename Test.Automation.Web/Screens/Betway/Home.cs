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
        static IWebElement betwaySignUpLoginDialog => remoteWebDriver.FindElement(By.ClassName("/html/body/div[4]/div/div/div/div/div[2]/div/div[1]/a"));

        public static bool ValidateBetwayHomPage()
        {
            WaitForElementToBeDisplay(betwaySignUpLoginDialog);
            return betwaySignUpLoginDialog.Displayed;
        }

        public static void ClickSignUp()
        {
            Click(signUpBtn);
            Click(signUp2Btn);
        }
    }
}
