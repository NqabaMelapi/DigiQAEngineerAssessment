using System;
using NUnit.Framework;
using Core.Automation.Web.Selenium;
using Test.Automation.Web.Model;


namespace Test.Automation.Web
{
    public class BetwayTest
    {

        [TearDown]
        public void CleanUp()
        {
            WebDriver.CloseBrowser();
        }

        [Test]
        public void BetwayRegistration()
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

            WebDriver.OpenBrowser("Chrome");
            WebDriver.NavigateToUrl("https://www.betway.co.za");
            Screens.Betway.Home.ClickSignUp();
            Screens.Betway.Register.RegisterAnAccount(model);



        }


    }
}