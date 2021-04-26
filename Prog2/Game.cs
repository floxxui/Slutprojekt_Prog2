using System;

namespace Prog2
{
    public class Game: Menu
    {
        public override GameState VisualiseMenu()
        {
            Console.Clear();
            System.Console.WriteLine("");
            System.Console.WriteLine();

            System.Console.WriteLine("    ");
            System.Console.WriteLine("    ");
            System.Console.WriteLine("    ");

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
