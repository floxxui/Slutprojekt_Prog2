using System.Collections.Generic;
using System;

namespace Prog2
{
    public class Round
    {


        public Queue<int> Rounds { get; set; } = new Queue<int>();
        //Skapar en kö där alla rundor läggs in. När en runda är avklarad tas den bort från kön, vilket gör att nästa kan spelas
        public static List<Monster> MonstersInRound { get; set; } = new List<Monster>();
        //Skapar en lista där alla monster som finns med i en runda lagras
        //private int time = 60;

        public Queue<int> GetRound()
        {
            Rounds.Enqueue(1);
            Rounds.Enqueue(2);
            Rounds.Enqueue(3);
            Rounds.Enqueue(4);
            Rounds.Enqueue(5);
            Rounds.Enqueue(6);
            Rounds.Enqueue(7);
            Rounds.Enqueue(8);
            Rounds.Enqueue(9);
            Rounds.Enqueue(10);
            return Rounds;  
            //Lägger in alla rundor i queuen Rounds.
            //När en runda ska spelas tittar den vilken nästa runda i queuen är
        }


        // Delegate = typ som datatyp för en metod
        public delegate Monster MonsterMkr();

        // En metod som matchar delegaten MonsterMkr
        public static Monster srtrtjh()
        {
            return new Monster();
        }

        public static void GetMonster(int round)
        {
            MonsterMkr u = srtrtjh;
            u();

            /*
                Metoden:
                int Hello(string s) {
                    return 22;
                }

                Som anonym metod:

                (string s) => {
                    return 22;
                }

                Så den här metoden matchar delegaten MonsterMkr:

                () => {
                    return new Monster();
                }
            */

            MonsterMkr[] monsterMakers = {
                () => { return new Zombie();},
                () => { return new Monster();},
                () => { return new Monster();},
                () => { return new Monster();},
                () => { return new Monster();},
                () => { return new Monster();}
            };

            int[,] monstersPerRound = new int[10, 6] {
                {10, 0, 0, 0, 0, 0}, //0, zombie
                {10, 5, 0, 0, 0, 0}, //1, bat
                {15, 7, 0, 0, 0, 0}, //2, skeleton
                {30, 10, 0, 0, 0, 0}, //3, spider
                {20, 10, 5, 0, 0, 0}, //4, witch
                {0, 10, 10, 10, 0, 0}, //5, dragon
                {0, 0, 20, 10, 1, 0}, //6
                {0, 0, 10, 5, 5, 0}, //7
                {0, 0, 0, 0, 10, 0}, //8
                {0, 0, 0, 0, 0, 1} //9
            };

            for (int col = 0; col < monstersPerRound.GetLength(1); col++)
            {
                for (int m = 0; m < monstersPerRound[round, col]; m++)
                {
                    MonstersInRound.Add(monsterMakers[col]());
                }
            }
        }

        public int PlayRound(List<Hero> purchasedHeroes)
        {
            
            int totalDamage = 0;
            foreach (Hero hero in purchasedHeroes)
            {
                totalDamage += hero.GetAttack();
            }
            return totalDamage;
        }
    }
}
