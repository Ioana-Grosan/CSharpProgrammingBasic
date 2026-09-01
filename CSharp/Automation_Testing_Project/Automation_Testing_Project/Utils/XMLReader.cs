
using OpenQA.Selenium.DevTools.V150.DOM;
using System.Xml;

namespace Automation_Testing_Project.Utils
{
    public class XMLReader
    {
        XmlDocument doc;
        string filePath;

        public XMLReader(string filePath)
        {
            this.filePath = filePath;
            doc = new XmlDocument();
            doc.Load(filePath);

        }
        public string GetValue(int dataSetNumber, string attribute)
        {
            string attributeVAlue = "";
            XmlNodeList XMLDocNodes = doc.SelectNodes("/dataSets/dataSet_" + dataSetNumber + "/"  + attribute);
            foreach (XmlNode node in XMLDocNodes)
            {
                attributeVAlue += node.InnerText;
            }
            return attributeVAlue;
        }
    }
}
