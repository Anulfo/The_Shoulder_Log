﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
