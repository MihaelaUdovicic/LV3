using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LV3
{
    class Logger
    {
        private static Logger instance;
        public string fileName;

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void SetLogger(string fileName)
        {
            this.fileName = fileName;
        }
        public void Log(string rec)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, true))
            {
                writer.WriteLine(rec);
            }

        }
    }
}
