using Digi24.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly string _logDirectory = @"C:\Logs\";
        private readonly string _logFileName = "Digi24_log.log";
        public LogRepository()
        {
            _logDirectory = ConfigurationManager.AppSettings.Get("LogDirectory");
        }
        public void LogMessage(string message)
        {
            
        }
    }
}
