using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    class FileLogger : ILogger
    {

        private string filePath;
        public void Log(ILogable data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, append:true))
            {
                writer.WriteLine("\n"+data.GetStringRepresentation());
            }
        }

        public string GetStringRepresentation()
        {
            throw new NotImplementedException();
        }

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
    }
}
