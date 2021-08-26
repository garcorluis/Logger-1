﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using nsLog;

namespace nsLogTest
{
    public class LogTest : Log
    {
        public LogTest(string filePath) : base(filePath)
        {
            this._filePath = filePath;
        }

        ~LogTest()
        {
            if (File.Exists(_filePath))
                RemoveFile();
        }

        public void RemoveFile()
        {
            File.Delete(_filePath);
        }

        private string _filePath;
    }
}
