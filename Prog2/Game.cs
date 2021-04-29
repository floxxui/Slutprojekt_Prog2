using System;

namespace Prog2
{
    public class Game: Menu
    {
        // public static int roundCount = 1;

        public static int RoundCount{get; set;} = 1;

        // public static int RoundCount
        // {
        //     get{ return roundCount; }
        //     set{ roundCount = value; }
        // }
        public override GameState VisualiseMenu()
        {
            int selectedOption = 0;

            while(true)
            {
                Console.Clear();
                System.Console.WriteLine();

                System.Console.WriteLine("  Start Round  ");
                System.Console.WriteLine("  Shop  ");
                System.Console.WriteLine("  Help  ");
                System.Console.WriteLine("  Quit  ");

                Console.CursorTop = 1 + selectedOption;
                Console.CursorLeft = 0;
                Console.Write(">");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.CursorTop = 1 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption++;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.CursorTop = 1 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption--;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (selectedOption == 0 && Hero.Heroes.Count == 0)
                    {
                        Console.Clear();
                        System.Console.WriteLine("You need to purchase at least 1 hero before starting the game");
                        Console.ReadLine();
                    }
                    else if (selectedOption == 0 && Hero.Heroes.Count >= 1)
                    {    
                        Console.Clear();
                        PlayRound();
                    }
                    else if (selectedOption == 1)
                    {
                        state = GameState.shop;
                    }
                    else if (selectedOption == 2)
                    {
                        previousMenu = GameState.inGame;
                        state = GameState.help;
                        break;
                    }
                    else if (selectedOption == 3)
                    {
                        previousMenu = GameState.inGame;
                        state = GameState.quit;
                        break;
                    }
                }

                if (selectedOption < 0)
                {
                    selectedOption = 3;
                }
                else if (selectedOption > 3)
                {
                    selectedOption = 0;
                }  
            }

            return state;
        }

        private void PlayRound()
        {
            Round r = new Round();
            //Round.SelectRound();

            switch (RoundCount)
            {
                case 1:
                    System.Console.WriteLine("yees");
                    Console.ReadLine();

                    Round.Round1GetMonster();
                    
                    System.Console.WriteLine(Round.Rounds.Count);
                    System.Console.WriteLine(Round.MonstersInRound.Count);
                    Console.ReadLine();

                    Round1Play();
                    break;
                case 2:
                    Round.Round2GetMonster();
                    break;
                case 3:
                    Round.Round3GetMonster();
                    break;
                case 4:
                    Round.Round4GetMonster();
                    break;
                case 5:
                    Round.Round5GetMonster();
                    break;
                case 6:
                    Round.Round6GetMonster();
                    break;
                case 7:
                    Round.Round7GetMonster();
                    break;
                case 8:
                    Round.Round8GetMonster();
                    break;
                case 9:
                    Round.Round9GetMonster();
                    break;
                case 10:
                    Round.Round10GetMonster();
                    break;
            }
        }

        private void Round1Play()
        {

        }

    }
}
