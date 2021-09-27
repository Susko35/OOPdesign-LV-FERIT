using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    interface ILogger : ILogable
    {
        void Log(ILogable data);
    }
}
