using Core.Automation.Web.Selenium;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Test.Automation.Web.Model;

namespace Test.Automation.Web.FeatureSteps
{
    [Binding]
    public class BetwayRegistrationFeatureSteps
    {


        [Given(@"I navigate to Betway website")]
        public void GivenINavigateToBetwayWebsite()
        {


            WebDriver.OpenBrowser("Chrome");
            WebDriver.NavigateToUrl("https://www.betway.co.za");



        }
        
        [Given(@"the page loads successfully")]
        public void GivenThePageLoadsSuccessfully()
        {

        }
        
        
        [Then(@"I should be able to register as new user")]
        public void ThenIShouldBeAbleToRegisterAsNewUser()
        {
            RegisterModel model = new RegisterModel
            {
                MobileNumber = "812653408",
                Password = "BatWayne",
                FirstName = "Bruce",
                Surname = "Wayne",
                Email = "brucewayne@wayneenterprises.com",
                IdType = "South African ID",
                IdNumber = "9009267364727",
                DOBDay = "26",
                DOBMonth = "September",
                DOBYear = "1990",
                SourceOfFunds = "Self Employed",
            };

            Screens.Betway.Home.ClickSignUp();
            Screens.Betway.Register.RegisterAnAccount(model);

            Assert.IsTrue(Screens.Betway.Register.registrationCompletedSuccessfully, "Registration failed error");
        }

        [AfterScenario("CloseBrowser")]
        public void CloseBrowser()
        {
            WebDriver.CloseBrowser();
        }
    }
}
