using HelloWorldMicroService.Domain;
using HelloWorldMicroService.Infrastructure.Controllers;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace HelloWorldMicroService.Tests.Domain
{
    public class HelloWorldTest
    {
        private HelloWorldDomainService _domain;

        [SetUp]
        public void Setup()
        {
            var logger = new LoggerFactory().CreateLogger<HelloWorldController>();

            _domain = new HelloWorldDomainService();
        }

        [Test]
        public void AssertHelloWorldIsShown()
        {
            Assert.AreEqual(_domain.HelloWorldText(), "Hola Mundo");
        }
    }
}