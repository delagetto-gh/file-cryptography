using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCryptography.Infrastructure.Logging
{
    public class FileSystemLogger : ILogger
    {
        private readonly string logDirPath;

        private const string LOGNAMEPREFIX = "FileCryptographyLog";

        public FileSystemLogger(string directoryPath)
        {
            this.logDirPath = directoryPath;
        }

        public void Log(string message)
        {
            var logFile = new FileInfo(Path.Combine(this.logDirPath, string.Format("{0}_{1}", LOGNAMEPREFIX, DateTime.Today.ToShortDateString())));

            if (!logFile.Exists)
                logFile.Create();

            using (var logFs = logFile.OpenWrite())
            {
                byte[] logMessage = Encoding.ASCII.GetBytes(string.Format("{0}: {1}", DateTimeOffset.Now, message);
                logFs.Flush();
                logFs.Write(logMessage, (int)logFs.Length, logMessage.Length); //(cast of fs.Length to int) = make sure that fs.Length is never greater than 2,147,483,647 (2GB) and this'll be fine.
                logFs.Flush();
            }
        }
    }
}
