using Core.Automation.Web.Selenium;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace Test.Automation.Web.StepBindings
{
    [Binding]
    public class GoogleNewsHeadlineFeatureSteps
    {
        [Given(@"I navigated to Google news website")]
        public void GivenINavigatedToGoogleNewsWebsite()
        {
            WebDriver.OpenBrowser("Chrome");
            WebDriver.NavigateToUrl("https://news.google.com/topstories?hl=en-ZA&gl=ZA&ceid=ZA:en");

        }
        
        [Given(@"the Google headlines page is loaded successfully")]
        public void GivenTheGoogleHeadlinesPageIsLoadedSuccessfully()
        {
            Assert.IsTrue(Screens.GoogleNews.Headlines.ValidateGoogleNewsPage(), "Google News Page Not Found");
        }
        
        [Then(@"I must be able to print all headline on the page")]
        public void ThenIMustBeAbleToPrintAllHeadlineOnThePage()
        {
            Screens.GoogleNews.Headlines.PrintNewsHeadline();
            Assert.IsTrue(Screens.GoogleNews.Headlines.headlinesPrintedSuccessfully, "Headlines printing failed");
        }

        [AfterScenario]
        public void AfterMethod()
        {
            WebDriver.CloseBrowser();
        }
    }
}
