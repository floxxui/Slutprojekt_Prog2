using System;

namespace Prog2
{
    public class Shop: Menu
    {
        public override GameState VisualiseMenu()
        {
            
            int selectedOption = 0;

            while(true)
            {
                Console.Clear();
                System.Console.WriteLine("What do you need help with?\n");

                System.Console.WriteLine("  How to play  ");
                System.Console.WriteLine("  About towers  ");
                System.Console.WriteLine("  About monsters  ");
                System.Console.WriteLine("  About rounds  ");
                System.Console.WriteLine("  Return  ");
                
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
                else if (keyInfo.Key == ConsoleKey.Enter)
                {

                    if (selectedOption == 0)
                    {                    

                    }
                    else if (selectedOption == 1)
                    {

                    }
                    else if (selectedOption == 2)
                    {
                        
                    }
                    else if (selectedOption == 3)
                    {

                    }
                    else if (selectedOption == 4)
                    {
                        if (previousMenu == GameState.menu)
                        {
                            state = GameState.menu;
                            break;
                        }
                        else if (previousMenu == GameState.inGame)
                        {
                            state = GameState.inGame;
                            break;
                        }   
                    }
                }

                if (selectedOption < 0)
                {
                    selectedOption = 4;
                }
                else if (selectedOption > 4)
                {
                    selectedOption = 0;
                }
            }
            return state;
        }
    }
}
