using System;

namespace Prog2
{
    public class Game: Menu
    {
        public override GameState VisualiseMenu()
        {
            Console.Clear();
            System.Console.WriteLine();

            System.Console.WriteLine("  Start Round  ");
            System.Console.WriteLine("  Shop  ");
            System.Console.WriteLine("  Help  ");
            System.Console.WriteLine("  Quit  ");

            int selectedOption = 0;

            while(true)
            {
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

                    if (selectedOption == 0)
                    {    
                        PlayRound();
                        break;
                    }
                    else if (selectedOption == 1)
                    {
                        state = GameState.shop;
                        break;
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
            
        }

    }
}
