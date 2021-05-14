using System;

namespace Prog2
{
    public class StrongAttackHero: AttackHero
    {
        private Random generator = new Random();
        
        public StrongAttackHero()
        {
            damage *= 2;
            accuracy = 50;
            //Gör dubbeldamage från Attack hero men sänker accuracy till 50%
        }
    }
}
