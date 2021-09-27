using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }

        public void InsertDie(Die die)
        {
            dice.Add(die);
        }

        public void RollAllDice()
        {
            RandomGenerator randomGen = RandomGenerator.GetInstance();
            this.resultForEachRoll.Clear(); //clear of last roll
            foreach(Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll(randomGen));
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(this.resultForEachRoll);
        }

        public string GetStringRepresentation()
        {
            StringBuilder sb = new StringBuilder("Dice rolls ",32);

            foreach(int result in this.resultForEachRoll)
            {
                sb.Append(result);
                sb.Append("   ");
            }
            return sb.ToString();
        }

        public int DiceCount { get { return dice.Count; } }
    }
}
