using System.Text;
using System;

namespace Prog2
{
    public class Hero
    {
        protected int price;
        protected int damage = 1;
        protected int accuracy = 100;
        protected int speed = 1;
        protected bool effect = false;
        protected string effectPrint = "";
        protected bool upgrade = false;
        protected string upgradeInfo = "";
        protected Random generator = new Random();

        public void PrintStats()
        {
            System.Console.WriteLine("Damage: " + damage + "\nSpeed: " + speed + "\nEffect: " + effectPrint + "\nUpgrade Information: " + upgradeInfo);
        }
    }
}
