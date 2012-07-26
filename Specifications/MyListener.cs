using System;
namespace Specifications
{
    public class MyListener : TechTalk.SpecFlow.Tracing.ITraceListener
    {
        #region Implementation of ITraceListener

        public void WriteTestOutput(string message)
        {
            Console.WriteLine(message);
            /*
            if (message.Contains(":"))
            {
                Console.WriteLine(string.Format("{0}\t\t{1}", message, "FAILED"));
            }
            else
            {
                Console.WriteLine(string.Format("{0}\t\t{1}", message, "PASSED"));
            }*/
        }

        public void WriteToolOutput(string message)
        {
            if (message.Contains(":"))
            {
                Console.Write(string.Format("{0}\t\t{1}", message, "FAILED"));
            }
            else
            {
                Console.Write(string.Format("{0}\t\t{1}", message, "PASSED"));
            }
        }

        #endregion
    }
}
