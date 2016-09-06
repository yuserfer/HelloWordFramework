using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordFramework
{
    public enum PrinterType
    {
        Console,
        Database,
        File
    }
    public static class MessagePrinterFactory
    {
        public static IMessagePrinter GetMessagePrinterInstance(PrinterType type)
        {
            IMessagePrinter printer = null;
            switch (type)
            {
                case PrinterType.Console:
                    {
                        printer = new ConsoleMessagePrinter();
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            }
            return printer;
        }
    }
}
