﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.ClientDTOs.Class
{
    public class ClassDetailClientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public string Course { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
    }
}