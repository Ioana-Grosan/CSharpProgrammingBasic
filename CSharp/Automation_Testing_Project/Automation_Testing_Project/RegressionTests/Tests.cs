using Automation_Testing_Project.Pages;
using NUnit.Framework;

namespace Automation_Testing_Project.regressionTests
{
    using Automation_Testing_Project.BasePage;
    using Automation_Testing_Project.DataModels;
    using NUnit.Framework.Internal;
    using System.Collections.Generic;
    using System.Xml.Linq;

    public class Tests: TestBAsePage 
    {
       public static IEnumerable<TestCaseData>GetLoginData()
        {
            var doc = XDocument.Load("TestData/Login.xml");
            foreach (var dataSet in doc.Root.Elements())
            {
                string description = dataSet.Attribute("description")?.Value;
                string username =dataSet.Element("username")?.Value;
                string password = dataSet.Element("password")?.Value;
                yield return new TestCaseData(username, password).SetName(description);


            }
        }
        [Test]
        public void OpenBrowserTest()
        {
            
            Homepage homePage = new Homepage();
            homePage.GoToLoginPage();
            LoginPage loginPage = new LoginPage();
            Assert.IsTrue(loginPage.RegisterAccountCheckBox.Displayed);
        }
        [Test]
        public void Test_ErrorMessageForWrongUsername()
        {
            Homepage homePage = new Homepage();
            homePage.GoToLoginPage();
            LoginPage loginPage = new LoginPage();
            Assert.IsTrue(loginPage.RegisterAccountCheckBox.Displayed);
            loginPage.CompleteLoginDetails(new LoginData(1));
            loginPage.CheckIfErrorMessageIsDisplayed();
        }
        [Test]
        public void Test_ErrorMessageForWrongPassword()
        {
            Homepage homePage = new Homepage();
            homePage.GoToLoginPage();
            LoginPage loginPage = new LoginPage();
            Assert.IsTrue(loginPage.RegisterAccountCheckBox.Displayed);
            loginPage.CompleteLoginDetails(new LoginData(2));
            loginPage.CheckIfErrorMessageIsDisplayed();
        }
        [Test]
        public void Test_ErrorMessageForEmptyPassword()
        {
            Homepage homePage = new Homepage();
            homePage.GoToLoginPage();
            LoginPage loginPage = new LoginPage();
            Assert.IsTrue(loginPage.RegisterAccountCheckBox.Displayed);
            loginPage.CompleteLoginDetails(new LoginData(3));
            loginPage.CheckIfErrorMessageIsDisplayed();
        }
        [Test]
        public void Test_AddExistentUserErrorMessage()
        {
            Homepage homePage = new Homepage();
            homePage.GoToLoginPage();
            LoginPage loginPage = new LoginPage();
            Assert.IsTrue(loginPage.RegisterAccountCheckBox.Displayed);
            loginPage.GoToRegisterPage();
            RegisterPage register = new RegisterPage();
            register.CompleteRegisterDetails(new RegisterData(1));
            register.CheckIfErrorMessageIsDisplayed();
            
        }

    }
}
