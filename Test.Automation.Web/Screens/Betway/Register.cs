using System;
using OpenQA.Selenium;
using Test.Automation.Web.Model;

namespace Test.Automation.Web.Screens.Betway
{
    public class Register : Core.Automation.Web.Selenium.WebDriver
    {
        public Register()
        {
        }

        static IWebElement mobileNumberField => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[1].Value"));
        static IWebElement passwordField => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[2].Value"));
        static IWebElement firstNameField => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[4].Value"));
        static IWebElement suranmeField => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[5].Value"));
        static IWebElement emailField => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[6].Value"));
        static IWebElement nextBtn => remoteWebDriver.FindElement(By.Id("nxtBtn"));
        static IWebElement idTypeDropdown => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[11].Value"));
        static IWebElement idNoField => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[12].Value"));
        static IWebElement dobDayField => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[13].Value.Day"));
        static IWebElement dobMonthField => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[13].Value.Month"));
        static IWebElement dobYearField => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[13].Value.Year"));
        static IWebElement sourcOfFundsDropdown => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[14].Value"));
        static IWebElement over18CheckBox => remoteWebDriver.FindElement(By.Name("Template.TemplateFieldModels[16].Value"));
        static IWebElement registerBtn => remoteWebDriver.FindElement(By.Id("regBtn"));

        public static bool registrationCompletedSuccessfully = false;

        public static void RegisterAnAccount(RegisterModel registerModel)
        {
            try
            {

                EnterText(mobileNumberField, registerModel.MobileNumber);
                EnterText(passwordField, registerModel.Password);
                EnterText(firstNameField, registerModel.FirstName);
                EnterText(suranmeField, registerModel.Surname);
                EnterText(emailField, registerModel.Email);

                Click(nextBtn);

                SelectDropdownByText(idTypeDropdown, registerModel.IdType);
                EnterText(idNoField, registerModel.IdNumber);

                SelectDropdownByText(dobDayField, registerModel.DOBDay);
                SelectDropdownByText(dobMonthField, registerModel.DOBMonth);
                SelectDropdownByText(dobYearField, registerModel.DOBYear);

                SelectDropdownByText(sourcOfFundsDropdown, registerModel.SourceOfFunds);

                Click(over18CheckBox);

                registrationCompletedSuccessfully = true;

            }
            catch (Exception e)
            {
                Console.Write("Registration failed with error {0}: ",e.Message);
            }
        }

    }

}