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
            //Byter värden från instanser som klassen ärver från Hero klassen
        }

        public void Upgraded()
        {
            if (upgrade == true)
            {
                //Kod inte fixad ennu
                //Ska minska antal steps en fiende behöver ta för att den ska ta damage om fienden har blivit träffad
            }
        }
    }
}
