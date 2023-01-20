using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.DTOs.LeaveType;

namespace HR.LeaveManagement.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationListDto
    {
        public int NumberOfDays { get; set; }

        public LeaveTypeDto LeaveType { get; set; }
    }
}
