using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinjo.Logs
{

    public class NLogLogger : Contracts.ILogger
    {
        private string applicationName;

        private Logger logger;

        private Contracts.ILogger wrapperLogger;

        public NLogLogger(string applicationName)
        {
            this.applicationName = applicationName;
            wrapperLogger = this;
        }

        public void Debug(string message, params string[] formatters)
        {
            Write(LogLevel.Debug, string.Format(message, formatters));
        }

        public void Error(string message, params string[] formatters)
        {
            Write(LogLevel.Error, string.Format(message, formatters));
        }

        public void Exception(Exception exception)
        {
            Write(LogLevel.Error, exception.Message);
        }

        public void Fatal(string message, params string[] formatters)
        {
            Write(LogLevel.Fatal, string.Format(message, formatters));
        }

        public void Info(string message, params string[] formatters)
        {
            Write(LogLevel.Info, string.Format(message, formatters));
        }

        public void SetCaller(Type callerType)
        {
            logger = LogManager.GetLogger(callerType.FullName);
        }

        public void SetCaller(object caller)
        {
            logger = LogManager.GetLogger(caller.GetType().FullName);
        }

        public void SetWrapper(Contracts.ILogger logger)
        {
            wrapperLogger = logger;
        }

        public void Trace(string message, params string[] formatters)
        {
            Write(LogLevel.Trace, string.Format(message, formatters));
        }

        public void Warn(string message, params string[] formatters)
        {
            Write(LogLevel.Warn, string.Format(message, formatters));
        }

        private void Write(LogLevel logLevel, string message)
        {
            LogEventInfo eventInfo = new LogEventInfo(logLevel, logger.Name, message);

            eventInfo.Properties["application"] = applicationName;

            logger.Log(wrapperLogger.GetType(), eventInfo);
        }
    }
}
