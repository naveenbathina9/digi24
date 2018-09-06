using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public class ServiceResponse<T>
    {
        public string ResponseMessage { get; set; }
        public T ResponseData { get; set; }
        public bool IsFaulted { get; set; }
    }
}
