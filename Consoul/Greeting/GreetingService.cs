using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consoul.Greeting
{
    public class GreetingService : IGreetingService
    {
        private ILogger<GreetingService> _logger;
        private IConfiguration _configuration;

        public GreetingService(ILogger<GreetingService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void Run()
        {
            _logger.LogInformation("Greeting from service :p");
        }
    }
}
