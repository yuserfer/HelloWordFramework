using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordFramework
{
    public class ConsoleMessagePrinter : IMessagePrinter
    {
        public bool PrintMessage()
        {
            bool result = true;
            try
            {
                Console.WriteLine("Hello World!");
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}
