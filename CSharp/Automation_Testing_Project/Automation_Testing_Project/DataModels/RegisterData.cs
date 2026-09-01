using Automation_Testing_Project.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_Testing_Project.DataModels
{
    public class RegisterData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string E_mail { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Company { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public string Region_State { get; set; }
        public string Zip_code { get; set; }
        public string Country { get; set; }
        public string Login_name { get; set; }
        public string password { get; set; }
        public string password_confirm { get; set; }

    
     public RegisterData(int dataSetNumber)
        {
            XMLReader Reader = new XMLReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\TestData\Register.xml"));
            FirstName = Reader.GetValue(dataSetNumber, "FirstName");
            LastName = Reader.GetValue(dataSetNumber, "LastName");
            E_mail = Reader.GetValue(dataSetNumber, "E_mail");
            Telephone = Reader.GetValue(dataSetNumber, "Telephone");
            Fax = Reader.GetValue(dataSetNumber, "Fax");
            Company = Reader.GetValue(dataSetNumber, "Company");
            Address_1 = Reader.GetValue(dataSetNumber, "Address_1");
            Address_2 = Reader.GetValue(dataSetNumber, "Address_2");
            City = Reader.GetValue(dataSetNumber, "City");
            Region_State = Reader.GetValue(dataSetNumber, "Region_State");
            Zip_code = Reader.GetValue(dataSetNumber, "Zip_code");
            Country = Reader.GetValue(dataSetNumber, "Country");
            Login_name = Reader.GetValue(dataSetNumber, "Login_name");
            password = Reader.GetValue(dataSetNumber, "password");
            password_confirm = Reader.GetValue(dataSetNumber, "password_confirm");
        }
    }
}