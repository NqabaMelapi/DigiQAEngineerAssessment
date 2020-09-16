using System;
using Core.Automation.Web.Selenium;
using NUnit.Framework;

namespace Test.Automation.Web
{
    public class HeadlinesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PrintAllHeadlines()
        {
            WebDriver.OpenBrowser("Chrome");
            WebDriver.NavigateToUrl("https://news.google.com/topstories?hl=en-ZA&gl=ZA&ceid=ZA:en");

            Screens.GoogleNews.Headlines.PrintNewsHeadline();
        }
    }
}
