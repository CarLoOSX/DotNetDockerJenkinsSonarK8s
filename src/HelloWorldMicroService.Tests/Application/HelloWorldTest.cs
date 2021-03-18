using HelloWorldMicroService.Application;
using HelloWorldMicroService.Infrastructure.Controllers;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace HelloWorldMicroService.Tests.Application
{
    public class HelloWorldTest
    {
        private HelloWorldApplication _application;

        [SetUp]
        public void Setup()
        {
            var logger = new LoggerFactory().CreateLogger<HelloWorldController>();

            _application = new HelloWorldApplication();
        }

        [Test]
        public void AssertHelloWorldIsShown()
        {
            Assert.AreEqual(_application.HelloWorldText(), "Hello World!!!!!!!!!!!!!");
        }
    }
}