﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Connectivity.Connector.Models.Message.Common
{
    public class Error
    {
        public string? Code { get; set; }
        public string? Description { get; set; }
    }
}
