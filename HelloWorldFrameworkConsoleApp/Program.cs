using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWordFramework;

namespace HelloWorldFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterType printerType = PrinterType.Console;
            if (args.Length > 0)
            {
                printerType = (PrinterType)Enum.Parse(typeof(PrinterType), args[0], true);
            }
            IMessagePrinter printer = MessagePrinterFactory.GetMessagePrinterInstance(printerType);
            IHelloWorldGenerator generator = HelloWorldGeneratorFactory.GetHelloWorldGeneratorInstance(GeneratorType.Console, printer);
            if (generator != null)
            {
                generator.SayHello();
            }
        }
    }
}
