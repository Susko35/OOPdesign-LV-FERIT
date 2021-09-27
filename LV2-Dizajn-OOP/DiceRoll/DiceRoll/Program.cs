using System;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice rolling program");

            RandomGenerator randomGen = RandomGenerator.GetInstance();
            ConsoleLogger logger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("ispis.txt"); //ispis tamo gdje se nalazi .exe

            //Dice roller iz prvih par zadataka
            DiceRoller roller = new DiceRoller();
            for(int i=0;i<20;i++)
            {
                roller.InsertDie(new Die(12));
            }
            roller.RollAllDice();
            logger.Log(roller); //ispis u konzoli
            fileLogger.Log(roller);//ispis u file LV2-Dizajn-OOP\DiceRoll\DiceRoll\bin\Debug\netcoreapp3.1\ispis.txt

            //Closed i flexible dice roller 6 zadatak i dalje
            ClosedDiceRoller closedRoller = new ClosedDiceRoller(20, 20);
            closedRoller.RollAllDice();
            logger.Log(closedRoller); //ispis u konzoli
            fileLogger.Log(closedRoller);//ispis u file LV2-Dizajn-OOP\DiceRoll\DiceRoll\bin\Debug\netcoreapp3.1\ispis.txt


            FlexibleDiceRoller flexibleRoller = new FlexibleDiceRoller();
            for (int i = 0; i < 20; i++)
            {
                flexibleRoller.InsertDie(new Die(64));
            }
            flexibleRoller.RollAllDice();
            logger.Log(flexibleRoller); //ispis u konzoli
            fileLogger.Log(flexibleRoller);//ispis u file LV2-Dizajn-OOP\DiceRoll\DiceRoll\bin\Debug\netcoreapp3.1\ispis.txt

            Console.ReadLine();
        }
    }
}
