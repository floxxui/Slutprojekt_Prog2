using System;

namespace Prog2
{
    public class SpeedHero: Hero
    {
        public SpeedHero()
        {
            speed = 2;
            effectPrint = "Nothing";
            upgradeInfo = "Does 2 extra damage on monsters";
            //Byter värden på instanser som klassen ärver från Hero klassen
        }

        public override void Upgraded()
        {
            if (upgrade == true)
            {
                damage =+ 2;
            }
            //Ökar damage med 2 om hjälten har blivit uppgraderad
        }

    }
}
