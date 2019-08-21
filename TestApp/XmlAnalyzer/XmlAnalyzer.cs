using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace TestApp.XmlAnalyzer
{
    class XmlAnalyzer
    {
        public XmlAnalyzer() { }

        public string GetXPathResult(string xpath, string fileName)
        {
            XPathDocument document = new XPathDocument(fileName);
            XPathNavigator navigator = document.CreateNavigator();
            XPathResults.XPathResultBase result = null;
            try
            {
                XPathExpression expression = XPathExpression.Compile(xpath);
                result = XPathResultFactory.Evaluate(expression, navigator);
            } catch (XPathException exception)
            {
                result = XPathResultFactory.Evaluate(null, null, exception);
            }

            return result.ToString();
        }
    }
}