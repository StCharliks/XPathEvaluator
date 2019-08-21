using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using TestApp.XPathResults;


namespace TestApp
{
    public static class XPathResultFactory
    {
        public static XPathResultBase Evaluate(XPathExpression expression, XPathNavigator navigator, Exception exception = null)
        {
            XPathResultBase xPathResult = null;

            if (exception != null)
            {
                xPathResult = new XPathErrorResult(exception);
                return xPathResult;
            }

            switch (expression.ReturnType)
            {
                case XPathResultType.Number:
                    xPathResult = new XPathNumberResult(navigator.Evaluate(expression));
                    break;

                case XPathResultType.NodeSet:
                    xPathResult = new XPathCollectionResult(navigator.Select(expression));
                    break;

                case XPathResultType.Boolean:
                    xPathResult = new XPathBooleanResult(navigator.Evaluate(expression));
                    break;

                case XPathResultType.String:
                    xPathResult = new XPathStringResult(navigator.Evaluate(expression));
                    break;

            }

            return xPathResult;
        }
    }
}