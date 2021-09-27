using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    interface IFlexibleDiceRoller : ILogable
    {
        void InsertDie(Die die);
        void RemoveAllDice();
        void RollAllDice();

    }
}
