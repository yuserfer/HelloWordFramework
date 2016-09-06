using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordFramework
{
    public class HelloWorldGenerator : IHelloWorldGenerator
    {
        protected IMessagePrinter _printer;
        protected HelloWorldGenerator(IMessagePrinter printer)
        {
            _printer = printer;
        }
        public bool SayHello()
        {
            if (_printer != null)
            {
                return _printer.PrintMessage();
            }
            return false;
        }
    }
}
