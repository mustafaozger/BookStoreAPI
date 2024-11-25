using NLog;
using Services.Contracts;

namespace Services
{
    public class LogerManager : ILoggerService
    {
        public static ILogger lof =LogManager.Get;
        public void LogDebug(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(string message)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string message)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string message)
        {
            throw new NotImplementedException();
        }
    }
}