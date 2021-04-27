using System;

namespace Prog2
{
    public class Menu
    {
        public enum GameState
        {
            //alla gamestates som spelet kommer behöva. Dessa kommer vi kunna byta mellan via exempelvis en switch-case
            menu,
            inGame,
            help,
            shop,
            gameLost,
            gameWon,
            quit,
            superQuit
        }
        protected static GameState previousMenu = GameState.menu;
        //Static gör det möjligt att spara värdet i vilken subklass som hellst och sedan komma åt världet vart som hellst utan att returna det. Detta är användbart eftersom state måste returnas.
        public GameState state = GameState.menu;
        public virtual GameState VisualiseMenu()
        {
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
                else if (keyInfo.Key == ConsoleKey.Enter)
                {

                    if (selectedOption == 0)
                    {                    
                        state = GameState.inGame;
                        break;
                    }
                    else if (selectedOption == 1)
                    {
                        state = GameState.help;
                        previousMenu = GameState.menu;
                        break;
                    }
                    else if (selectedOption == 2)
                    {
                        state = GameState.quit;
                        previousMenu = GameState.menu;
                        break;
                    }
                }

                if (selectedOption < 0)
                {
                    selectedOption = 2;
                }
                else if (selectedOption > 2)
                {
                    selectedOption = 0;
                }  
            }
            return state;

        }
        
    }
}
