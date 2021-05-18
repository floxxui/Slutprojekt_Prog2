using System;

namespace Prog2
{
    public class Monster
    {
        protected int hp;
        //Ger monstret visst hp
        // protected int speed;
        //Ger monster en viss speed. 1 motsvarar 50 steg
        // protected int priority;
        //visar vilken prioritet monstret har. Detta bestämmer vilket monster som kommer attackeras först

        public int GetHp()
        {
            return hp;
        }
    }
}
