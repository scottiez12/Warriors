using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Warriors.@enum;

namespace Warriors
{
    class Program
    {
        static Random rng = new Random();


        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Bob", @enum.Faction.GoodGuy);
            Warrior badGuy = new Warrior("Steve", @enum.Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(200);
            }
            Console.ReadKey();

        }
    }
}
