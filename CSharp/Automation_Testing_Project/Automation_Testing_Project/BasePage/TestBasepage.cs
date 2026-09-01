using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Automation_Testing_Project.BasePage
{
    public class TestBAsePage
    {
        public static IWebDriver driver;
        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new ChromeDriver();
                }
                return driver;
            }
        }
      
        [SetUp]
        public void OpenBrowser()
        {
            Driver.Navigate().GoToUrl("https://www.automationteststore.com/");
        }
        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
            driver = null;
        }

        public void SendKey  (IWebElement element, string text)
        {
            if (!string.IsNullOrEmpty(text)) 
            {
                element.SendKeys(text);
            }
        }
            
     }
}
