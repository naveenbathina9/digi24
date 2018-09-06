using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface ILogService
    {
        void LogError(string message);
        void LogInfo(string message);
        void LogDebug(string message);
    }
}
