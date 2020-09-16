using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Test.Automation.Web.Screens.GoogleNews
{
    public class Headlines : Core.Automation.Web.Selenium.WebDriver
    {
        public Headlines()
        {
        }

        public static bool headlinesPrintedSuccessfully = false;
        static IWebElement headlinesTitle => remoteWebDriver.FindElement(By.XPath("/html/body/c-wiz/div/div[2]/div[2]/div/main/c-wiz/div[1]/div[1]/div[1]/h2/span/a"));

        static IWebElement articlesContainer => remoteWebDriver.FindElement(By.XPath("/html/body/c-wiz/div/div[2]/div[2]/div/main/c-wiz/div[1]"));
        static string articleTitle = "/html/body/c-wiz/div/div[2]/div[2]/div/main/c-wiz/div[1]/div[{0}]/div/div/article/h3/a";


        static string headline = string.Empty;

        public static bool ValidateGoogleNewsPage()
        {
            WaitForElementToBeDisplay(headlinesTitle);
            return headlinesTitle.Displayed;
        }

        public static void PrintNewsHeadline()
        {

            try
            {
                WaitForElementToBeDisplay(articlesContainer);

                IList<IWebElement> articles = articlesContainer.FindElements(By.TagName("article"));

                int articleCount = articles.Count;

                Console.WriteLine("Today's Headline:");
                Console.WriteLine("");

                /*foreach (IWebElement article in articles)
                {
                   if (article.FindElement(By.TagName("h3")).FindElement(By.TagName("a")).Displayed)
                    {
                        headline = article.FindElement(By.TagName("h3")).FindElement(By.TagName("a")).Text;

                        //headline = article.FindElement(By.XPath(articleTitle.Replace("{0}", articleCount.ToString()))).Text;
                        Console.WriteLine(" - {0} ", headline);
                        Console.WriteLine("");

                    }


                }*/

                for (int i = 3; i < articleCount; i++)
                {
                    if (remoteWebDriver.FindElement(By.XPath(articleTitle.Replace("{0}", i.ToString()))).Displayed)
                    {
                        headline = remoteWebDriver.FindElement(By.XPath(articleTitle.Replace("{0}", i.ToString()))).Text;
                        Console.WriteLine(" - {0} ", headline);
                        Console.WriteLine("");
                    }
                }

                headlinesPrintedSuccessfully = true;
            }
            catch(Exception e)
            {
                Console.Write("Printing headlines faild with error message: {0}", e.Message);
            }
           
        }
    }
}
