using Microsoft.Extensions.Logging.Debug;

namespace AuthorizeNet.Utilities
{
    using System;
    using Microsoft.Extensions.Logging;

    public static class LogFactory
    {
        static LogFactory()
        {
            LoggerFactory.AddProvider(new DebugLoggerProvider());
        }
        
        private static ILoggerFactory LoggerFactory => new LoggerFactory();

        public static ILogger getLog(Type classType)
        {
            return LoggerFactory.CreateLogger(classType.FullName);
        }
    }
}
