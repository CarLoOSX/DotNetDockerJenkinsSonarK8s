using HelloWorldMicroService.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloWorldMicroService.Infrastructure.Controllers
{
    [ApiController]
    [Route("HelloWorld")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly HelloWorldApplication _app;
        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
            _app = new HelloWorldApplication();
        }

        [HttpGet]
        public string Get()
        {
            _logger.Log(LogLevel.Trace, $"@Method: [{nameof(HttpGetAttribute.Name)}] @Controller: {nameof(HelloWorldController)}");
            return _app.HelloWorldText();
        }
    }
}