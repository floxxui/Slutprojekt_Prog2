using System;

namespace Prog2
{
    public class Quit: Menu
    {
        public override GameState VisualiseMenu()
        //Overriden checkar i huvudklassen om det finns en metod med samma namn. I så fall kommer denna metod spelas istället ifall denna subklass försöker nås
        {
            Console.Clear();
            System.Console.WriteLine("Are you sure you want to quit?\n");
            System.Console.WriteLine("Your save data will not be saved\n");

            System.Console.WriteLine("  Return  ");
            System.Console.WriteLine("  Quit  ");
            //Visar alternativ man kan genomföra

            int selectedOption = 0;
            //håller koll på vilket alternativ som för tillfället är markerat

            while(true)
            {
                Console.CursorTop = 4 + selectedOption;
                Console.CursorLeft = 0;
                Console.Write(">");
                //Skriver ut en pil på markerat alternativ

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.CursorTop = 4 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption++;
                    //Byter ut > med ett mellanslag på tidigare position i listan bland alternativen innan det läggs till 1 i instansen selectedOption så pilen kan ritas ut vid det nya alternativet
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.CursorTop = 4 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption--;
                    //Byter ut > med ett mellanslag på tidigare position i listan bland alternativen innan det tas bort 1 i instansen selectedOption så pilen kan ritas ut vid det nya alternativet
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {

                    if (selectedOption == 0)
                    {
                        if (previousMenu == GameState.menu)
                        {
                            state = GameState.menu;
                            break;
                            //Om man valde quit från menu så byts gamestate tillbaka till menu
                        }
                        else if (previousMenu == GameState.inGame)
                        {
                            state = GameState.inGame;
                            break;
                            //Om man valde quit från inGame så byts gamestate tillbaka till inGame
                        }                        
                    }
                    else if (selectedOption == 1)
                    {
                        state = GameState.superQuit;
                        break;
                        //ändrar state till superQuit, vilket stänger ner programmet på direkten
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
                //Ser till att man inte kan komma utanför listan av alternativ. Om man försöker gå utanför nedåt så hamnar man längst upp i listan och tvärtom
            }
    
            return state;
            //Returnar state så att programmet vet vilket gamestate som ska spelas
        }
    }
}
