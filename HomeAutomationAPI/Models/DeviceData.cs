﻿using System;
using System.Collections.Generic;

namespace HomeAutomationAPI.Models
{
    public partial class DeviceData
    {
        public int DeviceId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Data { get; set; }
    }
}
