using Automation_Testing_Project.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Automation_Testing_Project.DataModels
{
    public class LoginData
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginData(int dataSetNumber)
        {
            XMLReader Reader = new XMLReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\TestData\Login.xml"));
            Username = Reader.GetValue(dataSetNumber, "username");
            Password = Reader.GetValue(dataSetNumber, "password");
        }
    }
}
