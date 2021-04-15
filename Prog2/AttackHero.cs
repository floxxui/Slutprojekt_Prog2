using System;

namespace Prog2
{
    public class AttackHero: Hero
    {
        public AttackHero()
        {
            damage = 2;
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
