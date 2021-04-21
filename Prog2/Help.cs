using System;

namespace Prog2
{
    public class Help: Menu
    {
        public Help()
        {
            
        }

        public override void Do()
        {
            Console.Clear();
            System.Console.WriteLine("What do you need help with?\n");

            System.Console.WriteLine("  How to play  ");
            System.Console.WriteLine("  Tower Information  ");
            System.Console.WriteLine("  Rounds information  ");
            System.Console.WriteLine("  Monster information  ");
            // System.Console.WriteLine("    ");
            // System.Console.WriteLine("    ");
            // System.Console.WriteLine("    ");
            int selectedOption = 0;

            while(true)
            {
                Console.CursorTop = 2 + selectedOption;
                Console.CursorLeft = 0;
                Console.Write(">");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.CursorTop = 2 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption++;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.CursorTop = 2 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption--;
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {

                    if (selectedOption == 0)
                    {                    
                       
                        break;
                    }
                    else if (selectedOption == 1)
                    {
                        
                        break;
                    }
                    else if (selectedOption == 2)
                    {
                        
                        break;
                    }
                    else if (selectedOption == 3)
                    {
                       
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

            return Menu.GameState
        }
    }
}
