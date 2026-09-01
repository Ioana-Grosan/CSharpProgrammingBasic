using Automation_Testing_Project.BasePage;
using Automation_Testing_Project.DataModels;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_Testing_Project.Pages
{
    public  class LoginPage : TestBAsePage
    {
        #region Elements
        IWebElement LoginButton => driver.FindElement(By.XPath("//*[@type='submit'][@title='Login']"));
        IWebElement ContinueButton => driver.FindElement(By.XPath("//*[@type='submit'][@title='Continue']"));
        IWebElement Username =>driver.FindElement(By.XPath("//*[@id='loginFrm_loginname']"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='loginFrm_password']"));
        public IWebElement RegisterAccountCheckBox => driver.FindElement(By.Id("accountFrm_accountregister"));
        #endregion

        #region Methods
        public void CompleteLoginDetails   (LoginData loginData)
        {
            CompleteUsername(loginData);
            CompletePassword(loginData);
            Thread.Sleep(3000);
            LoginButton.Click();
        }

        public void GoToRegisterPage()
        {
            ContinueButton.Click();
        }

        public void CheckIfErrorMessageIsDisplayed()
        {
            IWebElement LoginErrorMessage = driver.FindElement(By.XPath("//*[@class='alert alert-error alert-danger']"));
            Assert.IsTrue(LoginErrorMessage.Displayed);
        }
        private void CompleteUsername (LoginData loginData)
        {
            SendKey(Username, loginData.Username);
        }
        private void CompletePassword(LoginData loginData)
        {
            SendKey(Password, loginData.Password);
        }
        #endregion
        
    }
       
}

