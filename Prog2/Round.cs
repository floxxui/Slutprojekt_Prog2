using System.Collections.Generic;
using System;

namespace Prog2
{
    public class Round
    {


        public static Queue<int> Rounds{ get; set; } = new Queue<int>();
        public static List<Monster> MonstersInRound { get; set;} = new List<Monster>();
        //private int time = 60;

        public Round()
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
        }

        public static void Round1GetMonster()
        {
            for (int zombies = 0; zombies < 10; zombies++)
            {
                MonstersInRound.Add(new Zombie());
            }
        }

        public static void Round2GetMonster()
        {
            for (int zombies = 0; zombies < 10; zombies++)
            {
                MonstersInRound.Add(new Zombie());
            }
            for (int bats = 0; bats < 5; bats++)
            {
                
            }
        }

        public static void Round3GetMonster()
        {
            for (int zombies = 0; zombies < 15; zombies++)
            {
                
            }
            for (int bats = 0; bats < 7; bats++)
            {
                
            }
        }

        public static void Round4GetMonster()
        {
            for (int zombies = 0; zombies < 30; zombies++)
            {
                
            }
            for (int bats = 0; bats < 10; bats++)
            {
                
            }
        }

        public static void Round5GetMonster()
        {
            for (int zombies = 0; zombies < 20; zombies++)
            {
                
            }
            for (int bats = 0; bats < 10; bats++)
            {
                
            }
            for (int skeletons = 0; skeletons < 5; skeletons++)
            {
                
            }
        }

        public static void Round6GetMonster()
        {
            for (int bats = 0; bats < 10; bats++)
            {
                
            }
            for (int skeletons = 0; skeletons < 10; skeletons++)
            {
                
            }
            for (int spiders = 0; spiders < 10; spiders++)
            {
                
            }
        }

        public static void Round7GetMonster()
        {
            for (int skeletons = 0; skeletons < 10; skeletons++)
            {
                
            }
            for (int spiders = 0; spiders < 10; spiders++)
            {
                
            }
            //monstersInRound.Add(new Witch());
        }

        public static void Round8GetMonster()
        {
            for (int skeletons = 0; skeletons < 10; skeletons++)
            {
                
            }
            for (int spiders = 0; spiders < 5; spiders++)
            {
                
            }
            for (int witches = 0; witches < 5; witches++)
            {
                
            }
        }

        public static void Round9GetMonster()
        {
            for (int witches = 0; witches < 10; witches++)
            {
                
            }
        }

        public static void Round10GetMonster()
        {
            //monstersInRound.Add(new Dragon());
        }
    }
}
