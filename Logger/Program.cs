﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nsLog;
using nsLogData;

namespace nsLoggerMain
{
    class Program
    {
        static void Main(string[] args)
        {
            LogData data = new LogData();
            Log log = new Log();
            log.WriteLog(data.GetLogData());
        }
    }
}
