using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG_MALL
{
    class Logger
    {
        private const string _fileNameLog = "../../Logger.txt";

        public void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(_fileNameLog, true))
            {
                sw.WriteLine($"{DateTime.Now} - {message}");
            }
        }
    }
}
  