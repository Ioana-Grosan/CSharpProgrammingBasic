using Automation_Testing_Project.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_Testing_Project.Pages
{
    public class Homepage : TestBAsePage    
    {
        public void GoToLoginPage()
        {
            IWebElement loginButton = driver.FindElement(By.Id("customer_menu_top"));
            loginButton.Click();

        }
    }
}
