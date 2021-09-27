using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    interface IClosedDiceRoller : ILogable
    {
        void RollAllDice();
    }
}
