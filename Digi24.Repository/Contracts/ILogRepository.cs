﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Contracts
{
    public interface ILogRepository
    {
        void LogMessage(string message);
    }
}
