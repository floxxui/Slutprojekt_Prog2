using System;

namespace Prog2
{
    public class Quit: Menu
    {
        public override GameState VisualiseMenu()
        {
            Console.Clear();
            System.Console.WriteLine("Are you sure you want to quit?\n");
            System.Console.WriteLine("Your save data will not be saved\n");

            System.Console.WriteLine("  Return  ");
            System.Console.WriteLine("  Quit  ");

            int selectedOption = 0;

            while(true)
            {
                Console.CursorTop = 4 + selectedOption;
                Console.CursorLeft = 0;
                Console.Write(">");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.CursorTop = 4 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption++;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.CursorTop = 4 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption--;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {

                    if (selectedOption == 0)
                    {                    
                        state = GameState.menu;
                        break;
                    }
                    else if (selectedOption == 1)
                    {
                        state = GameState.superQuit;
                        break;
                    }
                }

                if (selectedOption < 0)
                {
                    selectedOption = 1;
                }
                else if (selectedOption > 1)
                {
                    selectedOption = 0;
                }  
            }
    
            return state;
        }
    }
}
