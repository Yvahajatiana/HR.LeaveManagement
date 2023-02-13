using HR.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class ChangeApprouvalLeaveRequestDto : BaseDto
    {
        public bool? IsApproved { get; set; }
    }
}
