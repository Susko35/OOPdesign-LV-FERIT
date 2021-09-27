using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    class ConsoleLogger : ILogger
    {
        public void Log(ILogable data)
        {
            Console.WriteLine(data.GetStringRepresentation());
        }

        public string GetStringRepresentation()
        {
            throw new NotImplementedException();
        }
    }
}
