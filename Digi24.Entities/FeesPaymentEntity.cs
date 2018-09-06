using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class FeesPaymentEntity
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public string Notes { get; set; }
        public string StudentId { get; set; }
        public string ReceivedBy { get; set; }
        public string PaymentMadeBy { get; set; }
    }
}
