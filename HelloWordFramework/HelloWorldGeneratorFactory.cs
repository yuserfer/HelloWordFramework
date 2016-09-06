using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordFramework
{
    public enum GeneratorType
    {
        Console,
        Web,
        Service,
        Mobile
    }
    public static class HelloWorldGeneratorFactory
    {
        public static IHelloWorldGenerator GetHelloWorldGeneratorInstance(GeneratorType type, IMessagePrinter printer)
        {
            IHelloWorldGenerator generator = null;
            switch (type)
            {
                case GeneratorType.Console:
                    {
                        generator = new HelloWorldGeneratorConsole(printer);
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            }
            return generator;
        }
    }
}
