using HelloWorldMicroService.Domain;

namespace HelloWorldMicroService.Application
{
    public class HelloWorldApplication
    {
        private readonly HelloWorldDomainService _domain;

        public HelloWorldApplication()
        {
            _domain = new HelloWorldDomainService();
        }

        public string HelloWorldText()
        {
           return _domain.HelloWorldText();
        }
    }
}