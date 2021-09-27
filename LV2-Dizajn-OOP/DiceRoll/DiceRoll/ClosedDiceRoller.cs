using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    class ClosedDiceRoller : IClosedDiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public ClosedDiceRoller(int diceCount, int numberOfSides)
        {
            this.dice = new List<Die>();
            for (int i = 0; i < diceCount; i++)
            {
                this.dice.Add(new Die(numberOfSides));
            }
            this.resultForEachRoll = new List<int>();
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
