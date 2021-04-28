using System.Collections.Generic;
using System;

namespace Prog2
{
    public class Round
    {
        private static Queue<int> rounds = new Queue<int>();
        private static List<Monster> monstersInRound = new List<Monster>();
        //private int time = 60;

        public Round()
        {
            rounds.Enqueue(1);
            rounds.Enqueue(2);
            rounds.Enqueue(3);
            rounds.Enqueue(4);
            rounds.Enqueue(5);
            rounds.Enqueue(6);
            rounds.Enqueue(7);
            rounds.Enqueue(8);
            rounds.Enqueue(9);
            rounds.Enqueue(10);
        }

        // public static void SelectRound()
        // {
        //     System.Console.WriteLine(rounds.Count);
        //     System.Console.WriteLine(monstersInRound.Count);
        //     Console.ReadLine();

        //     switch (Game.roundCount)
        //     {
        //         case 1:
        //         System.Console.WriteLine("yees");
        //         Console.ReadLine();
        //             Round1();
        //             break;
        //         case 2:
        //             Round2();
        //             break;
        //         case 3:
        //             Round3();
        //             break;
        //         case 4:
        //             Round4();
        //             break;
        //         case 5:
        //             Round5();
        //             break;
        //         case 6:
        //             Round6();
        //             break;
        //         case 7:
        //             Round7();
        //             break;
        //         case 8:
        //             Round8();
        //             break;
        //         case 9:
        //             Round9();
        //             break;
        //         case 10:
        //             Round10();
        //             break;
        //     }
        // }

        public static void Round1()
        {
            for (int zombies = 0; zombies < 10; zombies++)
            {
                monstersInRound.Add(new Zombie());
            }
            System.Console.WriteLine(rounds.Count);
            System.Console.WriteLine(monstersInRound.Count);
            Console.ReadLine();
        }

        public static void Round2()
        {
            for (int zombies = 0; zombies < 10; zombies++)
            {
                monstersInRound.Add(new Zombie());
            }
            for (int bats = 0; bats < 5; bats++)
            {
                
            }
        }

        public static void Round3()
        {
            for (int zombies = 0; zombies < 15; zombies++)
            {
                
            }
            for (int bats = 0; bats < 7; bats++)
            {
                
            }
        }

        public static void Round4()
        {
            for (int zombies = 0; zombies < 30; zombies++)
            {
                
            }
            for (int bats = 0; bats < 10; bats++)
            {
                
            }
        }

        public static void Round5()
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

        public static void Round6()
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

        public static void Round7()
        {
            for (int skeletons = 0; skeletons < 10; skeletons++)
            {
                
            }
            for (int spiders = 0; spiders < 10; spiders++)
            {
                
            }
            //monstersInRound.Add(new Witch());
        }

        public static void Round8()
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

        public static void Round9()
        {
            for (int witches = 0; witches < 10; witches++)
            {
                
            }
        }

        public static void Round10()
        {
            //monstersInRound.Add(new Dragon());
        }
    }
}
