using System;
using System.Collections.Generic;

namespace slutprojekt_Prog2
{
    class Program
    {
        enum GameState
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
        static void Main(string[] args)
        {
            //Info i anteckningsblock
            //Basically tower defense i konsollen

            bool gameApplication = true;
            GameState state = GameState.menu;
            while (gameApplication == true)
            {
                switch(state){
                    case GameState.menu:
                        state = Menu(state);
                        break;
                    case GameState.help:
                        Help(state);
                        break;
                    case GameState.inGameRound:
                        
                        break;
                    case GameState.inGamePause:
                        System.Console.WriteLine("In game! (det funka!!)");
                        break;
                    case GameState.gameLost:
                        
                        break;
                    case GameState.gameWon:
                        
                        break;
                    case GameState.quit:
                        gameApplication = false;
                    break;
                }
                System.Console.WriteLine(state);
            }
        } 

        static GameState Menu(GameState localState)
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

        static GameState Help(GameState localState)
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

            return localState;

        }

    }
}
