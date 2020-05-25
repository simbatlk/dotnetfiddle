using Logger.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;

namespace Test.Controllers
{
    public class LogTest
    {
        private LogController _logController;

        [SetUp]
        public void Setup()
        {
            var logger = new NullLogger<LogController>();
            _logController = new LogController(logger);
        }

        [Test]
        public void TestLogActionReturnsOkWhenAdUnitIdIsPassed()
        {
            Assert.IsInstanceOf(typeof(OkObjectResult), _logController.Get(123));
        }
        
        [Test]
        public void TestLogActionReturnsBadRequestWhenAdUnitIdIsNotPassed()
        {
            Assert.IsInstanceOf(typeof(BadRequestObjectResult), _logController.Get());
        }
    }
}