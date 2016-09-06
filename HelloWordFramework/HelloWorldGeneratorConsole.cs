using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordFramework
{
    public class HelloWorldGeneratorConsole : HelloWorldGenerator
    {
        public HelloWorldGeneratorConsole(IMessagePrinter printer)
            : base(printer)
            {}
    }
}
