﻿using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public LeaveTypeDto LeaveType { get; set; }

        public int LeaveId { get; set; }

        public DateTime DateRequested { get; set; }

        public string RequestComments { get; set; }

        public DateTime DateActionned { get; set; }

        public bool? Approuved { get; set; }

        public bool Canceled { get; set; }
    }
}
