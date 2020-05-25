using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using WebApplication.Controllers; 

namespace Tests.Controllers
{
    public class LogTest
    {
        private LogController _logController;

        [SetUp]
        public void Setup()
        {
            var logger = new NullLogger<LogController>();
            this._logController = new LogController(logger);
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