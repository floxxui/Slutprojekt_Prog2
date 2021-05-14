using System.Text;
using System;
using System.Collections.Generic;

namespace Prog2
{
    public class Hero
    {
        public static int Price{ get; set; }
        //hur mycket en hero kostar
        protected int damage = 1;
        //hur mycket damage en hero gör
        protected int accuracy = 100;
        //hur hög accuracy en hero har
        protected int speed = 1;
        //vilken hastighet en hero attackerar med
        protected bool effect = false;
        //om en hero kan genomföra en effekt på ett monster
        protected string effectPrint = "";
        //skriver ut vad effekten gör
        protected bool upgrade = false;
        //visar om en hero har blivit upgraderad eller inte
        protected string upgradeInfo = "";
        //skriver ut vad uppgraderingen gör
        public static List<Hero> Heroes{ get; set; } = new List<Hero>(); 
        //en lista med alla spelarens heroes. När en spelare köper en hero i shop klassen kommer en ny hero att läggas till i listan

        public virtual void Upgraded()
        {
            
        }

        // public void PrintStats()
        // {
        //     System.Console.WriteLine("Damage: " + damage + "\nSpeed: " + speed + "\nEffect: " + effectPrint + "\nUpgrade Information: " + upgradeInfo);
        // }
    }
}
