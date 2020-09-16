using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Core.Automation.Web.Selenium
{
    public class DesiredCapabilities
    {

        public static ChromeOptions ChromeDesiredCapabilities()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            return options;
        }

        public static FirefoxOptions FirefoxDesiredCapabilities()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("no-sandbox");
            return options;
        }
    }
}
