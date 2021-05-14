using System;

namespace Prog2
{
    public class Monster
    {
        protected int playerHp = 50;
        protected int monsterHp;
        //Ger monstret visst hp
        protected int speed;
        //Ger monster en viss speed. 1 motsvarar 50 steg
        protected int priority;
        //visar vilken prioritet monstret har. Detta bestämmer vilket monster som kommer attackeras först

        public void PlayGame()
        {
            int stepsToGoal = 60;

            if (stepsToGoal == 0)
            {
                playerHp--;
            }
        }
    }
}
