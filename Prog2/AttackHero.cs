using System;

namespace Prog2
{
    public class AttackHero: Hero
    {
        public AttackHero()
        {
            damage = 2;
            effect = false;
            upgradeInfo = "Does 2 extra damage on monsters";
            price = 20;
            //Byter värden på instanser som klassen ärver från Hero klassen
        }


        public void Upgraded()
        {
            if (upgrade == true)
            {
                damage =+ 2;
            }
            //Ökar damage med 2 om hjälten har blivit uppgraderad
        }

    }
}
