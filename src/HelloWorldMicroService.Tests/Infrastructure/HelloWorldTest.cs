using HelloWorldMicroService.Infrastructure.Controllers;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace HelloWorldMicroService.Tests.Infrastructure
{
    public class HelloWorldTest
    {
        private HelloWorldController controller;

        [SetUp]
        public void Setup()
        {
            var logger = new LoggerFactory().CreateLogger<HelloWorldController>();

            controller = new HelloWorldController(logger);
        }

        [Test]
        public void AssertHelloWorldIsShown()
        {
            Assert.AreEqual(controller.Get(), AppResources.Hello_World);
        }
    }
}