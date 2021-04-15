using System;

namespace Prog2
{
    public class EffectHero: Hero
    {
        public EffectHero()
        {
            effect = true;
            effectPrint = "Does 1 damage on enemies every 10 steps it takes";
            upgradeInfo = "Does 1 damage on enemies every 5 steps it takes instead";
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
