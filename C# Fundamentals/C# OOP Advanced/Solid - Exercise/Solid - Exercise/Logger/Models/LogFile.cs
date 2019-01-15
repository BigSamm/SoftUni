using Logger.Models.Interfaces;
using System;
using System.IO;

namespace Logger.Models
{
    public class LogFile : ILogFile
    {
        const string DEFAULT_PATH = "../../../../data/";

        public LogFile(string fileName)
        {
            this.Path = DEFAULT_PATH + fileName;
            InitializeFile();
            this.Size = 0;
        }

        private void InitializeFile()
        {
            Directory.CreateDirectory(DEFAULT_PATH);
            File.AppendAllText(this.Path, "");
        }

        public string Path { get; }
        public int Size { get; private set; }

        public void WriteToFile(string errorLog)
        {
            File.AppendAllText(this.Path, errorLog + Environment.NewLine);

            var addedSize = 0;
            for (int i = 0; i < errorLog.Length; i++)
            {
                addedSize += errorLog[i];
            }
            this.Size += addedSize;
        }
    }
}
