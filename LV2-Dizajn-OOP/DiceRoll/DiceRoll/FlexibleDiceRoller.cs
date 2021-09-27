using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    class FlexibleDiceRoller : IFlexibleDiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            RandomGenerator randomGen = RandomGenerator.GetInstance();
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll(randomGen));
            }
        }
        public string GetStringRepresentation()
        {
            StringBuilder sb = new StringBuilder("Dice rolls ", 32);

            foreach (int result in this.resultForEachRoll)
            {
                sb.Append(result);
                sb.Append("   ");
            }
            return sb.ToString();
        }

    }
}
