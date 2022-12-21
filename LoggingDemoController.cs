using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning_Logging
{
    public class LoggingDemoController:Controller
    {
        private readonly ILogger<LoggingDemoController> _logger;
        public LoggingDemoController(ILogger<LoggingDemoController> logger)
        {
            _logger = logger;       
        }

        public void sampleMethod()
        {
            _logger.LogTrace("");
            _logger.LogTrace("");
            _logger.LogInformation("");
            _logger.LogCritical("");
            _logger.LogDebug("");
            _logger.LogError("");
            _logger.LogWarning("");
        }
    }
}
