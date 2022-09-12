using System;
using System.Threading;

namespace ProjectOOP
{
    class MainClass
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("Ange", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Ganon", Faction.BadGuy);

            //goodGuy.Attack(badGuy);


            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0,10) < 5){             //giving the good guy the 50% chance to attack
                    goodGuy.Attack(badGuy);
                } else
                {
                    badGuy.Attack(goodGuy);            //giving the bad guy the 50% chance to attack
                }

                Thread.Sleep(100);        //stops for 500 milliseconds in order to have a more readable sequence of who attacks who on the console.
            }
        }
    }
}
