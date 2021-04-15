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
        }

        public void Upgraded()
        {
            if (upgrade == true)
            {
                damage =+ 2;
            }
        }

    }
}
