using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace Ims.Logging
{
    public class LogRepo : ILogRepo
    {
        private static readonly ILog smsSuccess = LogManager.GetLogger("SmsSuccess");
        private static readonly ILog smsFail = LogManager.GetLogger("SmsFail");
        private static readonly ILog emailSuccess = LogManager.GetLogger("EmailSuccess");
        private static readonly ILog emailFail = LogManager.GetLogger("EmailFail");
        private static readonly ILog errorLog = LogManager.GetLogger("ErrorLog");
        private static readonly ILog logLicense = LogManager.GetLogger("LogLicense");
        private static readonly ILog logEveryStep = LogManager.GetLogger("LogEveryStep");

        public void LogSmsSuccess(string filePath,
            string productId,
            string accountNo,
            string sendTo,
            string message,
            string status)
        {
            try
            {
                var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
                XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

                string messageFormat = $"{Convert.ToString(DateTime.Now)}\t{productId}\t{accountNo}\t{sendTo}\t{message}\t{status} {Environment.NewLine}";

                smsSuccess.InfoFormat(messageFormat);
            }
            catch (Exception e)
            {
                LogError(e.Message);
            }
        }

        public void LogSmsFailed(string filePath,
            string productId,
            string accountNo,
            string sendTo,
            string message,
            string status)
        {
            try
            {
                var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
                XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

                string messageFormat = $"{Convert.ToString(DateTime.Now)}\t{productId}\t{accountNo}\t{sendTo}\t{message}\t{status} {Environment.NewLine}";

                smsFail.InfoFormat(messageFormat);
            }
            catch (Exception e)
            {
                LogError(e.Message);
            }
        }

        public void LogEmailSuccess(string filePath,
            string productId,
            string accountNo,
            string sendTo,
            string message,
            string status)
        {
            try
            {
                var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
                XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

                string messageFormat = $"{Convert.ToString(DateTime.Now)}\t{productId}\t{accountNo}\t{sendTo}\t{message}\t{status} {Environment.NewLine}";

                emailSuccess.InfoFormat(messageFormat);
            }
            catch (Exception e)
            {
                LogError(e.Message);
            }
        }

        public void LogEmailFailed(string filePath,
            string productId,
            string accountNo,
            string sendTo,
            string message,
            string status)
        {
            try
            {
                var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
                XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

                string messageFormat = $"{Convert.ToString(DateTime.Now)}\t{productId}\t{accountNo}\t{sendTo}\t{message}\t{status} {Environment.NewLine}";

                emailFail.InfoFormat(messageFormat);
            }
            catch (Exception e)
            {
                LogError(e.Message);
            }
        }

        public void LogError(string errorMessage)
        {
            try
            {
                var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
                XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

                //string messageFormat = $"************************************************************************************************************* {Environment.NewLine}{Environment.NewLine}{DateTime.Now} <======> {errorMessage} {Environment.NewLine}{Environment.NewLine}*************************************************************************************************************{Environment.NewLine}";

                string messageFormat = $"{DateTime.Now} <======> {errorMessage} {Environment.NewLine}{Environment.NewLine}*************************************************************************************************************{Environment.NewLine}{Environment.NewLine}";

                errorLog.InfoFormat(messageFormat);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public void LogError(string errorMessage)
        //{
        //    var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
        //    XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        //    //string messageFormat = $"************************************************************************************************************* {Environment.NewLine}{Environment.NewLine}{DateTime.Now} <======> {errorMessage} {Environment.NewLine}{Environment.NewLine}*************************************************************************************************************{Environment.NewLine}";
        //    string messageFormat = $"{DateTime.Now} <======> {errorMessage} {Environment.NewLine}{Environment.NewLine}*************************************************************************************************************{Environment.NewLine}{Environment.NewLine}";
        //    errorLog.InfoFormat(messageFormat);
        //}

        public void LogEveryStep(string logMessage)
        {
            try
            {
                var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
                XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

                //string messageFormat = $"************************************************************************************************************* {Environment.NewLine}{Environment.NewLine}{DateTime.Now} <======> {errorMessage} {Environment.NewLine}{Environment.NewLine}*************************************************************************************************************{Environment.NewLine}";

                string messageFormat = $"{DateTime.Now} <======> {logMessage} {Environment.NewLine}{Environment.NewLine}*************************************************************************************************************{Environment.NewLine}{Environment.NewLine}";

                logEveryStep.InfoFormat(messageFormat);
            }
            catch (Exception e)
            {
                LogError(e.Message);
            }
        }
    }
}
