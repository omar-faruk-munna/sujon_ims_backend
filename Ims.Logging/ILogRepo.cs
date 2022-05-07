using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ims.Logging
{
    public interface ILogRepo
    {
        //void LogSmsSuccess(string filePath, string productId, string accountNo, string sendTo, string message, string status);
        //void LogSmsFailed(string filePath, string productId, string accountNo, string sendTo, string message, string status);
        //void LogEmailSuccess(string filePath, string productId, string accountNo, string sendTo, string message, string status);
        //void LogEmailFailed(string filePath, string productId, string accountNo, string sendTo, string message, string status);
        void LogError(string errorMessage);
        void LogEveryStep(string logMessage);
    }
}
