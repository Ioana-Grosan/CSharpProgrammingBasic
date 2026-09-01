using Automation_Testing_Project.BasePage;
using Automation_Testing_Project.DataModels;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_Testing_Project.Pages
{
    public class RegisterPage :TestBAsePage
    {
        IWebElement FirstName = driver.FindElement(By.Id("AccountFrm_firstname"));
        IWebElement LastName = driver.FindElement(By.Id("AccountFrm_lastname"));
        IWebElement E_mail = driver.FindElement(By.Id("AccountFrm_email"));
        IWebElement Telephone = driver.FindElement(By.Id("AccountFrm_telephone"));
        IWebElement Fax = driver.FindElement(By.Id("AccountFrm_fax"));
        IWebElement Company = driver.FindElement(By.Id("AccountFrm_company"));
        IWebElement Address_1 = driver.FindElement(By.Id("AccountFrm_address_1"));
        IWebElement Address_2 = driver.FindElement(By.Id("AccountFrm_address_2"));
        IWebElement City = driver.FindElement(By.Id("AccountFrm_city"));
        IWebElement Region_State = driver.FindElement(By.Id("AccountFrm_zone_id"));
        IWebElement Zip_code = driver.FindElement(By.Id("AccountFrm_postcode"));
        IWebElement Country = driver.FindElement(By.Id("AccountFrm_country_id"));
        IWebElement LoginName = driver.FindElement(By.Id("AccountFrm_loginname"));
        IWebElement Password = driver.FindElement(By.Id("AccountFrm_password"));
        IWebElement Password_confirm = driver.FindElement(By.Id("AccountFrm_confirm"));
        IWebElement RegisterButton = driver.FindElement(By.XPath("//*[@class='btn btn-orange pull-right lock-on-click']"));
        

        public void CompleteRegisterDetails(RegisterData registerData)
        {
            EnterFirstName(registerData);
            EnterLastName(registerData);
            EnterE_mail(registerData);
            EnterTelephone(registerData);
            EnterFax(registerData);
            EnterCompany(registerData);
            EnterAddress_1(registerData);
            EnterAddress_2(registerData);
            EnterCity(registerData);
            EnterRegion_State(registerData);
            EnterZip_code(registerData);    
            EnterCountry(registerData);
            EnterLoginName(registerData);   
            EnterPassword(registerData);    
            EnterPassword_confirm(registerData);
            RegisterButton.Click();
        }

        public void CheckIfErrorMessageIsDisplayed()
        {
            IWebElement RegisterErrorMessage = driver.FindElement(By.XPath("//*[@class='alert alert-error alert-danger']"));
            Assert.IsTrue(RegisterErrorMessage.Displayed);
        }
        private void EnterFirstName(RegisterData registerData)
        {
            SendKey(FirstName, registerData.FirstName);
        }
        private void EnterLastName(RegisterData registerData)
        {
            SendKey(LastName, registerData.LastName);
        }
        private void EnterE_mail(RegisterData registerData)
        {
            SendKey(E_mail, registerData.E_mail);
        }
        private void EnterTelephone(RegisterData registerData)
        {
            SendKey(Telephone, registerData.Telephone);
        }
        private void EnterFax(RegisterData registerData)
        {
            SendKey(Fax, registerData.Fax);
        }
        private void EnterCompany(RegisterData registerData)
        {
            SendKey(Company, registerData.Company);
        }
        private void EnterAddress_1(RegisterData registerData)
        {
            SendKey(Address_1, registerData.Address_1);
        }
        private void EnterAddress_2(RegisterData registerData)
        {
            SendKey(Address_2, registerData.Address_2);
        }
        private void EnterCity(RegisterData registerData)
        {
            SendKey(City, registerData.City);
        }
        private void EnterRegion_State(RegisterData registerData)
        {
            SendKey(Region_State, registerData.Region_State);
        }
        private void EnterZip_code(RegisterData registerData)
        {
            SendKey(Zip_code, registerData.Zip_code);
        }
        private void EnterLoginName(RegisterData registerData)
        {
            SendKey(LoginName, registerData.Login_name);
        }
        private void EnterCountry(RegisterData registerData)
        {
            SendKey(Country, registerData.Country);
        }
        private void EnterPassword(RegisterData registerData)
        {
            SendKey(Password, registerData.password);
        }

        private void EnterPassword_confirm(RegisterData registerData)
        {
            SendKey(Password_confirm, registerData.password_confirm);
        }
        
    }
}
