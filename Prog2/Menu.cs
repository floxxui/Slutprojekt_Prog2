using System;

namespace Prog2
{
    public class Menu
    {
        public enum GameState
        {
            //alla gamestates som spelet kommer behöva. Dessa kommer vi kunna byta mellan via exempelvis en switch-case
            menu,
            inGameRound,
            inGamePause,
            help,
            shop,
            gameLost,
            gameWon,
            quit
        }

        public GameState state = GameState.menu;

        public Menu()
        {

        }

        public virtual GameState Do()
        {
            // kod

            Console.Clear();
            System.Console.WriteLine("Hello and welcome to EFG, Epic Fighting Game!\n");
            System.Console.WriteLine("This is a tower defense game where you purchase heroes to defeat the hoard of monsters awaiting\n");
            System.Console.WriteLine("What would you like to do?");
            
            System.Console.WriteLine("  Start Game  ");
            System.Console.WriteLine("  Help  ");
            System.Console.WriteLine("  Quit  ");

            int selectedOption = 0;

            while(true)
            {
                Console.CursorTop = 5 + selectedOption;
                Console.CursorLeft = 0;
                Console.Write(">");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.CursorTop = 5 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption++;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.CursorTop = 5 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption--;
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {

                    if (selectedOption == 0)
                    {                    
                        localState = GameState.inGamePause;
                        break;
                    }
                    else if (selectedOption == 1)
                    {
                        localState = GameState.help;
                        break;
                    }
                    else if (selectedOption == 2)
                    {
                        localState = GameState.quit;
                        break;
                    }
                }
                // else if(keyInfo.Key != ConsoleKey.UpArrow || keyInfo.Key != ConsoleKey.DownArrow || keyInfo.Key != ConsoleKey.Enter)
                // {
                //     Console.CursorTop = 5 + selectedOption;
                //     Console.CursorLeft = 0;
                //     Console.Write(" ");
                // }

                if (selectedOption < 0)
                {
                    selectedOption = 2;
                }
                else if (selectedOption > 2)
                {
                    selectedOption = 0;
                }

                
            }
            return localState;
        }
        
    }
}
