using System.Collections.Generic;
using System;

namespace Prog2
{
    public class Round
    {


        public static Queue<int> Rounds{ get; set; } = new Queue<int>();
        //Skapar en kö där alla rundor läggs in. När en runda är avklarad tas den bort från kön, vilket gör att nästa kan spelas
        public static List<Monster> MonstersInRound { get; set; } = new List<Monster>();
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
            //Lägger in alla rundor i queuen Rounds. 
            //När en runda ska spelas tittar den vilken nästa runda i listan är
            //Om 1 är nästa i queuen kommer runda 1 spelas
            //Detta finns inte med i spelet ännu eftersom fighting funktionen inte excisterar
        }

        public static void Round1GetMonster()
        {
            //Hämtar monster till varje runda
            for (int zombies = 0; zombies < 10; zombies++)
            {
                MonstersInRound.Add(new Zombie());
            }
            //I runda 1 finns 10 zombies med. För varje gång forloopen spelas så läggs en zombie in i listan för alla monster. När ett monsters hp är mindre eller lika med 0 så kommer den tas bort från listan (funktionen inte med ennu men det är planen)
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
            //Samma princip som metoden till runda 1. Här läggs bats dock också med
            //Eftersom en klass inte excisterar för bats ennu så finns det ingen logik för den loopen
        }

        public static void Round3GetMonster()
        {
            for (int zombies = 0; zombies < 15; zombies++)
            {
                
            }
            for (int bats = 0; bats < 7; bats++)
            {
                
            }
            //Samma princip som metoden till runda 1. Här läggs bats dock också med
            //Eftersom en klass inte excisterar för bat ennu så finns det ingen logik för den loopen
        }

        public static void Round4GetMonster()
        {
            for (int zombies = 0; zombies < 30; zombies++)
            {
                
            }
            for (int bats = 0; bats < 10; bats++)
            {
                
            }
            //Samma princip som metoden till runda 1. Här läggs bats dock också med
            //Eftersom en klass inte excisterar för bat ennu så finns det ingen logik för den loopen
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
            //Samma princip som metoden till runda 1. Här läggs bats dock också med
            //Eftersom klasser inte excisterar för bat och skeleton ennu så finns det ingen logik i de looperna
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
            //Samma princip som metoden till runda 1. Här läggs bats dock också med
            //Eftersom klasser inte excisterar för bat, spider och skeleton ennu så finns det ingen logik i de looperna
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

            //Samma princip som metoden till runda 1. Här läggs bats dock också med
            //Eftersom klasser inte excisterar för skeleton och spider ennu så finns det ingen logik i de looperna
            //Här ska det även läggas till en witch, men koden är utkommenterad eftersom klassen inte finns
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
            //Samma princip som metoden till runda 1. Här läggs bats dock också med
            //Eftersom klasser inte excisterar för bat, witch och skeleton ennu så finns det ingen logik i de looperna
        }

        public static void Round9GetMonster()
        {
            for (int witches = 0; witches < 10; witches++)
            {
                
            }
            //Samma princip som metoden till runda 1
            //Eftersom en klass inte excisterar för witch ennu så finns det ingen logik i loopen
        }

        public static void Round10GetMonster()
        {
            //monstersInRound.Add(new Dragon());

            //Samma princip som metoden till runda 1. Här läggs bats dock också med
            //Här ska det läggas till en dragon, men koden är utkommenterad eftersom klassen inte finns
        }
    }
}
