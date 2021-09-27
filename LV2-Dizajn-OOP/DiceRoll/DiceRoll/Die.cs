using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    class Die
    {
        private int numberOfSides;
        private int rolledNumber;

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }

        public int Roll(RandomGenerator randomGen)
        {
            this.rolledNumber = randomGen.NextInt(1, numberOfSides + 1);
            return this.rolledNumber;
        }
    }
}
