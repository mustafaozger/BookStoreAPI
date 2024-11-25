using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ILoggerService
    {  
        public void LogDebug(string message);
        public void LogError(string message);
        public void LogInfo(string message);
        public void LogWarning(string message);
       
    }
}