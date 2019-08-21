using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;

namespace TestApp.XPathResults
{
    public abstract class XPathResultBase
    {
        protected object result;

        public virtual object GetRawResult()
        {
            return result;
        }
        public abstract override string ToString();
    }

    public class XPathStringResult:XPathResultBase
    {
        private string stringResult;

        public XPathStringResult(object result)
        {
            this.result = result;
            stringResult = (string)result;
        }

        public override string ToString()
        {
            return stringResult;
        }
    }

    public class XPathBooleanResult:XPathResultBase
    {
        private bool boolResult;

        public XPathBooleanResult(object result)
        {
            this.result = result;
            boolResult = (bool)result;
        }

        public override string ToString()
        {
            return boolResult.ToString();
        }
    }

    public class XPathErrorResult: XPathResultBase
    {
        private Exception exception;

        public XPathErrorResult(object result)
        {
            this.result = result;
            exception = (Exception)result;
        }

        public override string ToString()
        {
            MessageBox.Show("An Error occured!");
            return exception.Message;
        }
    }

    public class XPathNumberResult : XPathResultBase
    {
        public XPathNumberResult(object result)
        {
            this.result = result;
        }

        public override string ToString()
        {
            return result.ToString();
        }
    }

    public class XPathCollectionResult:XPathResultBase
    {
        private XPathNodeIterator xPathNodeIterator;

        public XPathCollectionResult(object result)
        {
            this.result = result;
            xPathNodeIterator = (XPathNodeIterator)result;
        }

        public override string ToString()
        {
            string result = "";


            //foreach (var elem in xPathNodeIterator)
            //{
            //    result += $"{xPathNodeIterator.Current.ToString()}\n";
            //}

            while (xPathNodeIterator.MoveNext())
            {
                result += $"{xPathNodeIterator.Current.ToString()}\n";
            }

            return result;
        }
    }
}