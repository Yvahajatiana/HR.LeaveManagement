using HR.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Domain
{
    public class LeaveRequest : BaseDomainEntity
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public LeaveType LeaveType { get; set; }

        public int LeaveId { get; set;}

        public DateTime DateRequested { get; set; }

        public string RequestComments { get; set; }

        public DateTime DateActionned { get; set; }

        public bool? Approuved { get; set; }

        public bool Canceled { get; set; }
    }
}
