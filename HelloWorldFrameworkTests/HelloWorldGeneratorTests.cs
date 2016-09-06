using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWordFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordFramework.Tests
{
    [TestClass()]
    public class HelloWorldGeneratorTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            IHelloWorldGenerator generator = null;

            try
            {
                IMessagePrinter printer = MessagePrinterFactory.GetMessagePrinterInstance(PrinterType.Console);
                generator = HelloWorldGeneratorFactory.GetHelloWorldGeneratorInstance(GeneratorType.Console, printer);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            Assert.IsTrue(generator != null, "Failed to create HelloWorldGenerator for {0} type.", GeneratorType.Console);

            Assert.IsTrue(generator.SayHello(), "Can't Say Hello World! Something went wrong!");

            try
            {
                IMessagePrinter printer = MessagePrinterFactory.GetMessagePrinterInstance(PrinterType.Console);
                generator = HelloWorldGeneratorFactory.GetHelloWorldGeneratorInstance(GeneratorType.Mobile, printer);
            }
            catch (Exception ex)
            {
                if (!(ex is NotImplementedException))
                {
                    Assert.Fail(ex.Message);
                }
            }

        }
    }
}