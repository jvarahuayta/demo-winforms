using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinjo.Logs.Contracts
{
    public interface ILogger
    {
        void SetCaller(object caller);

        void SetCaller(Type callerType);

        void Trace(string message, params string[] formatters);

        void Debug(string message, params string[] formatters);

        void Info(string message, params string[] formatters);

        void Warn(string message, params string[] formatters);

        void Error(string message, params string[] formatters);

        void Fatal(string message, params string[] formatters);

        void Exception(Exception exception);

        void SetWrapper(ILogger logger);
    }
}
